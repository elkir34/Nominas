using System.Data;
using Nominas.Models;
using Nominas.Services;

namespace Nominas.Views.Importar;

public partial class ImportarNominasView : UserControl
{
    private readonly ImportarNominasService _service;
    private Dictionary<int, EmpleadoImportacionDto> _mapaEmpleados;
    private List<CargoNomina> _cargosActuales;
    private PeriodoInfo? _periodoActual;

    public ImportarNominasView()
    {
        InitializeComponent();
        _service = new ImportarNominasService();
        _cargosActuales = new List<CargoNomina>();
        _mapaEmpleados = new Dictionary<int, EmpleadoImportacionDto>();

        ConfigurarEventos();
        InicializarFormulario();
    }

    private void ConfigurarEventos()
    {
        BtnSeleccionarArchivo.Click += BtnSeleccionarArchivo_Click;
        BtnGuardar.Click += BtnGuardar_Click;
        BtnCancelar.Click += BtnCancelar_Click;
    }

    private void InicializarFormulario()
    {
        DtpFecha.Value = DateTime.Now;
        TxtArchivoExcel.ReadOnly = true;
        BtnGuardar.Enabled = false;
    }

    private async void ImportarNominasView_Load(object sender, EventArgs e)
    {
        try
        {
            Cursor = Cursors.WaitCursor;
            await Task.Run(() =>
            {
                _mapaEmpleados = _service.ObtenerMapaEmpleados();
            });
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Error al cargar empleados: {ex.Message}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        finally
        {
            Cursor = Cursors.Default;
        }
    }

    private async void BtnSeleccionarArchivo_Click(object? sender, EventArgs e)
    {
        if (OpenSeleccionarArchivo.ShowDialog() == DialogResult.OK)
        {
            TxtArchivoExcel.Text = OpenSeleccionarArchivo.FileName;

            try
            {
                Cursor = Cursors.WaitCursor;
                BtnSeleccionarArchivo.Enabled = false;

                var resultado = await Task.Run(() =>
                    _service.ProcesarArchivo(OpenSeleccionarArchivo.FileName, _mapaEmpleados));

                _cargosActuales = resultado.Cargos;
                _periodoActual = resultado.Periodo;

                if (!string.IsNullOrEmpty(resultado.Periodo.FechaFinSql))
                {
                    DtpFecha.Value = DateTime.Parse(resultado.Periodo.FechaFinSql);
                }

                TxtCargosDetectados.Text = resultado.Cargos.Count.ToString();
                TxtPeriodo.Text = resultado.Periodo.PeriodoTexto;
                TxtTotal.Text = $"${resultado.Total:N2}";

                MostrarCargosEnGrid(resultado.Cargos, resultado.Total);
                BtnGuardar.Enabled = true;

                MessageBox.Show(
                    $"✓ Archivo procesado exitosamente\n\n" +
                    $"Cargos detectados: {resultado.Cargos.Count}\n" +
                    $"Total: ${resultado.Total:N2}\n" +
                    $"Periodo: {resultado.Periodo.PeriodoTexto}",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al procesar archivo:\n\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                LimpiarFormulario();
            }
            finally
            {
                Cursor = Cursors.Default;
                BtnSeleccionarArchivo.Enabled = true;
            }
        }
    }

    private void MostrarCargosEnGrid(List<CargoNomina> cargos, double total)
    {
        var tabla = new DataTable();
        tabla.Columns.Add("Cta", typeof(int));
        tabla.Columns.Add("Empleado", typeof(string));
        tabla.Columns.Add("ConceptoExcel", typeof(string));
        tabla.Columns.Add("Rubro", typeof(string));
        tabla.Columns.Add("ConceptoGenerado", typeof(string));
        tabla.Columns.Add("Abono", typeof(string));

        foreach (var cargo in cargos)
        {
            tabla.Rows.Add(
                cargo.NoCuenta,
                cargo.NombreEmpleado,
                cargo.ConceptoOriginal,
                cargo.RubroNombre,
                cargo.MiConcepto,
                $"${cargo.Abono:N2}"
            );
        }

        tabla.Rows.Add(null, null, null, null, "TOTAL:", $"${total:N2}");

        dataGridView1.DataSource = tabla;

        if (dataGridView1.Rows.Count > 0)
        {
            var ultimaFila = dataGridView1.Rows[dataGridView1.Rows.Count - 1];
            ultimaFila.DefaultCellStyle.BackColor = Color.LightGray;
            ultimaFila.DefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
        }
    }

    private async void BtnGuardar_Click(object? sender, EventArgs e)
    {
        if (_cargosActuales.Count == 0)
        {
            MessageBox.Show("No hay cargos para guardar. Primero seleccione un archivo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (string.IsNullOrWhiteSpace(TxtPoliza.Text) || !int.TryParse(TxtPoliza.Text, out int numPoliza))
        {
            MessageBox.Show("Ingrese un número de póliza válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            TxtPoliza.Focus();
            return;
        }

        string fechaPoliza = DtpFecha.Value.ToString("yyyy-MM-dd");

        try
        {
            if (_service.PolizaYaExiste(numPoliza, fechaPoliza))
            {
                var resultado = MessageBox.Show(
                    $"⚠ ADVERTENCIA\n\n" +
                    $"La póliza #{numPoliza} con fecha {DtpFecha.Value:dd/MM/yyyy} ya fue registrada anteriormente.\n\n" +
                    $"¿Desea continuar de todos modos?",
                    "Póliza Duplicada",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.No)
                    return;
            }

            var confirmacion = MessageBox.Show(
                $"¿Está seguro de guardar estos cargos en la base de datos?\n\n" +
                $"Cargos: {_cargosActuales.Count}\n" +
                $"Póliza: #{numPoliza}\n" +
                $"Fecha: {DtpFecha.Value:dd/MM/yyyy}\n\n" +
                $"Esta acción no se puede deshacer.",
                "Confirmar Guardado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.No)
                return;

            Cursor = Cursors.WaitCursor;
            BtnGuardar.Enabled = false;

            int registrosGuardados = await Task.Run(() => _service.GuardarCargos(_cargosActuales, fechaPoliza, numPoliza));

            MessageBox.Show($"✓ ÉXITO\n\nSe importaron {registrosGuardados} cargos a la base de datos.\nPóliza #{numPoliza} del {DtpFecha.Value:dd/MM/yyyy}", "Guardado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarFormulario();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"✗ Error al guardar en la base de datos:\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            Cursor = Cursors.Default;
            BtnGuardar.Enabled = true;
        }
    }

    private void BtnCancelar_Click(object? sender, EventArgs e)
    {
        if (MessageBox.Show("¿Está seguro de cancelar?\n\nSe perderán los datos cargados.", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            LimpiarFormulario();
        }
    }

    private void LimpiarFormulario()
    {
        TxtArchivoExcel.Clear();
        TxtPoliza.Clear();
        TxtCargosDetectados.Clear();
        TxtPeriodo.Clear();
        TxtTotal.Clear();
        DtpFecha.Value = DateTime.Now;
        _cargosActuales.Clear();
        _periodoActual = null;
        dataGridView1.DataSource = null;
        BtnGuardar.Enabled = false;
    }
}
