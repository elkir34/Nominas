using Nominas.Configuration;

namespace Nominas.Examples
{
    /// <summary>
    /// Ejemplos de cómo usar ConfigurationManager desde cualquier parte de la aplicación
    /// </summary>
    public class ConfigurationUsageExamples
    {
        public void EjemploAccesoConfiguracion()
        {
            // Acceder a la configuración desde cualquier parte de la aplicación
            var config = ConfiguracionManager.Instancia;

            // Obtener datos de la empresa
            string nombreEmpresa = config.Empresa.NombreEmpresa;
            string rfc = config.Empresa.RFC;

            // Obtener configuración de base de datos local
            string servidor = config.ErpLocal.Servidor;
            string baseDatos = config.ErpLocal.BaseDatos;
            string usuario = config.ErpLocal.Usuario;
            string contrasena = config.ErpLocal.Contrasena;
            bool usarSSL = config.ErpLocal.SSL;

            // Construir cadena de conexión
            string connectionString = $"Server={servidor};Database={baseDatos};User Id={usuario};Password={contrasena};";

            // Obtener rutas de archivos
            string rutaAnexos = config.ContenedoresLocal.RutaAnexos;
            string rutaDocumentos = config.ContenedoresLocal.RutaDocumentos;

            // Obtener configuración del logotipo
            string rutaLogo = config.Logotipo.RutaLogotipo;
            int anchoLogo = config.Logotipo.AnchoPxLogo;
            int altoLogo = config.Logotipo.AltoPxLogo;
        }

        public void EjemploModificarConfiguracion()
        {
            // Modificar configuración programáticamente
            var config = ConfiguracionManager.Instancia;

            config.Empresa.NombreEmpresa = "Nueva Empresa S.A. de C.V.";
            config.ErpLocal.Servidor = "nuevo-servidor";

            // Guardar cambios
            ConfiguracionManager.Instancia.GuardarConfiguracion();
        }

        public void EjemploRecargarConfiguracion()
        {
            // Recargar configuración desde el archivo (útil si otro proceso modificó el archivo)
            //ConfiguracionManager.Instancia.RecargarConfiguracion();
        }
    }
}
