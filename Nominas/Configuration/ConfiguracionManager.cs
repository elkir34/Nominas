using System.Text.Json;
using System.Text.Json.Serialization;

namespace Nominas.Configuration;

/// <summary>
/// Clase singleton para gestionar la configuración de la aplicación desde JSON
/// </summary>
public class ConfiguracionManager
{
    private static ConfiguracionManager? _instancia;
    private static readonly string RutaArchivoJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");

    //Propiedades de configuración por secciones
    public EmpresaSettings Empresa { get; set; } = new();
    public LogotipoSettings Logotipo { get; set; } = new();
    public RecursosSettings Recursos { get; set; } = new();
    public ErpSettings ErpLocal { get; set; } = new();
    public ErpSettings ErpNube { get; set; } = new();
    public ContenedoresSettings ContenedoresLocal { get; set; } = new();
    public ContenedoresSettings ContenedoresNube { get; set; } = new();

    //Inicializar la instancia singleton al cargar la clase
    public static ConfiguracionManager Instancia => _instancia ??= CargarConfiguracion();

    /*public static ConfiguracionManager Instancia
    {
        get
        {
            if (_instancia == null)
            {
                _instancia = CargarConfiguracion();
            }
            return _instancia;
        }
    }*/

    private static ConfiguracionManager CargarConfiguracion()
    {
        try
        {
            if (File.Exists(RutaArchivoJson))
            {
                string json = File.ReadAllText(RutaArchivoJson);
                var opciones = new JsonSerializerOptions
                {
                    //DefaultIgnoreCondition = JsonIgnoreCondition.Never,
                    //Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                    PropertyNameCaseInsensitive = true
                };
                var config = JsonSerializer.Deserialize<ConfiguracionManager>(json, opciones);
                if (config != null)
                {
                    return config;
                }
            }
        }
        catch
        {
            MessageBox.Show("Error al cargar la configuración. Se cargarán valores predeterminados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // Si no existe o hay erro, crar con valores por defecto
        var nuevaConfig = new ConfiguracionManager();
        nuevaConfig.GuardarConfiguracion(); // Guardar la configuración por defecto
        return nuevaConfig;
    }

    /// <summary>
    /// Guarda la configuración actual en el archivo JSON
    /// </summary>
    public void GuardarConfiguracion()
    {
        try
        {
            var opciones = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = JsonIgnoreCondition.Never,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            string json = JsonSerializer.Serialize(this, opciones);
            File.WriteAllText(RutaArchivoJson, json);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error guardando configuración: {ex.Message}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}