namespace Nominas
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelMenu = new Panel();
            TstMenu = new ToolStrip();
            BtnToggleMenu = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            BtnInicio = new ToolStripDropDownButton();
            BtnInicioPolizasView = new ToolStripMenuItem();
            BtnInicioEventosView = new ToolStripMenuItem();
            TstSeparador1 = new ToolStripSeparator();
            BtnInicioConfiguracionView = new ToolStripMenuItem();
            BtnTrabajadores = new ToolStripDropDownButton();
            BtnTrabajadoresEstadoCuentaView = new ToolStripMenuItem();
            BtnTrabajadoresMovimientosView = new ToolStripMenuItem();
            BtnTrabajadoresMantenimientoView = new ToolStripMenuItem();
            BtnTrabajadoresPermisosView = new ToolStripMenuItem();
            BtnSalir = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            BtnAyuda = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            BtnReportes = new ToolStripDropDownButton();
            BtnRptAhorrosView = new ToolStripMenuItem();
            BtnRptSaldosRubrosView = new ToolStripMenuItem();
            BtnRptAuxiliaresView = new ToolStripMenuItem();
            BtnNube = new ToolStripDropDownButton();
            BtnNubeValidarDatosView = new ToolStripMenuItem();
            BtnNubeActualizarDatosView = new ToolStripMenuItem();
            BtnImportar = new ToolStripDropDownButton();
            BtnContpaqi = new ToolStripMenuItem();
            BtnImportarContabilidadView = new ToolStripMenuItem();
            BtnImportarNominasView = new ToolStripMenuItem();
            BtnImportarAlmacenView = new ToolStripMenuItem();
            BtnProduccion = new ToolStripDropDownButton();
            BtnLangosta = new ToolStripMenuItem();
            BtnProduccionEstadisticaLangostaView = new ToolStripMenuItem();
            BtnOtrasPesquerias = new ToolStripMenuItem();
            BtnProduccionCortePesqueriaView = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            panelMain = new Panel();
            tabControl = new TabControl();
            TimerExpanse = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            TstMenu.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(TstMenu);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(121, 686);
            panelMenu.TabIndex = 0;
            // 
            // TstMenu
            // 
            TstMenu.BackColor = SystemColors.Control;
            TstMenu.Dock = DockStyle.Left;
            TstMenu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TstMenu.GripStyle = ToolStripGripStyle.Hidden;
            TstMenu.Items.AddRange(new ToolStripItem[] { BtnToggleMenu, toolStripSeparator3, BtnInicio, BtnTrabajadores, BtnSalir, toolStripSeparator2, BtnAyuda, toolStripSeparator1, BtnReportes, BtnNube, BtnImportar, BtnProduccion, toolStripSeparator4 });
            TstMenu.Location = new Point(0, 0);
            TstMenu.Name = "TstMenu";
            TstMenu.Padding = new Padding(3, 0, 1, 0);
            TstMenu.RenderMode = ToolStripRenderMode.System;
            TstMenu.Size = new Size(123, 686);
            TstMenu.TabIndex = 3;
            TstMenu.Text = "toolStrip1";
            // 
            // BtnToggleMenu
            // 
            BtnToggleMenu.Image = Properties.Resources.menu_fold;
            BtnToggleMenu.ImageAlign = ContentAlignment.MiddleRight;
            BtnToggleMenu.ImageTransparentColor = Color.Magenta;
            BtnToggleMenu.Name = "BtnToggleMenu";
            BtnToggleMenu.Size = new Size(114, 20);
            BtnToggleMenu.Tag = "ByP";
            BtnToggleMenu.Text = "ByP";
            BtnToggleMenu.TextAlign = ContentAlignment.MiddleLeft;
            BtnToggleMenu.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnToggleMenu.Click += BtnToggleMenu_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(114, 6);
            // 
            // BtnInicio
            // 
            BtnInicio.DropDownItems.AddRange(new ToolStripItem[] { BtnInicioPolizasView, BtnInicioEventosView, TstSeparador1, BtnInicioConfiguracionView });
            BtnInicio.Image = Properties.Resources.menu_home;
            BtnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            BtnInicio.ImageScaling = ToolStripItemImageScaling.None;
            BtnInicio.ImageTransparentColor = Color.Magenta;
            BtnInicio.Name = "BtnInicio";
            BtnInicio.Size = new Size(114, 36);
            BtnInicio.Tag = "Inicio";
            BtnInicio.Text = "Inicio";
            // 
            // BtnInicioPolizasView
            // 
            BtnInicioPolizasView.Image = Properties.Resources.menu_schedule;
            BtnInicioPolizasView.ImageScaling = ToolStripItemImageScaling.None;
            BtnInicioPolizasView.Name = "BtnInicioPolizasView";
            BtnInicioPolizasView.Size = new Size(166, 38);
            BtnInicioPolizasView.Text = "Pólizas";
            BtnInicioPolizasView.Click += BtnInicioPolizasView_Click;
            // 
            // BtnInicioEventosView
            // 
            BtnInicioEventosView.Image = Properties.Resources.menu_events;
            BtnInicioEventosView.ImageScaling = ToolStripItemImageScaling.None;
            BtnInicioEventosView.Name = "BtnInicioEventosView";
            BtnInicioEventosView.Size = new Size(166, 38);
            BtnInicioEventosView.Text = "Eventos";
            BtnInicioEventosView.Click += BtnInicioEventosView_Click;
            // 
            // TstSeparador1
            // 
            TstSeparador1.Name = "TstSeparador1";
            TstSeparador1.Size = new Size(163, 6);
            // 
            // BtnInicioConfiguracionView
            // 
            BtnInicioConfiguracionView.Image = Properties.Resources.menu_config;
            BtnInicioConfiguracionView.ImageScaling = ToolStripItemImageScaling.None;
            BtnInicioConfiguracionView.Name = "BtnInicioConfiguracionView";
            BtnInicioConfiguracionView.Size = new Size(166, 38);
            BtnInicioConfiguracionView.Text = "Configuración";
            BtnInicioConfiguracionView.Click += BtnInicioConfiguracionView_Click;
            // 
            // BtnTrabajadores
            // 
            BtnTrabajadores.DropDownItems.AddRange(new ToolStripItem[] { BtnTrabajadoresEstadoCuentaView, BtnTrabajadoresMovimientosView, BtnTrabajadoresMantenimientoView, BtnTrabajadoresPermisosView });
            BtnTrabajadores.Image = Properties.Resources.menu_workers;
            BtnTrabajadores.ImageAlign = ContentAlignment.MiddleLeft;
            BtnTrabajadores.ImageScaling = ToolStripItemImageScaling.None;
            BtnTrabajadores.ImageTransparentColor = Color.Magenta;
            BtnTrabajadores.Name = "BtnTrabajadores";
            BtnTrabajadores.Size = new Size(114, 36);
            BtnTrabajadores.Tag = "Trabajadores";
            BtnTrabajadores.Text = "Trabajadores";
            // 
            // BtnTrabajadoresEstadoCuentaView
            // 
            BtnTrabajadoresEstadoCuentaView.Image = Properties.Resources.menu_accounting;
            BtnTrabajadoresEstadoCuentaView.ImageScaling = ToolStripItemImageScaling.None;
            BtnTrabajadoresEstadoCuentaView.Name = "BtnTrabajadoresEstadoCuentaView";
            BtnTrabajadoresEstadoCuentaView.Size = new Size(185, 38);
            BtnTrabajadoresEstadoCuentaView.Text = "Estados de cuenta";
            BtnTrabajadoresEstadoCuentaView.Click += BtnTrabajadoresEstadoCuentaView_Click;
            // 
            // BtnTrabajadoresMovimientosView
            // 
            BtnTrabajadoresMovimientosView.Image = Properties.Resources.menu_checklist;
            BtnTrabajadoresMovimientosView.ImageScaling = ToolStripItemImageScaling.None;
            BtnTrabajadoresMovimientosView.Name = "BtnTrabajadoresMovimientosView";
            BtnTrabajadoresMovimientosView.Size = new Size(185, 38);
            BtnTrabajadoresMovimientosView.Text = "Movimientos";
            BtnTrabajadoresMovimientosView.Click += BtnTrabajadoresMovimientosView_Click;
            // 
            // BtnTrabajadoresMantenimientoView
            // 
            BtnTrabajadoresMantenimientoView.Image = Properties.Resources.menu_worker2;
            BtnTrabajadoresMantenimientoView.ImageScaling = ToolStripItemImageScaling.None;
            BtnTrabajadoresMantenimientoView.Name = "BtnTrabajadoresMantenimientoView";
            BtnTrabajadoresMantenimientoView.Size = new Size(185, 38);
            BtnTrabajadoresMantenimientoView.Text = "Mantenimiento";
            BtnTrabajadoresMantenimientoView.Click += BtnTrabajadoresMantenimientoView_Click;
            // 
            // BtnTrabajadoresPermisosView
            // 
            BtnTrabajadoresPermisosView.Image = Properties.Resources.menu_security;
            BtnTrabajadoresPermisosView.ImageScaling = ToolStripItemImageScaling.None;
            BtnTrabajadoresPermisosView.Name = "BtnTrabajadoresPermisosView";
            BtnTrabajadoresPermisosView.Size = new Size(185, 38);
            BtnTrabajadoresPermisosView.Text = "Permisos";
            BtnTrabajadoresPermisosView.Click += BtnTrabajadoresPermisosView_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Alignment = ToolStripItemAlignment.Right;
            BtnSalir.Image = Properties.Resources.menu_close;
            BtnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSalir.ImageScaling = ToolStripItemImageScaling.None;
            BtnSalir.ImageTransparentColor = Color.Magenta;
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(114, 36);
            BtnSalir.Tag = "Salir";
            BtnSalir.Text = "Salir";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(114, 6);
            // 
            // BtnAyuda
            // 
            BtnAyuda.Alignment = ToolStripItemAlignment.Right;
            BtnAyuda.Image = Properties.Resources.menu_help;
            BtnAyuda.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAyuda.ImageScaling = ToolStripItemImageScaling.None;
            BtnAyuda.ImageTransparentColor = Color.Magenta;
            BtnAyuda.Name = "BtnAyuda";
            BtnAyuda.Size = new Size(114, 36);
            BtnAyuda.Tag = "Ayuda";
            BtnAyuda.Text = "Ayuda";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(114, 6);
            // 
            // BtnReportes
            // 
            BtnReportes.DropDownItems.AddRange(new ToolStripItem[] { BtnRptAhorrosView, BtnRptSaldosRubrosView, BtnRptAuxiliaresView });
            BtnReportes.Image = Properties.Resources.menu_reports;
            BtnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            BtnReportes.ImageScaling = ToolStripItemImageScaling.None;
            BtnReportes.ImageTransparentColor = Color.Magenta;
            BtnReportes.Name = "BtnReportes";
            BtnReportes.Size = new Size(114, 36);
            BtnReportes.Tag = "Reportes";
            BtnReportes.Text = "Reportes";
            // 
            // BtnRptAhorrosView
            // 
            BtnRptAhorrosView.Image = Properties.Resources.menu_production;
            BtnRptAhorrosView.ImageScaling = ToolStripItemImageScaling.None;
            BtnRptAhorrosView.Name = "BtnRptAhorrosView";
            BtnRptAhorrosView.Size = new Size(140, 38);
            BtnRptAhorrosView.Text = "Ahorros";
            BtnRptAhorrosView.Click += BtnRptAhorrosView_Click;
            // 
            // BtnRptSaldosRubrosView
            // 
            BtnRptSaldosRubrosView.Image = Properties.Resources.menu_reports1;
            BtnRptSaldosRubrosView.ImageScaling = ToolStripItemImageScaling.None;
            BtnRptSaldosRubrosView.Name = "BtnRptSaldosRubrosView";
            BtnRptSaldosRubrosView.Size = new Size(140, 38);
            BtnRptSaldosRubrosView.Text = "Saldos";
            BtnRptSaldosRubrosView.Click += BtnRptSaldosRubrosView_Click;
            // 
            // BtnRptAuxiliaresView
            // 
            BtnRptAuxiliaresView.Image = Properties.Resources.menu_reports2;
            BtnRptAuxiliaresView.ImageScaling = ToolStripItemImageScaling.None;
            BtnRptAuxiliaresView.Name = "BtnRptAuxiliaresView";
            BtnRptAuxiliaresView.Size = new Size(140, 38);
            BtnRptAuxiliaresView.Text = "Auxiliares";
            BtnRptAuxiliaresView.Click += BtnRptAuxiliaresView_Click;
            // 
            // BtnNube
            // 
            BtnNube.DropDownItems.AddRange(new ToolStripItem[] { BtnNubeValidarDatosView, BtnNubeActualizarDatosView });
            BtnNube.Image = Properties.Resources.menu_cloud;
            BtnNube.ImageAlign = ContentAlignment.MiddleLeft;
            BtnNube.ImageScaling = ToolStripItemImageScaling.None;
            BtnNube.ImageTransparentColor = Color.Magenta;
            BtnNube.Name = "BtnNube";
            BtnNube.Size = new Size(114, 36);
            BtnNube.Tag = "Nube";
            BtnNube.Text = "Nube";
            // 
            // BtnNubeValidarDatosView
            // 
            BtnNubeValidarDatosView.Image = Properties.Resources.menu_maintenance;
            BtnNubeValidarDatosView.ImageScaling = ToolStripItemImageScaling.None;
            BtnNubeValidarDatosView.Name = "BtnNubeValidarDatosView";
            BtnNubeValidarDatosView.Size = new Size(142, 38);
            BtnNubeValidarDatosView.Text = "Validar";
            BtnNubeValidarDatosView.Click += BtnNubeValidarDatosView_Click;
            // 
            // BtnNubeActualizarDatosView
            // 
            BtnNubeActualizarDatosView.Image = Properties.Resources.menu_update;
            BtnNubeActualizarDatosView.ImageScaling = ToolStripItemImageScaling.None;
            BtnNubeActualizarDatosView.Name = "BtnNubeActualizarDatosView";
            BtnNubeActualizarDatosView.Size = new Size(142, 38);
            BtnNubeActualizarDatosView.Text = "Actualizar";
            BtnNubeActualizarDatosView.Click += BtnNubeActualizarDatosView_Click;
            // 
            // BtnImportar
            // 
            BtnImportar.DropDownItems.AddRange(new ToolStripItem[] { BtnContpaqi, BtnImportarAlmacenView });
            BtnImportar.Image = Properties.Resources.menu_imports;
            BtnImportar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnImportar.ImageScaling = ToolStripItemImageScaling.None;
            BtnImportar.ImageTransparentColor = Color.Magenta;
            BtnImportar.Name = "BtnImportar";
            BtnImportar.Size = new Size(114, 36);
            BtnImportar.Tag = "Importar";
            BtnImportar.Text = "Importar";
            // 
            // BtnContpaqi
            // 
            BtnContpaqi.DropDownItems.AddRange(new ToolStripItem[] { BtnImportarContabilidadView, BtnImportarNominasView });
            BtnContpaqi.Image = Properties.Resources.menu_accounting2;
            BtnContpaqi.ImageScaling = ToolStripItemImageScaling.None;
            BtnContpaqi.Name = "BtnContpaqi";
            BtnContpaqi.Size = new Size(149, 38);
            BtnContpaqi.Text = "CONTPAQi";
            // 
            // BtnImportarContabilidadView
            // 
            BtnImportarContabilidadView.Image = Properties.Resources.menu_contpaqicontabilidad;
            BtnImportarContabilidadView.ImageScaling = ToolStripItemImageScaling.None;
            BtnImportarContabilidadView.Name = "BtnImportarContabilidadView";
            BtnImportarContabilidadView.Size = new Size(158, 40);
            BtnImportarContabilidadView.Text = "Contabilidad";
            BtnImportarContabilidadView.Click += BtnImportarContabilidadView_Click;
            // 
            // BtnImportarNominasView
            // 
            BtnImportarNominasView.Image = Properties.Resources.menu_contpaqinominas;
            BtnImportarNominasView.ImageScaling = ToolStripItemImageScaling.None;
            BtnImportarNominasView.Name = "BtnImportarNominasView";
            BtnImportarNominasView.Size = new Size(158, 40);
            BtnImportarNominasView.Text = "Nóminas";
            BtnImportarNominasView.Click += BtnImportarNominasView_Click;
            // 
            // BtnImportarAlmacenView
            // 
            BtnImportarAlmacenView.Image = Properties.Resources.menu_stores;
            BtnImportarAlmacenView.ImageScaling = ToolStripItemImageScaling.None;
            BtnImportarAlmacenView.Name = "BtnImportarAlmacenView";
            BtnImportarAlmacenView.Size = new Size(149, 38);
            BtnImportarAlmacenView.Text = "Almacenes";
            BtnImportarAlmacenView.Click += BtnImportarAlmacenView_Click;
            // 
            // BtnProduccion
            // 
            BtnProduccion.DropDownItems.AddRange(new ToolStripItem[] { BtnLangosta, BtnOtrasPesquerias });
            BtnProduccion.Image = Properties.Resources.menu_production;
            BtnProduccion.ImageAlign = ContentAlignment.MiddleLeft;
            BtnProduccion.ImageScaling = ToolStripItemImageScaling.None;
            BtnProduccion.ImageTransparentColor = Color.Magenta;
            BtnProduccion.Name = "BtnProduccion";
            BtnProduccion.Size = new Size(114, 36);
            BtnProduccion.Tag = "Producción";
            BtnProduccion.Text = "Producción";
            // 
            // BtnLangosta
            // 
            BtnLangosta.DropDownItems.AddRange(new ToolStripItem[] { BtnProduccionEstadisticaLangostaView });
            BtnLangosta.Image = Properties.Resources.menu_lobster;
            BtnLangosta.ImageScaling = ToolStripItemImageScaling.None;
            BtnLangosta.Name = "BtnLangosta";
            BtnLangosta.Size = new Size(177, 38);
            BtnLangosta.Text = "Langosta";
            // 
            // BtnProduccionEstadisticaLangostaView
            // 
            BtnProduccionEstadisticaLangostaView.Image = Properties.Resources.menu_events2;
            BtnProduccionEstadisticaLangostaView.ImageScaling = ToolStripItemImageScaling.None;
            BtnProduccionEstadisticaLangostaView.Name = "BtnProduccionEstadisticaLangostaView";
            BtnProduccionEstadisticaLangostaView.Size = new Size(230, 38);
            BtnProduccionEstadisticaLangostaView.Text = "Estadísticas de producción";
            BtnProduccionEstadisticaLangostaView.Click += BtnProduccionEstadisticaLangostaView_Click;
            // 
            // BtnOtrasPesquerias
            // 
            BtnOtrasPesquerias.DropDownItems.AddRange(new ToolStripItem[] { BtnProduccionCortePesqueriaView });
            BtnOtrasPesquerias.Image = Properties.Resources.menu_seafood;
            BtnOtrasPesquerias.ImageScaling = ToolStripItemImageScaling.None;
            BtnOtrasPesquerias.Name = "BtnOtrasPesquerias";
            BtnOtrasPesquerias.Size = new Size(177, 38);
            BtnOtrasPesquerias.Text = "Otras pesquerías";
            // 
            // BtnProduccionCortePesqueriaView
            // 
            BtnProduccionCortePesqueriaView.Image = Properties.Resources.menu_events2;
            BtnProduccionCortePesqueriaView.ImageScaling = ToolStripItemImageScaling.None;
            BtnProduccionCortePesqueriaView.Name = "BtnProduccionCortePesqueriaView";
            BtnProduccionCortePesqueriaView.Size = new Size(197, 38);
            BtnProduccionCortePesqueriaView.Text = "Corte por trabajador";
            BtnProduccionCortePesqueriaView.Click += BtnProduccionCortePesqueriaView_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(114, 6);
            // 
            // panelMain
            // 
            panelMain.Controls.Add(tabControl);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(121, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1074, 686);
            panelMain.TabIndex = 1;
            // 
            // tabControl
            // 
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1074, 686);
            tabControl.TabIndex = 0;
            // 
            // TimerExpanse
            // 
            TimerExpanse.Interval = 15;
            TimerExpanse.Tick += TimerExpanse_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 686);
            Controls.Add(panelMain);
            Controls.Add(panelMenu);
            Name = "MainForm";
            Text = "Sistema de trabajadores...";
            Load += MainForm_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            TstMenu.ResumeLayout(false);
            TstMenu.PerformLayout();
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelMain;
        private ToolStrip TstMenu;
        private ToolStripDropDownButton BtnInicio;
        private ToolStripMenuItem BtnInicioPolizasView;
        private ToolStripMenuItem BtnInicioEventosView;
        private ToolStripSeparator TstSeparador1;
        private ToolStripMenuItem BtnInicioConfiguracionView;
        private ToolStripDropDownButton BtnTrabajadores;
        private ToolStripMenuItem BtnTrabajadoresEstadoCuentaView;
        private ToolStripMenuItem BtnTrabajadoresMovimientosView;
        private ToolStripMenuItem BtnTrabajadoresMantenimientoView;
        private ToolStripMenuItem BtnTrabajadoresPermisosView;
        private ToolStripButton BtnSalir;
        private ToolStripButton BtnAyuda;
        private ToolStripSeparator TstSeparador;
        private ToolStripDropDownButton BtnReportes;
        private ToolStripDropDownButton BtnNube;
        private ToolStripDropDownButton BtnImportar;
        private ToolStripDropDownButton BtnProduccion;
        private ToolStripMenuItem BtnRptAhorrosView;
        private ToolStripMenuItem BtnRptSaldosRubrosView;
        private ToolStripMenuItem BtnRptAuxiliaresView;
        private ToolStripMenuItem BtnNubeValidarDatosView;
        private ToolStripMenuItem BtnNubeActualizarDatosView;
        private ToolStripMenuItem BtnContpaqi;
        private ToolStripMenuItem BtnImportarContabilidadView;
        private ToolStripMenuItem BtnImportarNominasView;
        private ToolStripMenuItem BtnImportarAlmacenView;
        private ToolStripMenuItem BtnLangosta;
        private ToolStripMenuItem BtnProduccionEstadisticaLangostaView;
        private ToolStripMenuItem BtnOtrasPesquerias;
        private ToolStripMenuItem BtnProduccionCortePesqueriaView;
        private TabControl tabControl;
        private ToolStripButton BtnToggleMenu;
        private System.Windows.Forms.Timer TimerExpanse;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator4;
    }
}
