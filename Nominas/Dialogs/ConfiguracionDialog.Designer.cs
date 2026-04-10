namespace Nominas.Dialogs
{
    partial class ConfiguracionDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabDatos = new TabControl();
            TabPageEmpresa = new TabPage();
            GbxEmpresa = new GroupBox();
            TxtTelefono = new TextBox();
            LblTelefono = new Label();
            TxtRFC = new TextBox();
            LblRFC = new Label();
            TxtDireccion = new TextBox();
            LblDireccion = new Label();
            TxtNombreEmpresa = new TextBox();
            LblEmpresa = new Label();
            TxtNombreAplicacion = new TextBox();
            LblAplicacion = new Label();
            GbxLogotipo = new GroupBox();
            IntAltoPxLogo = new NumericUpDown();
            LblAltoPxLogo = new Label();
            IntAnchoPxLogo = new NumericUpDown();
            LblAnchoPxLogo = new Label();
            BtnBuscarLogotipo = new Button();
            TxtRutaLogotipo = new TextBox();
            LblRutaLogotipo = new Label();
            TabPageDatos = new TabPage();
            GbxRecursos = new GroupBox();
            TxtRecursoProduccion = new TextBox();
            LblRecursoProduccion = new Label();
            TxtRecursoRefacciones = new TextBox();
            LblRecursoRefacciones = new Label();
            TxtRecursoConsumo = new TextBox();
            LblRecursoConsumo = new Label();
            GbxERPLocal = new GroupBox();
            CbxSSLLocal = new CheckBox();
            TxtContrasenaLocal = new TextBox();
            LblContraseñaLocal = new Label();
            TxtUsuarioLocal = new TextBox();
            LblUsuarioLocal = new Label();
            TxtBaseDatosLocal = new TextBox();
            LblBaseDatosLocal = new Label();
            TxtServidorLocal = new TextBox();
            LblServidorLocal = new Label();
            GbxERPNube = new GroupBox();
            CbxSSLNube = new CheckBox();
            TxtContrasenaNube = new TextBox();
            LblContraseñaNube = new Label();
            TxtUsuarioNube = new TextBox();
            LblUsuarioNube = new Label();
            TxtBaseDatosNube = new TextBox();
            LblBaseDatosNube = new Label();
            TxtServidorNube = new TextBox();
            LblServidorNube = new Label();
            TabPageArchivos = new TabPage();
            GbxContenedoresNube = new GroupBox();
            TxtRutaDocumentosNube = new TextBox();
            LblDocumentosNube = new Label();
            TxtRutaAnexosNube = new TextBox();
            LblAnexosNube = new Label();
            GbxContenedoresLocal = new GroupBox();
            BtnRutaDocumentosLocal = new Button();
            TxtRutaDocumentosLocal = new TextBox();
            LblDocumentosLocal = new Label();
            BtnRutaAnexosLocal = new Button();
            TxtRutaAnexosLocal = new TextBox();
            LblAnexosLocal = new Label();
            BtnCancelar = new Button();
            BtnGuardar = new Button();
            TabDatos.SuspendLayout();
            TabPageEmpresa.SuspendLayout();
            GbxEmpresa.SuspendLayout();
            GbxLogotipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IntAltoPxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IntAnchoPxLogo).BeginInit();
            TabPageDatos.SuspendLayout();
            GbxRecursos.SuspendLayout();
            GbxERPLocal.SuspendLayout();
            GbxERPNube.SuspendLayout();
            TabPageArchivos.SuspendLayout();
            GbxContenedoresNube.SuspendLayout();
            GbxContenedoresLocal.SuspendLayout();
            SuspendLayout();
            // 
            // TabDatos
            // 
            TabDatos.Controls.Add(TabPageEmpresa);
            TabDatos.Controls.Add(TabPageDatos);
            TabDatos.Controls.Add(TabPageArchivos);
            TabDatos.Location = new Point(12, 12);
            TabDatos.Name = "TabDatos";
            TabDatos.SelectedIndex = 0;
            TabDatos.Size = new Size(671, 340);
            TabDatos.TabIndex = 12;
            // 
            // TabPageEmpresa
            // 
            TabPageEmpresa.Controls.Add(GbxEmpresa);
            TabPageEmpresa.Controls.Add(GbxLogotipo);
            TabPageEmpresa.Location = new Point(4, 24);
            TabPageEmpresa.Name = "TabPageEmpresa";
            TabPageEmpresa.Padding = new Padding(3);
            TabPageEmpresa.Size = new Size(663, 312);
            TabPageEmpresa.TabIndex = 0;
            TabPageEmpresa.Text = "Empresa";
            TabPageEmpresa.UseVisualStyleBackColor = true;
            // 
            // GbxEmpresa
            // 
            GbxEmpresa.Controls.Add(TxtTelefono);
            GbxEmpresa.Controls.Add(LblTelefono);
            GbxEmpresa.Controls.Add(TxtRFC);
            GbxEmpresa.Controls.Add(LblRFC);
            GbxEmpresa.Controls.Add(TxtDireccion);
            GbxEmpresa.Controls.Add(LblDireccion);
            GbxEmpresa.Controls.Add(TxtNombreEmpresa);
            GbxEmpresa.Controls.Add(LblEmpresa);
            GbxEmpresa.Controls.Add(TxtNombreAplicacion);
            GbxEmpresa.Controls.Add(LblAplicacion);
            GbxEmpresa.Location = new Point(6, 6);
            GbxEmpresa.Name = "GbxEmpresa";
            GbxEmpresa.Size = new Size(651, 174);
            GbxEmpresa.TabIndex = 5;
            GbxEmpresa.TabStop = false;
            GbxEmpresa.Text = "Datos de la empresa";
            // 
            // TxtTelefono
            // 
            TxtTelefono.Location = new Point(78, 148);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(142, 23);
            TxtTelefono.TabIndex = 25;
            // 
            // LblTelefono
            // 
            LblTelefono.AutoSize = true;
            LblTelefono.Location = new Point(16, 151);
            LblTelefono.Name = "LblTelefono";
            LblTelefono.Size = new Size(56, 15);
            LblTelefono.TabIndex = 24;
            LblTelefono.Text = "Teléfono:";
            // 
            // TxtRFC
            // 
            TxtRFC.Location = new Point(78, 119);
            TxtRFC.Name = "TxtRFC";
            TxtRFC.Size = new Size(142, 23);
            TxtRFC.TabIndex = 23;
            // 
            // LblRFC
            // 
            LblRFC.AutoSize = true;
            LblRFC.Location = new Point(41, 122);
            LblRFC.Name = "LblRFC";
            LblRFC.Size = new Size(31, 15);
            LblRFC.TabIndex = 22;
            LblRFC.Text = "RFC:";
            // 
            // TxtDireccion
            // 
            TxtDireccion.Location = new Point(78, 90);
            TxtDireccion.Name = "TxtDireccion";
            TxtDireccion.Size = new Size(567, 23);
            TxtDireccion.TabIndex = 21;
            // 
            // LblDireccion
            // 
            LblDireccion.AutoSize = true;
            LblDireccion.Location = new Point(12, 93);
            LblDireccion.Name = "LblDireccion";
            LblDireccion.Size = new Size(60, 15);
            LblDireccion.TabIndex = 20;
            LblDireccion.Text = "Dirección:";
            // 
            // TxtNombreEmpresa
            // 
            TxtNombreEmpresa.Location = new Point(78, 61);
            TxtNombreEmpresa.Name = "TxtNombreEmpresa";
            TxtNombreEmpresa.Size = new Size(567, 23);
            TxtNombreEmpresa.TabIndex = 19;
            // 
            // LblEmpresa
            // 
            LblEmpresa.AutoSize = true;
            LblEmpresa.Location = new Point(17, 65);
            LblEmpresa.Name = "LblEmpresa";
            LblEmpresa.Size = new Size(55, 15);
            LblEmpresa.TabIndex = 18;
            LblEmpresa.Text = "Empresa:";
            // 
            // TxtNombreAplicacion
            // 
            TxtNombreAplicacion.Location = new Point(78, 22);
            TxtNombreAplicacion.Name = "TxtNombreAplicacion";
            TxtNombreAplicacion.Size = new Size(567, 23);
            TxtNombreAplicacion.TabIndex = 17;
            // 
            // LblAplicacion
            // 
            LblAplicacion.AutoSize = true;
            LblAplicacion.Location = new Point(6, 26);
            LblAplicacion.Name = "LblAplicacion";
            LblAplicacion.Size = new Size(66, 15);
            LblAplicacion.TabIndex = 16;
            LblAplicacion.Text = "Aplicación:";
            // 
            // GbxLogotipo
            // 
            GbxLogotipo.Controls.Add(IntAltoPxLogo);
            GbxLogotipo.Controls.Add(LblAltoPxLogo);
            GbxLogotipo.Controls.Add(IntAnchoPxLogo);
            GbxLogotipo.Controls.Add(LblAnchoPxLogo);
            GbxLogotipo.Controls.Add(BtnBuscarLogotipo);
            GbxLogotipo.Controls.Add(TxtRutaLogotipo);
            GbxLogotipo.Controls.Add(LblRutaLogotipo);
            GbxLogotipo.Location = new Point(6, 186);
            GbxLogotipo.Name = "GbxLogotipo";
            GbxLogotipo.Size = new Size(651, 120);
            GbxLogotipo.TabIndex = 6;
            GbxLogotipo.TabStop = false;
            GbxLogotipo.Text = "Logotipo";
            // 
            // IntAltoPxLogo
            // 
            IntAltoPxLogo.Location = new Point(78, 80);
            IntAltoPxLogo.Name = "IntAltoPxLogo";
            IntAltoPxLogo.Size = new Size(50, 23);
            IntAltoPxLogo.TabIndex = 43;
            // 
            // LblAltoPxLogo
            // 
            LblAltoPxLogo.AutoSize = true;
            LblAltoPxLogo.FlatStyle = FlatStyle.System;
            LblAltoPxLogo.Location = new Point(25, 82);
            LblAltoPxLogo.Name = "LblAltoPxLogo";
            LblAltoPxLogo.Size = new Size(47, 15);
            LblAltoPxLogo.TabIndex = 42;
            LblAltoPxLogo.Text = "Alto px:";
            // 
            // IntAnchoPxLogo
            // 
            IntAnchoPxLogo.Location = new Point(78, 51);
            IntAnchoPxLogo.Name = "IntAnchoPxLogo";
            IntAnchoPxLogo.Size = new Size(50, 23);
            IntAnchoPxLogo.TabIndex = 41;
            // 
            // LblAnchoPxLogo
            // 
            LblAnchoPxLogo.AutoSize = true;
            LblAnchoPxLogo.FlatStyle = FlatStyle.System;
            LblAnchoPxLogo.Location = new Point(12, 53);
            LblAnchoPxLogo.Name = "LblAnchoPxLogo";
            LblAnchoPxLogo.Size = new Size(60, 15);
            LblAnchoPxLogo.TabIndex = 40;
            LblAnchoPxLogo.Text = "Ancho px:";
            // 
            // BtnBuscarLogotipo
            // 
            BtnBuscarLogotipo.Image = Properties.Resources.menu_search;
            BtnBuscarLogotipo.Location = new Point(618, 22);
            BtnBuscarLogotipo.Name = "BtnBuscarLogotipo";
            BtnBuscarLogotipo.Size = new Size(27, 23);
            BtnBuscarLogotipo.TabIndex = 31;
            BtnBuscarLogotipo.UseVisualStyleBackColor = true;
            BtnBuscarLogotipo.Click += BtnBuscarLogotipo_Click;
            // 
            // TxtRutaLogotipo
            // 
            TxtRutaLogotipo.Location = new Point(78, 22);
            TxtRutaLogotipo.Name = "TxtRutaLogotipo";
            TxtRutaLogotipo.Size = new Size(534, 23);
            TxtRutaLogotipo.TabIndex = 30;
            // 
            // LblRutaLogotipo
            // 
            LblRutaLogotipo.AutoSize = true;
            LblRutaLogotipo.Location = new Point(35, 25);
            LblRutaLogotipo.Name = "LblRutaLogotipo";
            LblRutaLogotipo.Size = new Size(34, 15);
            LblRutaLogotipo.TabIndex = 29;
            LblRutaLogotipo.Text = "Ruta:";
            // 
            // TabPageDatos
            // 
            TabPageDatos.Controls.Add(GbxRecursos);
            TabPageDatos.Controls.Add(GbxERPLocal);
            TabPageDatos.Controls.Add(GbxERPNube);
            TabPageDatos.Location = new Point(4, 24);
            TabPageDatos.Name = "TabPageDatos";
            TabPageDatos.Padding = new Padding(3);
            TabPageDatos.Size = new Size(663, 312);
            TabPageDatos.TabIndex = 2;
            TabPageDatos.Text = "Datos";
            TabPageDatos.UseVisualStyleBackColor = true;
            // 
            // GbxRecursos
            // 
            GbxRecursos.Controls.Add(TxtRecursoProduccion);
            GbxRecursos.Controls.Add(LblRecursoProduccion);
            GbxRecursos.Controls.Add(TxtRecursoRefacciones);
            GbxRecursos.Controls.Add(LblRecursoRefacciones);
            GbxRecursos.Controls.Add(TxtRecursoConsumo);
            GbxRecursos.Controls.Add(LblRecursoConsumo);
            GbxRecursos.Location = new Point(6, 181);
            GbxRecursos.Name = "GbxRecursos";
            GbxRecursos.Size = new Size(651, 114);
            GbxRecursos.TabIndex = 10;
            GbxRecursos.TabStop = false;
            GbxRecursos.Text = "Recursos";
            // 
            // TxtRecursoProduccion
            // 
            TxtRecursoProduccion.Location = new Point(91, 78);
            TxtRecursoProduccion.Name = "TxtRecursoProduccion";
            TxtRecursoProduccion.Size = new Size(554, 23);
            TxtRecursoProduccion.TabIndex = 7;
            // 
            // LblRecursoProduccion
            // 
            LblRecursoProduccion.AutoSize = true;
            LblRecursoProduccion.Location = new Point(14, 81);
            LblRecursoProduccion.Name = "LblRecursoProduccion";
            LblRecursoProduccion.Size = new Size(71, 15);
            LblRecursoProduccion.TabIndex = 6;
            LblRecursoProduccion.Text = "Producción:";
            // 
            // TxtRecursoRefacciones
            // 
            TxtRecursoRefacciones.Location = new Point(91, 49);
            TxtRecursoRefacciones.Name = "TxtRecursoRefacciones";
            TxtRecursoRefacciones.Size = new Size(554, 23);
            TxtRecursoRefacciones.TabIndex = 5;
            // 
            // LblRecursoRefacciones
            // 
            LblRecursoRefacciones.AutoSize = true;
            LblRecursoRefacciones.Location = new Point(12, 52);
            LblRecursoRefacciones.Name = "LblRecursoRefacciones";
            LblRecursoRefacciones.Size = new Size(73, 15);
            LblRecursoRefacciones.TabIndex = 4;
            LblRecursoRefacciones.Text = "Refacciones:";
            // 
            // TxtRecursoConsumo
            // 
            TxtRecursoConsumo.Location = new Point(91, 20);
            TxtRecursoConsumo.Name = "TxtRecursoConsumo";
            TxtRecursoConsumo.Size = new Size(554, 23);
            TxtRecursoConsumo.TabIndex = 1;
            // 
            // LblRecursoConsumo
            // 
            LblRecursoConsumo.AutoSize = true;
            LblRecursoConsumo.Location = new Point(23, 23);
            LblRecursoConsumo.Name = "LblRecursoConsumo";
            LblRecursoConsumo.Size = new Size(62, 15);
            LblRecursoConsumo.TabIndex = 0;
            LblRecursoConsumo.Text = "Consumo:";
            // 
            // GbxERPLocal
            // 
            GbxERPLocal.Controls.Add(CbxSSLLocal);
            GbxERPLocal.Controls.Add(TxtContrasenaLocal);
            GbxERPLocal.Controls.Add(LblContraseñaLocal);
            GbxERPLocal.Controls.Add(TxtUsuarioLocal);
            GbxERPLocal.Controls.Add(LblUsuarioLocal);
            GbxERPLocal.Controls.Add(TxtBaseDatosLocal);
            GbxERPLocal.Controls.Add(LblBaseDatosLocal);
            GbxERPLocal.Controls.Add(TxtServidorLocal);
            GbxERPLocal.Controls.Add(LblServidorLocal);
            GbxERPLocal.Location = new Point(6, 6);
            GbxERPLocal.Name = "GbxERPLocal";
            GbxERPLocal.Size = new Size(651, 81);
            GbxERPLocal.TabIndex = 2;
            GbxERPLocal.TabStop = false;
            GbxERPLocal.Text = "ERP Local";
            // 
            // CbxSSLLocal
            // 
            CbxSSLLocal.AutoSize = true;
            CbxSSLLocal.Location = new Point(601, 49);
            CbxSSLLocal.Name = "CbxSSLLocal";
            CbxSSLLocal.Size = new Size(44, 19);
            CbxSSLLocal.TabIndex = 9;
            CbxSSLLocal.Text = "SSL";
            CbxSSLLocal.UseVisualStyleBackColor = true;
            // 
            // TxtContrasenaLocal
            // 
            TxtContrasenaLocal.Location = new Point(302, 49);
            TxtContrasenaLocal.Name = "TxtContrasenaLocal";
            TxtContrasenaLocal.Size = new Size(118, 23);
            TxtContrasenaLocal.TabIndex = 7;
            // 
            // LblContraseñaLocal
            // 
            LblContraseñaLocal.AutoSize = true;
            LblContraseñaLocal.Location = new Point(226, 52);
            LblContraseñaLocal.Name = "LblContraseñaLocal";
            LblContraseñaLocal.Size = new Size(70, 15);
            LblContraseñaLocal.TabIndex = 6;
            LblContraseñaLocal.Text = "Contraseña:";
            // 
            // TxtUsuarioLocal
            // 
            TxtUsuarioLocal.Location = new Point(78, 49);
            TxtUsuarioLocal.Name = "TxtUsuarioLocal";
            TxtUsuarioLocal.Size = new Size(142, 23);
            TxtUsuarioLocal.TabIndex = 5;
            // 
            // LblUsuarioLocal
            // 
            LblUsuarioLocal.AutoSize = true;
            LblUsuarioLocal.Location = new Point(26, 52);
            LblUsuarioLocal.Name = "LblUsuarioLocal";
            LblUsuarioLocal.Size = new Size(50, 15);
            LblUsuarioLocal.TabIndex = 4;
            LblUsuarioLocal.Text = "Usuario:";
            // 
            // TxtBaseDatosLocal
            // 
            TxtBaseDatosLocal.Location = new Point(503, 20);
            TxtBaseDatosLocal.Name = "TxtBaseDatosLocal";
            TxtBaseDatosLocal.Size = new Size(142, 23);
            TxtBaseDatosLocal.TabIndex = 3;
            // 
            // LblBaseDatosLocal
            // 
            LblBaseDatosLocal.AutoSize = true;
            LblBaseDatosLocal.Location = new Point(435, 23);
            LblBaseDatosLocal.Name = "LblBaseDatosLocal";
            LblBaseDatosLocal.Size = new Size(66, 15);
            LblBaseDatosLocal.TabIndex = 2;
            LblBaseDatosLocal.Text = "Base datos:";
            // 
            // TxtServidorLocal
            // 
            TxtServidorLocal.Location = new Point(78, 20);
            TxtServidorLocal.Name = "TxtServidorLocal";
            TxtServidorLocal.Size = new Size(342, 23);
            TxtServidorLocal.TabIndex = 1;
            // 
            // LblServidorLocal
            // 
            LblServidorLocal.AutoSize = true;
            LblServidorLocal.Location = new Point(23, 23);
            LblServidorLocal.Name = "LblServidorLocal";
            LblServidorLocal.Size = new Size(53, 15);
            LblServidorLocal.TabIndex = 0;
            LblServidorLocal.Text = "Servidor:";
            // 
            // GbxERPNube
            // 
            GbxERPNube.Controls.Add(CbxSSLNube);
            GbxERPNube.Controls.Add(TxtContrasenaNube);
            GbxERPNube.Controls.Add(LblContraseñaNube);
            GbxERPNube.Controls.Add(TxtUsuarioNube);
            GbxERPNube.Controls.Add(LblUsuarioNube);
            GbxERPNube.Controls.Add(TxtBaseDatosNube);
            GbxERPNube.Controls.Add(LblBaseDatosNube);
            GbxERPNube.Controls.Add(TxtServidorNube);
            GbxERPNube.Controls.Add(LblServidorNube);
            GbxERPNube.Location = new Point(6, 93);
            GbxERPNube.Name = "GbxERPNube";
            GbxERPNube.Size = new Size(651, 82);
            GbxERPNube.TabIndex = 9;
            GbxERPNube.TabStop = false;
            GbxERPNube.Text = "ERP Nube";
            // 
            // CbxSSLNube
            // 
            CbxSSLNube.AutoSize = true;
            CbxSSLNube.Location = new Point(601, 49);
            CbxSSLNube.Name = "CbxSSLNube";
            CbxSSLNube.Size = new Size(44, 19);
            CbxSSLNube.TabIndex = 9;
            CbxSSLNube.Text = "SSL";
            CbxSSLNube.UseVisualStyleBackColor = true;
            // 
            // TxtContrasenaNube
            // 
            TxtContrasenaNube.Location = new Point(302, 49);
            TxtContrasenaNube.Name = "TxtContrasenaNube";
            TxtContrasenaNube.Size = new Size(118, 23);
            TxtContrasenaNube.TabIndex = 7;
            // 
            // LblContraseñaNube
            // 
            LblContraseñaNube.AutoSize = true;
            LblContraseñaNube.Location = new Point(226, 52);
            LblContraseñaNube.Name = "LblContraseñaNube";
            LblContraseñaNube.Size = new Size(70, 15);
            LblContraseñaNube.TabIndex = 6;
            LblContraseñaNube.Text = "Contraseña:";
            // 
            // TxtUsuarioNube
            // 
            TxtUsuarioNube.Location = new Point(78, 49);
            TxtUsuarioNube.Name = "TxtUsuarioNube";
            TxtUsuarioNube.Size = new Size(142, 23);
            TxtUsuarioNube.TabIndex = 5;
            // 
            // LblUsuarioNube
            // 
            LblUsuarioNube.AutoSize = true;
            LblUsuarioNube.Location = new Point(26, 52);
            LblUsuarioNube.Name = "LblUsuarioNube";
            LblUsuarioNube.Size = new Size(50, 15);
            LblUsuarioNube.TabIndex = 4;
            LblUsuarioNube.Text = "Usuario:";
            // 
            // TxtBaseDatosNube
            // 
            TxtBaseDatosNube.Location = new Point(503, 20);
            TxtBaseDatosNube.Name = "TxtBaseDatosNube";
            TxtBaseDatosNube.Size = new Size(142, 23);
            TxtBaseDatosNube.TabIndex = 3;
            // 
            // LblBaseDatosNube
            // 
            LblBaseDatosNube.AutoSize = true;
            LblBaseDatosNube.Location = new Point(435, 23);
            LblBaseDatosNube.Name = "LblBaseDatosNube";
            LblBaseDatosNube.Size = new Size(66, 15);
            LblBaseDatosNube.TabIndex = 2;
            LblBaseDatosNube.Text = "Base datos:";
            // 
            // TxtServidorNube
            // 
            TxtServidorNube.Location = new Point(78, 20);
            TxtServidorNube.Name = "TxtServidorNube";
            TxtServidorNube.Size = new Size(342, 23);
            TxtServidorNube.TabIndex = 1;
            // 
            // LblServidorNube
            // 
            LblServidorNube.AutoSize = true;
            LblServidorNube.Location = new Point(23, 23);
            LblServidorNube.Name = "LblServidorNube";
            LblServidorNube.Size = new Size(53, 15);
            LblServidorNube.TabIndex = 0;
            LblServidorNube.Text = "Servidor:";
            // 
            // TabPageArchivos
            // 
            TabPageArchivos.Controls.Add(GbxContenedoresNube);
            TabPageArchivos.Controls.Add(GbxContenedoresLocal);
            TabPageArchivos.Location = new Point(4, 24);
            TabPageArchivos.Name = "TabPageArchivos";
            TabPageArchivos.Padding = new Padding(3);
            TabPageArchivos.Size = new Size(663, 312);
            TabPageArchivos.TabIndex = 3;
            TabPageArchivos.Text = "Archivos";
            TabPageArchivos.UseVisualStyleBackColor = true;
            // 
            // GbxContenedoresNube
            // 
            GbxContenedoresNube.Controls.Add(TxtRutaDocumentosNube);
            GbxContenedoresNube.Controls.Add(LblDocumentosNube);
            GbxContenedoresNube.Controls.Add(TxtRutaAnexosNube);
            GbxContenedoresNube.Controls.Add(LblAnexosNube);
            GbxContenedoresNube.Location = new Point(6, 108);
            GbxContenedoresNube.Name = "GbxContenedoresNube";
            GbxContenedoresNube.Size = new Size(651, 84);
            GbxContenedoresNube.TabIndex = 10;
            GbxContenedoresNube.TabStop = false;
            GbxContenedoresNube.Text = "Contenedores de archivos nube (FTP)";
            // 
            // TxtRutaDocumentosNube
            // 
            TxtRutaDocumentosNube.Location = new Point(94, 51);
            TxtRutaDocumentosNube.Name = "TxtRutaDocumentosNube";
            TxtRutaDocumentosNube.Size = new Size(498, 23);
            TxtRutaDocumentosNube.TabIndex = 10;
            // 
            // LblDocumentosNube
            // 
            LblDocumentosNube.AutoSize = true;
            LblDocumentosNube.Location = new Point(10, 54);
            LblDocumentosNube.Name = "LblDocumentosNube";
            LblDocumentosNube.Size = new Size(78, 15);
            LblDocumentosNube.TabIndex = 9;
            LblDocumentosNube.Text = "Documentos:";
            // 
            // TxtRutaAnexosNube
            // 
            TxtRutaAnexosNube.Location = new Point(94, 22);
            TxtRutaAnexosNube.Name = "TxtRutaAnexosNube";
            TxtRutaAnexosNube.Size = new Size(498, 23);
            TxtRutaAnexosNube.TabIndex = 7;
            // 
            // LblAnexosNube
            // 
            LblAnexosNube.AutoSize = true;
            LblAnexosNube.Location = new Point(40, 26);
            LblAnexosNube.Name = "LblAnexosNube";
            LblAnexosNube.Size = new Size(48, 15);
            LblAnexosNube.TabIndex = 6;
            LblAnexosNube.Text = "Anexos:";
            // 
            // GbxContenedoresLocal
            // 
            GbxContenedoresLocal.Controls.Add(BtnRutaDocumentosLocal);
            GbxContenedoresLocal.Controls.Add(TxtRutaDocumentosLocal);
            GbxContenedoresLocal.Controls.Add(LblDocumentosLocal);
            GbxContenedoresLocal.Controls.Add(BtnRutaAnexosLocal);
            GbxContenedoresLocal.Controls.Add(TxtRutaAnexosLocal);
            GbxContenedoresLocal.Controls.Add(LblAnexosLocal);
            GbxContenedoresLocal.Location = new Point(6, 6);
            GbxContenedoresLocal.Name = "GbxContenedoresLocal";
            GbxContenedoresLocal.Size = new Size(651, 96);
            GbxContenedoresLocal.TabIndex = 3;
            GbxContenedoresLocal.TabStop = false;
            GbxContenedoresLocal.Text = "Contenedores de archivos local";
            // 
            // BtnRutaDocumentosLocal
            // 
            BtnRutaDocumentosLocal.Image = Properties.Resources.menu_search;
            BtnRutaDocumentosLocal.Location = new Point(598, 53);
            BtnRutaDocumentosLocal.Name = "BtnRutaDocumentosLocal";
            BtnRutaDocumentosLocal.Size = new Size(47, 37);
            BtnRutaDocumentosLocal.TabIndex = 11;
            BtnRutaDocumentosLocal.UseVisualStyleBackColor = true;
            BtnRutaDocumentosLocal.Click += BtnRutaDocumentosLocal_Click;
            // 
            // TxtRutaDocumentosLocal
            // 
            TxtRutaDocumentosLocal.Location = new Point(94, 61);
            TxtRutaDocumentosLocal.Name = "TxtRutaDocumentosLocal";
            TxtRutaDocumentosLocal.Size = new Size(498, 23);
            TxtRutaDocumentosLocal.TabIndex = 10;
            // 
            // LblDocumentosLocal
            // 
            LblDocumentosLocal.AutoSize = true;
            LblDocumentosLocal.Location = new Point(10, 64);
            LblDocumentosLocal.Name = "LblDocumentosLocal";
            LblDocumentosLocal.Size = new Size(78, 15);
            LblDocumentosLocal.TabIndex = 9;
            LblDocumentosLocal.Text = "Documentos:";
            // 
            // BtnRutaAnexosLocal
            // 
            BtnRutaAnexosLocal.Image = Properties.Resources.menu_search;
            BtnRutaAnexosLocal.Location = new Point(598, 15);
            BtnRutaAnexosLocal.Name = "BtnRutaAnexosLocal";
            BtnRutaAnexosLocal.Size = new Size(47, 37);
            BtnRutaAnexosLocal.TabIndex = 8;
            BtnRutaAnexosLocal.UseVisualStyleBackColor = true;
            BtnRutaAnexosLocal.Click += BtnRutaAnexosLocal_Click;
            // 
            // TxtRutaAnexosLocal
            // 
            TxtRutaAnexosLocal.Location = new Point(94, 22);
            TxtRutaAnexosLocal.Name = "TxtRutaAnexosLocal";
            TxtRutaAnexosLocal.Size = new Size(498, 23);
            TxtRutaAnexosLocal.TabIndex = 7;
            // 
            // LblAnexosLocal
            // 
            LblAnexosLocal.AutoSize = true;
            LblAnexosLocal.Location = new Point(40, 26);
            LblAnexosLocal.Name = "LblAnexosLocal";
            LblAnexosLocal.Size = new Size(48, 15);
            LblAnexosLocal.TabIndex = 6;
            LblAnexosLocal.Text = "Anexos:";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Image = Properties.Resources.menu_cancel;
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(457, 358);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(108, 40);
            BtnCancelar.TabIndex = 14;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.TextAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Image = Properties.Resources.menu_save;
            BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuardar.Location = new Point(571, 358);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(108, 40);
            BtnGuardar.TabIndex = 13;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.TextAlign = ContentAlignment.MiddleLeft;
            BtnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // ConfiguracionDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 406);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardar);
            Controls.Add(TabDatos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConfiguracionDialog";
            Opacity = 0.9D;
            Text = "Configuración";
            Load += ConfiguracionDialog_Load;
            TabDatos.ResumeLayout(false);
            TabPageEmpresa.ResumeLayout(false);
            GbxEmpresa.ResumeLayout(false);
            GbxEmpresa.PerformLayout();
            GbxLogotipo.ResumeLayout(false);
            GbxLogotipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IntAltoPxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)IntAnchoPxLogo).EndInit();
            TabPageDatos.ResumeLayout(false);
            GbxRecursos.ResumeLayout(false);
            GbxRecursos.PerformLayout();
            GbxERPLocal.ResumeLayout(false);
            GbxERPLocal.PerformLayout();
            GbxERPNube.ResumeLayout(false);
            GbxERPNube.PerformLayout();
            TabPageArchivos.ResumeLayout(false);
            GbxContenedoresNube.ResumeLayout(false);
            GbxContenedoresNube.PerformLayout();
            GbxContenedoresLocal.ResumeLayout(false);
            GbxContenedoresLocal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabDatos;
        private TabPage TabPageEmpresa;
        private GroupBox GbxEmpresa;
        private TextBox TxtTelefono;
        private Label LblTelefono;
        private TextBox TxtRFC;
        private Label LblRFC;
        private TextBox TxtDireccion;
        private Label LblDireccion;
        private TextBox TxtNombreEmpresa;
        private Label LblEmpresa;
        private TextBox TxtNombreAplicacion;
        private Label LblAplicacion;
        private GroupBox GbxLogotipo;
        private NumericUpDown IntAltoPxLogo;
        private Label LblAltoPxLogo;
        private NumericUpDown IntAnchoPxLogo;
        private Label LblAnchoPxLogo;
        private Button BtnBuscarLogotipo;
        private TextBox TxtRutaLogotipo;
        private Label LblRutaLogotipo;
        private TabPage TabPageDatos;
        private GroupBox GbxRecursos;
        private TextBox TxtRecursoProduccion;
        private Label LblRecursoProduccion;
        private TextBox TxtRecursoRefacciones;
        private Label LblRecursoRefacciones;
        private TextBox TxtRecursoConsumo;
        private Label LblRecursoConsumo;
        private GroupBox GbxERPLocal;
        private CheckBox CbxSSLLocal;
        private TextBox TxtContrasenaLocal;
        private Label LblContraseñaLocal;
        private TextBox TxtUsuarioLocal;
        private Label LblUsuarioLocal;
        private TextBox TxtBaseDatosLocal;
        private Label LblBaseDatosLocal;
        private TextBox TxtServidorLocal;
        private Label LblServidorLocal;
        private GroupBox GbxERPNube;
        private CheckBox CbxSSLNube;
        private TextBox TxtContrasenaNube;
        private Label LblContraseñaNube;
        private TextBox TxtUsuarioNube;
        private Label LblUsuarioNube;
        private TextBox TxtBaseDatosNube;
        private Label LblBaseDatosNube;
        private TextBox TxtServidorNube;
        private Label LblServidorNube;
        private TabPage TabPageArchivos;
        private GroupBox GbxContenedoresNube;
        private TextBox TxtRutaDocumentosNube;
        private Label LblDocumentosNube;
        private TextBox TxtRutaAnexosNube;
        private Label LblAnexosNube;
        private GroupBox GbxContenedoresLocal;
        private Button BtnRutaDocumentosLocal;
        private TextBox TxtRutaDocumentosLocal;
        private Label LblDocumentosLocal;
        private Button BtnRutaAnexosLocal;
        private TextBox TxtRutaAnexosLocal;
        private Label LblAnexosLocal;
        private Button BtnCancelar;
        private Button BtnGuardar;
    }
}