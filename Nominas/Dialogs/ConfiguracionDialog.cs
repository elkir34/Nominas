using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Nominas.Configuration;

namespace Nominas.Dialogs
{
    public partial class ConfiguracionDialog : Form
    {
        private readonly ConfiguracionManager _configManager;

        public ConfiguracionDialog()
        {
            InitializeComponent();
            _configManager = ConfiguracionManager.Instancia;

            //BtnGuardar.Click += BtnGuardar_Click;
            //BtnCancelar.Click += BtnCancelar_Click;
            //BtnBuscarLogotipo.Click += BtnBuscarLogotipo_Click;
            //BtnRutaAnexosLocal.Click += BtnRutaAnexosLocal_Click;
            //BtnRutaDocumentosLocal.Click += BtnRutaDocumentosLocal_Click;
        }

        private void ConfiguracionDialog_Load(object sender, EventArgs e)
        {
            CargarConfiguracion();
        }

        private void CargarConfiguracion()
        {
            var settings = _configManager;

            // Datos de la empresa
            TxtNombreAplicacion.Text = settings.Empresa.NombreAplicacion;
            TxtNombreEmpresa.Text = settings.Empresa.NombreEmpresa;
            TxtDireccion.Text = settings.Empresa.Direccion;
            TxtRFC.Text = settings.Empresa.RFC;
            TxtTelefono.Text = settings.Empresa.Telefono;

            // Logotipo
            TxtRutaLogotipo.Text = settings.Logotipo.RutaLogotipo;
            IntAnchoPxLogo.Value = settings.Logotipo.AnchoPxLogo;
            IntAltoPxLogo.Value = settings.Logotipo.AltoPxLogo;

            // Recursos
            TxtRecursoConsumo.Text = settings.Recursos.RecursoConsumo;
            TxtRecursoRefacciones.Text = settings.Recursos.RecursoRefacciones;
            TxtRecursoProduccion.Text = settings.Recursos.RecursoProduccion;

            // ERP Local
            TxtServidorLocal.Text = settings.ErpLocal.Servidor;
            TxtBaseDatosLocal.Text = settings.ErpLocal.BaseDatos;
            TxtUsuarioLocal.Text = settings.ErpLocal.Usuario;
            TxtContrasenaLocal.Text = settings.ErpLocal.Contrasena;
            CbxSSLLocal.Checked = settings.ErpLocal.SSL;

            // ERP Nube
            TxtServidorNube.Text = settings.ErpNube.Servidor;
            TxtBaseDatosNube.Text = settings.ErpNube.BaseDatos;
            TxtUsuarioNube.Text = settings.ErpNube.Usuario;
            TxtContrasenaNube.Text = settings.ErpNube.Contrasena;
            CbxSSLNube.Checked = settings.ErpNube.SSL;

            // Contenedores Local
            TxtRutaAnexosLocal.Text = settings.ContenedoresLocal.RutaAnexos;
            TxtRutaDocumentosLocal.Text = settings.ContenedoresLocal.RutaDocumentos;

            // Contenedores Nube
            TxtRutaAnexosNube.Text = settings.ContenedoresNube.RutaAnexos;
            TxtRutaDocumentosNube.Text = settings.ContenedoresNube.RutaDocumentos;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            try
            {
                var settings = _configManager;

                // Datos de la empresa
                settings.Empresa.NombreAplicacion = TxtNombreAplicacion.Text.Trim();
                settings.Empresa.NombreEmpresa = TxtNombreEmpresa.Text.Trim();
                settings.Empresa.Direccion = TxtDireccion.Text.Trim();
                settings.Empresa.RFC = TxtRFC.Text.Trim();
                settings.Empresa.Telefono = TxtTelefono.Text.Trim();

                // Logotipo
                settings.Logotipo.RutaLogotipo = TxtRutaLogotipo.Text.Trim();
                settings.Logotipo.AnchoPxLogo = (int)IntAnchoPxLogo.Value;
                settings.Logotipo.AltoPxLogo = (int)IntAltoPxLogo.Value;

                // Recursos
                settings.Recursos.RecursoConsumo = TxtRecursoConsumo.Text.Trim();
                settings.Recursos.RecursoRefacciones = TxtRecursoRefacciones.Text.Trim();
                settings.Recursos.RecursoProduccion = TxtRecursoProduccion.Text.Trim();

                // ERP Local
                settings.ErpLocal.Servidor = TxtServidorLocal.Text.Trim();
                settings.ErpLocal.BaseDatos = TxtBaseDatosLocal.Text.Trim();
                settings.ErpLocal.Usuario = TxtUsuarioLocal.Text.Trim();
                settings.ErpLocal.Contrasena = TxtContrasenaLocal.Text.Trim();
                settings.ErpLocal.SSL = CbxSSLLocal.Checked;

                // ERP Nube
                settings.ErpNube.Servidor = TxtServidorNube.Text.Trim();
                settings.ErpNube.BaseDatos = TxtBaseDatosNube.Text.Trim();
                settings.ErpNube.Usuario = TxtUsuarioNube.Text.Trim();
                settings.ErpNube.Contrasena = TxtContrasenaNube.Text.Trim();
                settings.ErpNube.SSL = CbxSSLNube.Checked;

                // Contenedores Local
                settings.ContenedoresLocal.RutaAnexos = TxtRutaAnexosLocal.Text.Trim();
                settings.ContenedoresLocal.RutaDocumentos = TxtRutaDocumentosLocal.Text.Trim();

                // Contenedores Nube
                settings.ContenedoresNube.RutaAnexos = TxtRutaAnexosNube.Text.Trim();
                settings.ContenedoresNube.RutaDocumentos = TxtRutaDocumentosNube.Text.Trim();

                _configManager.GuardarConfiguracion();

                MessageBox.Show("Configuración guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la configuración: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            // Validar Empresa
            if (string.IsNullOrWhiteSpace(TxtNombreAplicacion.Text))
            {
                MessageBox.Show("El nombre de la aplicación es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TabDatos.SelectedTab = TabPageEmpresa;
                TxtNombreAplicacion.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtNombreEmpresa.Text))
            {
                MessageBox.Show("El nombre de la empresa es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TabDatos.SelectedTab = TabPageEmpresa;
                TxtNombreEmpresa.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtDireccion.Text))
            {
                MessageBox.Show("La dirección es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TabDatos.SelectedTab = TabPageEmpresa;
                TxtDireccion.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtRFC.Text))
            {
                MessageBox.Show("El RFC es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TabDatos.SelectedTab = TabPageEmpresa;
                TxtRFC.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtTelefono.Text))
            {
                MessageBox.Show("El teléfono es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TabDatos.SelectedTab = TabPageEmpresa;
                TxtTelefono.Focus();
                return false;
            }

            // Validar ERP Local
            if (string.IsNullOrWhiteSpace(TxtServidorLocal.Text))
            {
                MessageBox.Show("El servidor local es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TabDatos.SelectedTab = TabPageDatos;
                TxtServidorLocal.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtBaseDatosLocal.Text))
            {
                MessageBox.Show("La base de datos local es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TabDatos.SelectedTab = TabPageDatos;
                TxtBaseDatosLocal.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtUsuarioLocal.Text))
            {
                MessageBox.Show("El usuario local es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TabDatos.SelectedTab = TabPageDatos;
                TxtUsuarioLocal.Focus();
                return false;
            }

            // Validar ERP Nube
            if (string.IsNullOrWhiteSpace(TxtServidorNube.Text))
            {
                MessageBox.Show("El servidor nube es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TabDatos.SelectedTab = TabPageDatos;
                TxtServidorNube.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtBaseDatosNube.Text))
            {
                MessageBox.Show("La base de datos nube es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TabDatos.SelectedTab = TabPageDatos;
                TxtBaseDatosNube.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtUsuarioNube.Text))
            {
                MessageBox.Show("El usuario nube es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TabDatos.SelectedTab = TabPageDatos;
                TxtUsuarioNube.Focus();
                return false;
            }

            // Validar Recursos
            if (string.IsNullOrWhiteSpace(TxtRecursoConsumo.Text))
            {
                MessageBox.Show("El recurso de consumo es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TabDatos.SelectedTab = TabPageDatos;
                TxtRecursoConsumo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtRecursoRefacciones.Text))
            {
                MessageBox.Show("El recurso de refacciones es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TabDatos.SelectedTab = TabPageDatos;
                TxtRecursoRefacciones.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtRecursoProduccion.Text))
            {
                MessageBox.Show("El recurso de producción es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TabDatos.SelectedTab = TabPageDatos;
                TxtRecursoProduccion.Focus();
                return false;
            }

            // Validar Contenedores Local
            if (string.IsNullOrWhiteSpace(TxtRutaAnexosLocal.Text))
            {
                MessageBox.Show("La ruta de anexos local es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TabDatos.SelectedTab = TabPageArchivos;
                TxtRutaAnexosLocal.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtRutaDocumentosLocal.Text))
            {
                MessageBox.Show("La ruta de documentos local es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TabDatos.SelectedTab = TabPageArchivos;
                TxtRutaDocumentosLocal.Focus();
                return false;
            }

            // Validar Contenedores Nube
            if (string.IsNullOrWhiteSpace(TxtRutaAnexosNube.Text))
            {
                MessageBox.Show("La ruta de anexos nube es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TabDatos.SelectedTab = TabPageArchivos;
                TxtRutaAnexosNube.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtRutaDocumentosNube.Text))
            {
                MessageBox.Show("La ruta de documentos nube es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TabDatos.SelectedTab = TabPageArchivos;
                TxtRutaDocumentosNube.Focus();
                return false;
            }

            return true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnBuscarLogotipo_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();
            {
                openFileDialog.Filter = "Imágenes|*.png;*.jpg;*.jpeg;*.bmp;*.gif|Todos los archivos|*.*";
                openFileDialog.Title = "Seleccionar logotipo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TxtRutaLogotipo.Text = openFileDialog.FileName;
                }
            }
        }

        private void BtnRutaAnexosLocal_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog folderDialog = new();
            {
                folderDialog.Description = "Seleccionar carpeta de anexos local";

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    TxtRutaAnexosLocal.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void BtnRutaDocumentosLocal_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog folderDialog = new();
            {
                folderDialog.Description = "Seleccionar carpeta de documentos local";

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    TxtRutaDocumentosLocal.Text = folderDialog.SelectedPath;
                }
            }
        }
    }
}
