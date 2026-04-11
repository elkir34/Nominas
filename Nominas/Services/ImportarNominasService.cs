using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using ExcelDataReader;
using MySql.Data.MySqlClient;
using Nominas.Configuration;
using Nominas.Models;

namespace Nominas.Services;

public class ImportarNominasService
{
    private readonly string _connectionString;

    public ImportarNominasService()
    {
        var config = ConfiguracionManager.Instancia.ErpLocal;
        _connectionString = $"server={config.Servidor};user={config.Usuario};password={config.Contrasena};database={config.BaseDatos}";
    }

    #region Métodos de Base de Datos (NominaService)

    public Dictionary<int, EmpleadoImportacionDto> ObtenerMapaEmpleados()
    {
        var mapa = new Dictionary<int, EmpleadoImportacionDto>();

        using MySqlConnection connection = new(_connectionString);
        connection.Open();

        string query = "SELECT idEmpleado, noCuenta, CONCAT(ApPaterno, ' ', ApMaterno, ' ', Nombre) AS NombreCompleto FROM empleados WHERE noCuenta > 0";
        using MySqlCommand cmd = new(query, connection);
        using MySqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            var empleado = new EmpleadoImportacionDto
            {
                IdEmpleado = reader.GetInt32("idEmpleado"),
                NoCuenta = reader.GetInt32("noCuenta"),
                NombreCompleto = reader.GetString("NombreCompleto")
            };
            mapa[empleado.NoCuenta] = empleado;
        }

