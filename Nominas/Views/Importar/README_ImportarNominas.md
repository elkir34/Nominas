# ImportarNominasView - Documentación

## Descripción
Vista para importar archivos Excel de nóminas desde CONTPAQi y guardar los cargos en la base de datos.

## Archivos del Módulo

### 1. `Nominas\Models\ImportarNominasModels.cs`
Contiene los modelos de datos:
- **CargoNomina**: Representa un cargo individual de nómina
- **Empleado**: Información básica del empleado
- **PeriodoInfo**: Información del período de nómina

### 2. `Nominas\Services\ImportarNominasService.cs`
Servicio consolidado que combina:
- **Métodos de Base de Datos** (antes NominaService):
  - `ObtenerMapaEmpleados()`: Carga todos los empleados activos
  - `PolizaYaExiste()`: Verifica duplicados de pólizas
  - `GuardarCargos()`: Guarda los cargos en la BD
  - `ObtenerClaveRubro()`: Obtiene la clave del rubro

- **Métodos de Procesamiento Excel** (antes ExcelProcessor):
  - `ProcesarArchivo()`: Lee y procesa el archivo Excel
  - `AnalizarPeriodoTexto()`: Extrae información del período
  - `DeterminarRubroYConcepto()`: Mapea conceptos a rubros

### 3. `Nominas\Views\Importar\ImportarNominasView.cs`
UserControl con la interfaz de usuario:
- Selección de archivo Excel
- Visualización de cargos en DataGridView
- Configuración de fecha y número de póliza
- Botones de Guardar y Cancelar

## Funcionalidad

### Flujo de Trabajo

1. **Carga inicial**: Al abrir la vista, carga todos los empleados de la BD
2. **Seleccionar archivo**: Usuario selecciona archivo Excel de CONTPAQi
3. **Procesamiento**:
   - Lee el archivo Excel
   - Detecta el período de nómina
   - Mapea conceptos a empleados y rubros
   - Muestra preview en el grid
4. **Validación y guardado**:
   - Usuario ingresa número de póliza
   - Sistema valida si la póliza ya existe
   - Guarda todos los cargos en la tabla `tbl_cargos`

### Conceptos Soportados

- SEMANARIOS / QUINCENARIOS
- PRÉSTAMO INFONAVIT
- ALMACÉN CONSUMO
- ALMACÉN REFACCIONES
- AJUSTE AL NETO
- EXCEDENTE DE CARNADA
- ACUERDO LANGOSTA
- ANTICIPO NÓMINA
- CUENTA CORRIENTE (por departamento)

## Configuración

### Conexión a Base de Datos
Usa `ConfigurationManager` para obtener la configuración:
```csharp
var config = ConfigurationManager.Instance.Settings.ErpLocal;
```

Parámetros necesarios en `appsettings.json`:
- `ErpLocal.Servidor`
- `ErpLocal.Usuario`
- `ErpLocal.Contrasena`
- `ErpLocal.BaseDatos`

### Paquetes NuGet Requeridos
- `MySql.Data` (9.6.0+)
- `ExcelDataReader` (3.8.0+)
- `ExcelDataReader.DataSet` (3.8.0+)
- `System.Text.Encoding.CodePages` (incluido en .NET 10)

## Estructura de la Base de Datos

### Tabla: `empleados`
- `idEmpleado` (INT)
- `noCuenta` (INT)
- `Nombre`, `ApPaterno`, `ApMaterno` (VARCHAR)

### Tabla: `tbl_cargos`
- `idEmpleado` (INT)
- `idUsuario` (INT)
- `FechaCaptura` (DATE)
- `Fecha` (DATE)
- `Hora` (TIME)
- `Poliza` (INT)
- `idTipoPoliza` (INT) - Siempre 1 para nóminas
- `Rubro` (VARCHAR)
- `Nominacion` (INT) - Siempre 13
- `Concepto` (VARCHAR)
- `Cargo` (DECIMAL) - Siempre 0
- `Abono` (DECIMAL)

