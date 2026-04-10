namespace Nominas.Configuration
{
    /*public class AppSettings
    {
        public EmpresaSettings Empresa { get; set; } = new();
        public LogotipoSettings Logotipo { get; set; } = new();
        public RecursosSettings Recursos { get; set; } = new();
        public ErpSettings ErpLocal { get; set; } = new();
        public ErpSettings ErpNube { get; set; } = new();
        public ContenedoresSettings ContenedoresLocal { get; set; } = new();
        public ContenedoresSettings ContenedoresNube { get; set; } = new();
    }*/

    public class EmpresaSettings
    {
        public string NombreAplicacion { get; set; } = string.Empty;
        public string NombreEmpresa { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string RFC { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
    }

    public class LogotipoSettings
    {
        public string RutaLogotipo { get; set; } = string.Empty;
        public int AnchoPxLogo { get; set; }
        public int AltoPxLogo { get; set; }
    }

    public class RecursosSettings
    {
        public string RecursoConsumo { get; set; } = string.Empty;
        public string RecursoRefacciones { get; set; } = string.Empty;
        public string RecursoProduccion { get; set; } = string.Empty;
    }

    public class ErpSettings
    {
        public string Servidor { get; set; } = string.Empty;
        public string BaseDatos { get; set; } = string.Empty;
        public string Usuario { get; set; } = string.Empty;
        public string Contrasena { get; set; } = string.Empty;
        public bool SSL { get; set; }
    }

    public class ContenedoresSettings
    {
        public string RutaAnexos { get; set; } = string.Empty;
        public string RutaDocumentos { get; set; } = string.Empty;
    }
}