        return mapa;
    }

    public bool PolizaYaExiste(int numPoliza, string fechaPoliza)
    {
        using MySqlConnection connection = new(_connectionString);
        connection.Open();

        string query = "SELECT COUNT(*) FROM tbl_cargos WHERE Poliza = @Poliza AND Fecha = @Fecha AND idTipoPoliza = 1 LIMIT 1";
        using MySqlCommand cmd = new(query, connection);
        cmd.Parameters.AddWithValue("@Poliza", numPoliza);
        cmd.Parameters.AddWithValue("@Fecha", fechaPoliza);

        int count = Convert.ToInt32(cmd.ExecuteScalar());
        return count > 0;
    }

    public int GuardarCargos(List<CargoNomina> cargos, string fechaPoliza, int numPoliza, int idUsuario = 1)
    {
        using MySqlConnection connection = new(_connectionString);
        connection.Open();

        using var transaction = connection.BeginTransaction();
        try
        {
            string query = @"INSERT INTO tbl_cargos 
                (idEmpleado, idUsuario, FechaCaptura, Fecha, Hora, Poliza, idTipoPoliza, Rubro, Nominacion, Concepto, Cargo, Abono) 
                VALUES 
                (@idEmpleado, @idUsuario, CURDATE(), @Fecha, CURTIME(), @Poliza, 1, @Rubro, 13, @Concepto, 0, @Abono)";

            using MySqlCommand cmd = new(query, connection, transaction);

            int contador = 0;
            foreach (var cargo in cargos)
            {
                string claveRubro = ObtenerClaveRubro(cargo.IdRubro, connection, transaction);

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idEmpleado", cargo.IdEmpleado);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@Fecha", fechaPoliza);
                cmd.Parameters.AddWithValue("@Poliza", numPoliza);
                cmd.Parameters.AddWithValue("@Rubro", claveRubro);
                cmd.Parameters.AddWithValue("@Concepto", cargo.MiConcepto);
                cmd.Parameters.AddWithValue("@Abono", cargo.Abono);

                cmd.ExecuteNonQuery();
                contador++;
            }

            transaction.Commit();
            return contador;
        }
        catch
        {
            transaction.Rollback();
            throw;
        }
    }

    private string ObtenerClaveRubro(int idRubro, MySqlConnection connection, MySqlTransaction transaction)
    {
        string query = "SELECT Clave FROM ctg_rubros WHERE idRubro = @idRubro LIMIT 1";
        using MySqlCommand cmd = new(query, connection, transaction);
        cmd.Parameters.AddWithValue("@idRubro", idRubro);

        var resultado = cmd.ExecuteScalar();
        return resultado?.ToString() ?? "Z";
    }

    #endregion

    #region Métodos de Procesamiento Excel (ExcelProcessor)

    public (List<CargoNomina> Cargos, PeriodoInfo Periodo, double Total) ProcesarArchivo(string rutaArchivo, Dictionary<int, EmpleadoImportacionDto> mapaEmpleados)
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

        var cargos = new List<CargoNomina>();
        PeriodoInfo periodo;
        double totalAbonos = 0;

        using (var stream = File.Open(rutaArchivo, FileMode.Open, FileAccess.Read))
        {
            using var reader = ExcelReaderFactory.CreateReader(stream);

            var result = reader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = false
                }
            });

            var table = result.Tables[0];

            // 1. Obtener periodo (celda B4 = fila 3, columna 1)
            string textoPeriodo = table.Rows.Count > 3 && table.Rows[3].ItemArray.Length > 1
                ? table.Rows[3][1]?.ToString() ?? ""
                : "";
            periodo = AnalizarPeriodoTexto(textoPeriodo);

            // 2. Mapear columnas de conceptos (Fila 8 = índice 7)
            if (table.Rows.Count <= 7)
            {
                throw new Exception("El archivo no tiene la estructura esperada (faltan filas de encabezados).");
            }

            var filaEncabezados = table.Rows[7];
            var mapaConceptos = new Dictionary<int, string>();

            string[] conceptosValidos = {
                "ANTICIPO NOMINA",
                "CUENTA CORRIENTE",
                "SEMANARIOS",
                "PRESTAMO INFONAVIT",
                "PRÉSTAMO INFONAVIT",
                "ALMACEN CONSUMO",
                "ALMACEN REFACCIONES",
                "AJUSTE AL NETO",
                "EXCEDENTE DE CARNADA",
                "EXCEDENTE CARNADA",
                "ACUERDO LANGOSTA"
            };

            for (int i = 0; i < filaEncabezados.ItemArray.Length; i++)
            {
                var valor = filaEncabezados[i]?.ToString()?.Trim().ToUpper() ?? "";
                if (!string.IsNullOrEmpty(valor))
                {
                    bool esValido = conceptosValidos.Any(concepto => valor.Contains(concepto));
                    if (esValido)
                    {
                        mapaConceptos[i] = filaEncabezados[i]?.ToString()?.Trim() ?? "";
                    }
                }
            }

            if (mapaConceptos.Count == 0)
            {
                throw new Exception("No se encontraron conceptos válidos en el archivo Excel.");
            }

            // 3. Recorrer datos (empezar en fila 9 = índice 8)
            string departamentoActual = "";

            for (int i = 8; i < table.Rows.Count; i++)
            {
                var fila = table.Rows[i];
                if (fila.ItemArray.Length == 0) continue;

                string colA = fila[0]?.ToString()?.Trim() ?? "";

                // Detectar departamento
                if (colA.Contains("Departamento", StringComparison.OrdinalIgnoreCase))
                {
                    departamentoActual = colA;
                    continue;
                }

                // Detectar empleado: debe ser numérico puro
                if (Regex.IsMatch(colA, @"^\d+$"))
                {
                    int noCuenta = int.Parse(colA);

                    if (mapaEmpleados.TryGetValue(noCuenta, out var empleado))
                    {
                        // Buscar cargos en las columnas mapeadas
                        foreach (var kvp in mapaConceptos)
                        {
                            int colIdx = kvp.Key;
                            string nombreConceptoOriginal = kvp.Value;

                            if (fila.ItemArray.Length > colIdx)
                            {
                                string valorStr = fila[colIdx]?.ToString() ?? "";
                                if (double.TryParse(valorStr, out double monto) && monto > 0)
                                {
                                    var reglas = DeterminarRubroYConcepto(
                                        nombreConceptoOriginal,
                                        departamentoActual,
                                        periodo);

                                    var cargo = new CargoNomina
                                    {
                                        IdEmpleado = empleado.IdEmpleado,
                                        NoCuenta = noCuenta,
                                        NombreEmpleado = empleado.NombreCompleto,
                                        ConceptoOriginal = nombreConceptoOriginal,
                                        IdRubro = reglas.IdRubro,
                                        RubroNombre = reglas.NombreRubro,
                                        MiConcepto = reglas.MiConcepto,
                                        Abono = monto
                                    };

                                    cargos.Add(cargo);
                                    totalAbonos += monto;
                                }
                            }
                        }
                    }
                }
            }
        }

        if (cargos.Count == 0)
        {
            throw new Exception("No se encontraron cargos válidos para importar.");
        }

        return (cargos, periodo, totalAbonos);
    }

    private PeriodoInfo AnalizarPeriodoTexto(string texto)
    {
        var regex = new Regex(@"(\d{2})/(\d{2})/(\d{4})");
        var matches = regex.Matches(texto);

        string fechaFinSql = "";
        string mesNombre = "";
        string periodoTexto = "";
        string rango = "";
        bool esSemanal = texto.ToUpper().Contains("SEMANAL");

        string[] nombresMeses = { "", "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO",
                                 "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE" };

        if (matches.Count >= 2)
        {
            var fInicio = matches[0].Value.Split('/');
            var fFin = matches[1].Value.Split('/');

            int diaIni = int.Parse(fInicio[0]);
            int mesIni = int.Parse(fInicio[1]);
            int añoIni = int.Parse(fInicio[2]);

            int diaFin = int.Parse(fFin[0]);
            int mesFin = int.Parse(fFin[1]);
            int añoFin = int.Parse(fFin[2]);

            fechaFinSql = $"{añoFin:0000}-{mesFin:00}-{diaFin:00}";
            mesNombre = nombresMeses[mesFin];
            rango = $"{diaIni}/{mesIni} al {diaFin}/{mesFin}";

            if (esSemanal)
            {
                periodoTexto = rango;
            }
            else
            {
                if (diaIni == 1 && diaFin <= 15)
                {
                    periodoTexto = $"1RA {mesNombre}";
                }
                else if (diaIni == 16)
                {
                    periodoTexto = $"2DA {mesNombre}";
                }
                else
                {
                    periodoTexto = rango;
                }
            }
        }
        else
        {
            fechaFinSql = DateTime.Now.ToString("yyyy-MM-dd");
            periodoTexto = DateTime.Now.ToString("dd/MM/yyyy");
        }

        return new PeriodoInfo
        {
            FechaFinSql = fechaFinSql,
            MesNombre = mesNombre,
            PeriodoTexto = periodoTexto,
            Rango = rango,
            EsSemanal = esSemanal
        };
    }

    private (int IdRubro, string NombreRubro, string MiConcepto) DeterminarRubroYConcepto(
        string conceptoOriginal,
        string departamento,
        PeriodoInfo periodo)
    {
        string conceptoUpper = conceptoOriginal.ToUpper().Trim();
        string deptoUpper = departamento.ToUpper().Trim();

        int idRubro = 26;
        string nombreRubro = "OTRO RUBRO";
        string miConcepto = "A B O N O ";

        if (conceptoUpper.Contains("SEMANARIOS"))
        {
            idRubro = 1;
            nombreRubro = "QUINC./SEM.";
            miConcepto += periodo.EsSemanal
                ? $"SEMANARIO {periodo.Rango}"
                : $"QUINCENARIO {periodo.PeriodoTexto}";
        }
        else if (conceptoUpper.Contains("PRESTAMO INFONAVIT") || conceptoUpper.Contains("PRÉSTAMO INFONAVIT"))
        {
            idRubro = 29;
            nombreRubro = "INFONAVIT";
            miConcepto += $"INFONAVIT {periodo.PeriodoTexto}";
        }
        else if (conceptoUpper.Contains("ALMACEN CONSUMO"))
        {
            idRubro = 8;
            nombreRubro = "CONSUMO";
            miConcepto += $"ALM CONSUMO {periodo.PeriodoTexto}";
        }
        else if (conceptoUpper.Contains("ALMACEN REFACCIONES"))
        {
            idRubro = 7;
            nombreRubro = "REFACCIONES";
            miConcepto += $"ALM REFACCIONES {periodo.PeriodoTexto}";
        }
        else if (conceptoUpper.Contains("AJUSTE AL NETO"))
        {
            idRubro = 26;
            nombreRubro = "OTRO RUBRO";
            miConcepto += "AJUSTE AL NETO";
        }
        else if (conceptoUpper.Contains("EXCEDENTE CARNADA") || conceptoUpper.Contains("EXCEDENTE DE CARNADA"))
        {
            idRubro = 20;
            nombreRubro = "EXC. DE CARNADA";
            miConcepto += $"EX CARNADA {periodo.PeriodoTexto}";
        }
        else if (conceptoUpper.Contains("ACUERDO LANGOSTA"))
        {
            idRubro = 21;
            nombreRubro = "CASTIGO LANGOSTA";
            miConcepto += "ACUERDO LANGOSTA";
        }
        else if (conceptoUpper.Contains("ANTICIPO NOMINA"))
        {
            idRubro = 12;
            nombreRubro = "PTMO.CTA.NOMINA";
            miConcepto += $"ANT NOMINA {periodo.PeriodoTexto}";
        }
        else if (conceptoUpper.Contains("CUENTA CORRIENTE"))
        {
            miConcepto += $"CTA CTE {periodo.PeriodoTexto}";

            if (deptoUpper.Contains("ADMINISTRACION") || deptoUpper.Contains("CONTABILIDAD") ||
                deptoUpper.Contains("PREV SOCIAL") || deptoUpper.Contains("COMPRAS") ||
                deptoUpper.Contains("COMERCIALIZACION") || deptoUpper.Contains("ALMACEN ENSENADA"))
            {
                idRubro = 4;
                nombreRubro = "PTMO.CTA.CTE. ENS.";
            }
            else if (deptoUpper.Contains("OFICINA BT") || deptoUpper.Contains("TRIPULACION"))
            {
                idRubro = 6;
                nombreRubro = "PTMO.CTA.CTE. B.T.";
            }
            else
            {
                idRubro = 5;
                nombreRubro = "PTMO.CTA.CTE. I.N.";
            }
        }

        return (idRubro, nombreRubro, miConcepto);
    }

    #endregion
}