### Tabla: `ctg_rubros`
- `idRubro` (INT)
- `Clave` (VARCHAR)

## Mapeo de Rubros

| ID | Nombre Rubro | Conceptos |
|----|--------------|-----------|
| 1  | QUINC./SEM. | SEMANARIOS |
| 4  | PTMO.CTA.CTE. ENS. | Cuenta Corriente (Administración) |
| 5  | PTMO.CTA.CTE. I.N. | Cuenta Corriente (Otros) |
| 6  | PTMO.CTA.CTE. B.T. | Cuenta Corriente (Oficina BT/Tripulación) |
| 7  | REFACCIONES | Almacén Refacciones |
| 8  | CONSUMO | Almacén Consumo |
| 12 | PTMO.CTA.NOMINA | Anticipo Nómina |
| 20 | EXC. DE CARNADA | Excedente de Carnada |
| 21 | CASTIGO LANGOSTA | Acuerdo Langosta |
| 26 | OTRO RUBRO | Ajuste al Neto |
| 29 | INFONAVIT | Préstamo Infonavit |

## Uso desde la Aplicación

```csharp
// En ImportarNominasView.cs, los using necesarios:
using Nominas.Models;    // Para CargoNomina, Empleado, PeriodoInfo
using Nominas.Services;  // Para ImportarNominasService

// En MainForm.cs, abrir la vista:
OpenTab(NavigationKeys.ImportarNominas, 
    () => new ImportarNominasView(), 
    "Importar Nóminas");
```

## Características Especiales

### Detección Automática de Período
- Analiza el texto del período en celda B4
- Detecta si es semanal o quincenal
- Genera nombres automáticos: "1RA ENERO", "2DA FEBRERO", etc.

### Validación de Póliza Duplicada
- Antes de guardar, verifica si la póliza ya existe
- Permite continuar si el usuario confirma

### Vista Previa
- Muestra todos los cargos en el grid antes de guardar
- Fila de totales al final con formato destacado

### Procesamiento Asíncrono
- Carga de empleados en background
- Procesamiento de Excel sin bloquear UI
- Guardado en BD sin bloquear UI

## Ejemplo de Archivo Excel Esperado

```
Fila 1-3: Encabezados de CONTPAQi
Fila 4 (B4): "Periodo 24 al 24 PRODUCCION SOCIOS del 16/12/2025 al 31/12/2025"
Fila 8: [Encabezados de columnas]
Fila 9+: [Datos de empleados]
  Columna A: Número de cuenta
  Columnas siguientes: Conceptos (SEMANARIOS, CUENTA CORRIENTE, etc.)
```

## Notas Importantes

1. **El archivo debe seguir la estructura de CONTPAQi Nóminas**
2. **Los números de cuenta deben existir en la tabla empleados**
3. **Los conceptos deben coincidir con los nombres definidos**
4. **Una vez guardado, no se puede deshacer la operación**

## Migración desde el Proyecto Original

Este módulo es una migración consolidada de:
- `Rpt_trabajador02_nom.cs` (Form → UserControl)
- `Services/ExcelProcessor.cs` → `Nominas\Services\ImportarNominasService.cs` (sección Excel)
- `Services/NominaService.cs` → `Nominas\Services\ImportarNominasService.cs` (sección BD)
- `Models/CargoNomina.cs` → `Nominas\Models\ImportarNominasModels.cs`
- `Models/Empleado.cs` → `Nominas\Models\ImportarNominasModels.cs`

Beneficios de la consolidación:
- ✅ Solo 3 archivos en lugar de 5
- ✅ Models y Services en carpetas separadas y reutilizables
- ✅ Más fácil de mantener
- ✅ Usa ConfigurationManager para conexión
- ✅ Integrado en el sistema de tabs del MainForm
