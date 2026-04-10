namespace Nominas.Models;

public class CargoNomina
{
    public int IdEmpleado { get; set; }
    public int NoCuenta { get; set; }
    public string NombreEmpleado { get; set; } = string.Empty;
    public string ConceptoOriginal { get; set; } = string.Empty;
    public int IdRubro { get; set; }
    public string RubroNombre { get; set; } = string.Empty;
    public string MiConcepto { get; set; } = string.Empty;
    public double Abono { get; set; }
}

public class EmpleadoImportacionDto
{
    public int IdEmpleado { get; set; }
    public int NoCuenta { get; set; }
    public string NombreCompleto { get; set; } = string.Empty;
}

public class PeriodoInfo
{
    public string FechaFinSql { get; set; } = string.Empty;
    public string MesNombre { get; set; } = string.Empty;
    public string PeriodoTexto { get; set; } = string.Empty;
    public string Rango { get; set; } = string.Empty;
    public bool EsSemanal { get; set; }
}
