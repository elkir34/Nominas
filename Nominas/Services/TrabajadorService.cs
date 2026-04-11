using System.Data;
using MySql.Data.MySqlClient;
using Nominas.Configuration;
using Nominas.Models;

namespace Nominas.Services;

public class TrabajadorService
{
    private readonly string _connectionString;

    public TrabajadorService()
    {
        var config = ConfiguracionManager.Instancia.ErpLocal;
        string sslMode = config.SSL ? "Required" : "Preferred";

        _connectionString = $"server={config.Servidor};user={config.Usuario};password={config.Contrasena};database={config.BaseDatos};AllowUserVariables=True;SslMode={sslMode}";
    }

    public DataTable CargarEmpleados()
    {
        using MySqlConnection connection = new(_connectionString);
        connection.Open();

        string strSQL = @"SELECT empleados.idEmpleado, noCuenta, FechaIngreso, TipoEmpleado, idDepartamento, idPuesto, Status, CONCAT(ApPaterno, ' ', ApMaterno, ' ', Nombre) AS Empleado, Nombre, ApPaterno, ApMaterno, 
                                Alias, RFC, CURP, IMSS, Domicilio, Email, Telefono, FORMAT(IFNULL(Cargos,0),2) AS Cargos, FORMAT(IFNULL(Abonos,0),2) AS Abonos, FORMAT(IFNULL(Saldo,0),2) AS Saldo 
                         FROM empleados 
                            LEFT JOIN (SELECT tbl_cargos.idEmpleado As idEmpleado1, SUM(Cargo) As Cargos, SUM(Abono) As Abonos, SUM(Cargo - Abono) AS Saldo 
                                       FROM tbl_cargos GROUP BY tbl_cargos.idEmpleado )T1 ON T1.idEmpleado1=empleados.idEmpleado 
                         GROUP BY empleados.idEmpleado";

        using MySqlDataAdapter adapter = new(strSQL, connection);
        DataTable dt = new();
        adapter.Fill(dt);
        return dt;
    }

    public DataTable CargarDepartamentos()
    {
        using MySqlConnection connection = new(_connectionString);
        connection.Open();

        using MySqlDataAdapter adapter = new("SELECT idDepartamento, CONCAT(Departamento, ' ', Lugar) AS Departamento FROM departamento ORDER BY Departamento", connection);
        DataTable dt = new();
        adapter.Fill(dt);
        return dt;
    }

    public DataTable CargarPuestos()
    {
        using MySqlConnection connection = new(_connectionString);
        connection.Open();

        using MySqlDataAdapter adapter = new("SELECT * FROM puestos ORDER BY Puesto", connection);
        DataTable dt = new();
        adapter.Fill(dt);
        return dt;
    }

    public static DataRow? BuscarEmpleado(int noCuenta, DataTable empleadosTable)
    {
        var rows = empleadosTable.Select($"noCuenta = {noCuenta}");
        return rows.Length > 0 ? rows[0] : null;
    }

    public int GuardarEmpleado(Empleado empleado)
    { 
        using MySqlConnection connection = new(_connectionString);
        connection.Open();

        bool esModificar = empleado.IdEmpleado > 0;

        string strSQL = esModificar  
            ? @"UPDATE empleados SET noCuenta=@noCuenta, FechaIngreso=@FechaIngreso, TipoEmpleado=@TipoEmpleado, idDepartamento=@idDepartamento, idPuesto=@idPuesto, Status=@Status, 
                        Nombre=@Nombre, ApPaterno=@ApPaterno, ApMaterno=@ApMaterno, Alias=@Alias, RFC=@RFC, CURP=@CURP, IMSS=@IMSS, Domicilio=@Domicilio, Email=@Email, Telefono=@Telefono WHERE idEmpleado=@idEmpleado"
            : @"INSERT INTO empleados (noCuenta, FechaIngreso, TipoEmpleado, idDepartamento, idPuesto, Status, Nombre, ApPaterno, ApMaterno, Alias, RFC, CURP, IMSS, Domicilio, Email, Telefono) 
                               VALUES (@noCuenta, @FechaIngreso, @TipoEmpleado, @idDepartamento, @idPuesto, @Status, @Nombre, @ApPaterno, @ApMaterno, @Alias, @RFC, @CURP, @IMSS, @Domicilio, @Email, @Telefono)";

        using MySqlCommand cmd = new(strSQL, connection);
        cmd.Parameters.AddWithValue("@noCuenta", empleado.NoCuenta);
        cmd.Parameters.AddWithValue("@FechaIngreso", empleado.FechaIngreso.ToString("yyyy-MM-dd"));
        cmd.Parameters.AddWithValue("@TipoEmpleado", empleado.TipoEmpleado);
        cmd.Parameters.AddWithValue("@idDepartamento", empleado.IdDepartamento);
        cmd.Parameters.AddWithValue("@idPuesto", empleado.IdPuesto);
        cmd.Parameters.AddWithValue("@Status", empleado.Status);
        cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
        cmd.Parameters.AddWithValue("@ApPaterno", empleado.ApPaterno);
        cmd.Parameters.AddWithValue("@ApMaterno", empleado.ApMaterno);
        cmd.Parameters.AddWithValue("@Alias", empleado.Alias);
        cmd.Parameters.AddWithValue("@RFC", empleado.RFC);
        cmd.Parameters.AddWithValue("@CURP", empleado.CURP);
        cmd.Parameters.AddWithValue("@IMSS", empleado.IMSS);
        cmd.Parameters.AddWithValue("@Domicilio", empleado.Domicilio);
        cmd.Parameters.AddWithValue("@Email", empleado.Email);
        cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);

        if (esModificar)
        {
            cmd.Parameters.AddWithValue("@idEmpleado", empleado.IdEmpleado);
            cmd.ExecuteNonQuery();
            return empleado.IdEmpleado;
        }
        else
        {
            cmd.ExecuteNonQuery();

            using MySqlCommand cmdMax = new("SELECT MAX(idEmpleado) FROM empleados", connection);
            return Convert.ToInt32(cmdMax.ExecuteScalar());
        }
    }

    public int ContarMovimientosEmpleado(int idEmpleado)
    {
        using MySqlConnection connection = new(_connectionString);
        connection.Open();

        using MySqlCommand cmd = new("SELECT COUNT(*) FROM tbl_cargos WHERE idEmpleado=@idEmpleado", connection);
        cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
        return Convert.ToInt32(cmd.ExecuteScalar());
    }

    public bool EliminarEmpleado(int idEmpleado)
    {
        using MySqlConnection connection = new(_connectionString);
        connection.Open();

        using MySqlCommand cmd = new("DELETE FROM empleados WHERE idEmpleado=@idEmpleado", connection);
        cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
        return cmd.ExecuteNonQuery() > 0;
    }
}
