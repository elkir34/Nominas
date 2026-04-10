namespace Nominas.Models;

public class Empleado
{
    public int IdEmpleado { get; set; }
    public int NoCuenta { get; set; }
    public DateTime FechaIngreso { get; set; }
    public int TipoEmpleado { get; set; }  // 0=SOCIO, 1=EXTRA, 2=RETIRADOS, 3=OTROS
    public int IdDepartamento { get; set; }
    public int IdPuesto { get; set; }
    public bool Status { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string ApPaterno { get; set; } = string.Empty;
    public string ApMaterno { get; set; } = string.Empty;
    public string Alias { get; set; } = string.Empty;
    public string RFC { get; set; } = string.Empty;
    public string CURP { get; set; } = string.Empty;
    public string IMSS { get; set; } = string.Empty;
    public string Domicilio { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
}

public class Departamento
{
    public int IdDepartamento { get; set; }
    public string NombreDepartamento { get; set; } = string.Empty;
}

public class Puesto
{
    public int IdPuesto { get; set; }
    public string NombrePuesto { get; set; } = string.Empty;
}
