# Sistema de Configuración - Nóminas

## Descripción

Sistema de configuración basado en JSON que permite gestionar todos los parámetros de la aplicación de manera centralizada mediante un patrón Singleton.

## Estructura de Archivos

### Archivos de Configuración

- **`appsettings.json`**: Archivo principal con la configuración real (NO se sube a Git)
- **`appsettings.example.json`**: Archivo de ejemplo para GitHub con valores por defecto

### Clases de Configuración

- **`AppSettings.cs`**: Clases que definen la estructura de la configuración
- **`ConfigurationManager.cs`**: Singleton que gestiona la carga y guardado de la configuración

## Instalación

1. **Primera instalación**: Copia `appsettings.example.json` y renómbralo a `appsettings.json`
2. Edita `appsettings.json` con los valores reales de tu entorno
3. El archivo `appsettings.json` está excluido en `.gitignore` para proteger datos sensibles

## Uso

### Acceder a la Configuración

```csharp
// Desde cualquier parte de la aplicación
var config = ConfigurationManager.Instance.Settings;

// Obtener valores
string nombreEmpresa = config.Empresa.NombreEmpresa;
string servidor = config.ErpLocal.Servidor;
string rutaAnexos = config.ContenedoresLocal.RutaAnexos;
```

### Modificar la Configuración

```csharp
// Modificar valores
var config = ConfigurationManager.Instance.Settings;
config.Empresa.NombreEmpresa = "Nueva Empresa";

// Guardar cambios
ConfigurationManager.Instance.SaveSettings();
```

### Recargar la Configuración

```csharp
// Recargar desde el archivo
ConfigurationManager.Instance.ReloadSettings();
```

## Diálogo de Configuración

La aplicación incluye un diálogo visual (`ConfiguracionDialog`) que permite:

- Editar todos los parámetros de configuración
- Validar que todos los campos obligatorios estén completos
- Buscar archivos y carpetas mediante diálogos nativos
- Guardar automáticamente en `appsettings.json`

## Estructura de la Configuración

### Empresa
- Nombre de la aplicación
- Nombre de la empresa
- Dirección
- RFC
- Teléfono

### Logotipo
- Ruta del archivo de logotipo
- Ancho en píxeles
- Alto en píxeles

### Recursos
- Recurso de consumo
- Recurso de refacciones
- Recurso de producción

### ERP Local
- Servidor
- Base de datos
- Usuario
- Contraseña
- SSL (habilitado/deshabilitado)

### ERP Nube
- Servidor
- Base de datos
- Usuario
- Contraseña
- SSL (habilitado/deshabilitado)

### Contenedores Local
- Ruta de anexos
- Ruta de documentos

### Contenedores Nube (FTP)
- Ruta de anexos
- Ruta de documentos

## Valores por Defecto

Al ejecutar la aplicación por primera vez, se crea automáticamente un archivo `appsettings.json` con valores por defecto seguros para desarrollo.

## Seguridad

- Las contraseñas se almacenan en texto plano en `appsettings.json`
- El archivo está excluido de Git para evitar exponer credenciales
- **Importante**: No subir nunca `appsettings.json` al repositorio
- Considerar encriptar las contraseñas en versiones futuras para mayor seguridad

## Ejemplo de Configuración

Ver `appsettings.example.json` para un ejemplo completo con todos los campos disponibles.
