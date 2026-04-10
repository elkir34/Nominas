namespace Nominas.Views.Trabajadores;

partial class TrabajadoresMantenimientoView
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        toolStrip = new ToolStrip();
        btnNuevo = new ToolStripButton();
        btnModificar = new ToolStripButton();
        toolStripSeparator1 = new ToolStripSeparator();
        btnGuardar = new ToolStripButton();
        btnEliminar = new ToolStripButton();
        toolStripSeparator2 = new ToolStripSeparator();
        toolStripButton1 = new ToolStripButton();
        toolStripButton2 = new ToolStripButton();
        dgvEmpleados = new DataGridView();
        groupBoxDetalles = new GroupBox();
        txtSaldo = new TextBox();
        txtAbonos = new TextBox();
        txtCargos = new TextBox();
        label17 = new Label();
        label16 = new Label();
        label15 = new Label();
        txtTelefono = new TextBox();
        label14 = new Label();
        txtEmail = new TextBox();
        label13 = new Label();
        txtDomicilio = new TextBox();
        label12 = new Label();
        txtIMSS = new TextBox();
        label11 = new Label();
        txtCURP = new TextBox();
        label10 = new Label();
        txtRFC = new TextBox();
        label9 = new Label();
        txtAlias = new TextBox();
        label8 = new Label();
        txtApMaterno = new TextBox();
        label7 = new Label();
        txtApPaterno = new TextBox();
        label6 = new Label();
        txtNombre = new TextBox();
        label5 = new Label();
        chkEstatus = new CheckBox();
        dtpFechaIngreso = new DateTimePicker();
        label4 = new Label();
        cbxPuesto = new ComboBox();
        label3 = new Label();
        cbxDepartamento = new ComboBox();
        label2 = new Label();
        cbxTipoEmpleado = new ComboBox();
        label1 = new Label();
        txtNoCuenta = new TextBox();
        lblNoCuenta = new Label();
        txtIdEmpleado = new TextBox();
        lblIdEmpleado = new Label();
        groupBoxFiltros = new GroupBox();
        cbxFiltrarPuesto = new ComboBox();
        lblFiltrarPuesto = new Label();
        cbxFiltrarDepartamento = new ComboBox();
        lblFiltrarDepartamento = new Label();
        cbxFiltrarTipoEmpleado = new ComboBox();
        lblFiltrarTipoEmpleado = new Label();
        radInactivos = new RadioButton();
        radActivos = new RadioButton();
        txtFiltrar = new TextBox();
        lblFiltrar = new Label();
        groupBox1 = new GroupBox();
        splitContainer1 = new SplitContainer();
        colIdEmpleado = new DataGridViewTextBoxColumn();
        colNoCuenta = new DataGridViewTextBoxColumn();
        colEmpleado = new DataGridViewTextBoxColumn();
        toolStrip.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
        groupBoxDetalles.SuspendLayout();
        groupBoxFiltros.SuspendLayout();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        SuspendLayout();
        // 
        // toolStrip
        // 
        toolStrip.Dock = DockStyle.Bottom;
        toolStrip.GripStyle = ToolStripGripStyle.Hidden;
        toolStrip.Items.AddRange(new ToolStripItem[] { btnNuevo, btnModificar, toolStripSeparator1, btnGuardar, btnEliminar, toolStripSeparator2, toolStripButton1, toolStripButton2 });
        toolStrip.Location = new Point(0, 600);
        toolStrip.Name = "toolStrip";
        toolStrip.Size = new Size(1143, 54);
        toolStrip.TabIndex = 0;
        // 
        // btnNuevo
        // 
        btnNuevo.AutoSize = false;
        btnNuevo.Image = Properties.Resources.menu_new;
        btnNuevo.ImageScaling = ToolStripItemImageScaling.None;
        btnNuevo.Name = "btnNuevo";
        btnNuevo.Size = new Size(70, 51);
        btnNuevo.Text = "Nuevo";
        btnNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
        btnNuevo.Click += BtnNuevo_Click;
        // 
        // btnModificar
        // 
        btnModificar.AutoSize = false;
        btnModificar.Image = Properties.Resources.menu_edit;
        btnModificar.ImageScaling = ToolStripItemImageScaling.None;
        btnModificar.Name = "btnModificar";
        btnModificar.Size = new Size(70, 51);
        btnModificar.Text = "Modificar";
        btnModificar.TextImageRelation = TextImageRelation.ImageAboveText;
        btnModificar.Click += BtnModificar_Click;
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.AutoSize = false;
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(6, 54);
        // 
        // btnGuardar
        // 
        btnGuardar.AutoSize = false;
        btnGuardar.Image = Properties.Resources.menu_save;
        btnGuardar.ImageScaling = ToolStripItemImageScaling.None;
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(70, 51);
        btnGuardar.Text = "Guardar";
        btnGuardar.TextImageRelation = TextImageRelation.ImageAboveText;
        btnGuardar.Click += BtnGuardar_Click;
        // 
        // btnEliminar
        // 
        btnEliminar.AutoSize = false;
        btnEliminar.Image = Properties.Resources.menu_delete;
        btnEliminar.ImageScaling = ToolStripItemImageScaling.None;
        btnEliminar.Name = "btnEliminar";
        btnEliminar.Size = new Size(70, 51);
        btnEliminar.Text = "Eliminar";
        btnEliminar.TextImageRelation = TextImageRelation.ImageAboveText;
        btnEliminar.Click += BtnEliminar_Click;
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new Size(6, 54);
        // 
        // toolStripButton1
        // 
        toolStripButton1.Image = Properties.Resources.menu_refresh;
        toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
        toolStripButton1.ImageTransparentColor = Color.Magenta;
        toolStripButton1.Name = "toolStripButton1";
        toolStripButton1.Size = new Size(63, 51);
        toolStripButton1.Text = "Actualizar";
        toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
        // 
        // toolStripButton2
        // 
        toolStripButton2.Alignment = ToolStripItemAlignment.Right;
        toolStripButton2.Image = Properties.Resources.menu_ok;
        toolStripButton2.ImageScaling = ToolStripItemImageScaling.None;
        toolStripButton2.ImageTransparentColor = Color.Magenta;
        toolStripButton2.Name = "toolStripButton2";
        toolStripButton2.Size = new Size(52, 51);
        toolStripButton2.Text = "Aceptar";
        toolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText;
        // 
        // dgvEmpleados
        // 
        dgvEmpleados.AllowUserToAddRows = false;
        dgvEmpleados.AllowUserToDeleteRows = false;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
        dgvEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { colIdEmpleado, colNoCuenta, colEmpleado });
        dgvEmpleados.Dock = DockStyle.Fill;
        dgvEmpleados.Location = new Point(10, 26);
        dgvEmpleados.MultiSelect = false;
        dgvEmpleados.Name = "dgvEmpleados";
        dgvEmpleados.ReadOnly = true;
        dgvEmpleados.RowHeadersWidth = 25;
        dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvEmpleados.Size = new Size(349, 554);
        dgvEmpleados.TabIndex = 0;
        // 
        // groupBoxDetalles
        // 
        groupBoxDetalles.Controls.Add(txtSaldo);
        groupBoxDetalles.Controls.Add(txtAbonos);
        groupBoxDetalles.Controls.Add(txtCargos);
        groupBoxDetalles.Controls.Add(label17);
        groupBoxDetalles.Controls.Add(label16);
        groupBoxDetalles.Controls.Add(label15);
        groupBoxDetalles.Controls.Add(txtTelefono);
        groupBoxDetalles.Controls.Add(label14);
        groupBoxDetalles.Controls.Add(txtEmail);
        groupBoxDetalles.Controls.Add(label13);
        groupBoxDetalles.Controls.Add(txtDomicilio);
        groupBoxDetalles.Controls.Add(label12);
        groupBoxDetalles.Controls.Add(txtIMSS);
        groupBoxDetalles.Controls.Add(label11);
        groupBoxDetalles.Controls.Add(txtCURP);
        groupBoxDetalles.Controls.Add(label10);
        groupBoxDetalles.Controls.Add(txtRFC);
        groupBoxDetalles.Controls.Add(label9);
        groupBoxDetalles.Controls.Add(txtAlias);
        groupBoxDetalles.Controls.Add(label8);
        groupBoxDetalles.Controls.Add(txtApMaterno);
        groupBoxDetalles.Controls.Add(label7);
        groupBoxDetalles.Controls.Add(txtApPaterno);
        groupBoxDetalles.Controls.Add(label6);
        groupBoxDetalles.Controls.Add(txtNombre);
        groupBoxDetalles.Controls.Add(label5);
        groupBoxDetalles.Controls.Add(chkEstatus);
        groupBoxDetalles.Controls.Add(dtpFechaIngreso);
        groupBoxDetalles.Controls.Add(label4);
        groupBoxDetalles.Controls.Add(cbxPuesto);
        groupBoxDetalles.Controls.Add(label3);
        groupBoxDetalles.Controls.Add(cbxDepartamento);
        groupBoxDetalles.Controls.Add(label2);
        groupBoxDetalles.Controls.Add(cbxTipoEmpleado);
        groupBoxDetalles.Controls.Add(label1);
        groupBoxDetalles.Controls.Add(txtNoCuenta);
        groupBoxDetalles.Controls.Add(lblNoCuenta);
        groupBoxDetalles.Controls.Add(txtIdEmpleado);
        groupBoxDetalles.Controls.Add(lblIdEmpleado);
        groupBoxDetalles.Dock = DockStyle.Fill;
        groupBoxDetalles.Location = new Point(5, 99);
        groupBoxDetalles.Name = "groupBoxDetalles";
        groupBoxDetalles.Padding = new Padding(10);
        groupBoxDetalles.Size = new Size(750, 496);
        groupBoxDetalles.TabIndex = 1;
        groupBoxDetalles.TabStop = false;
        groupBoxDetalles.Text = "Detalles del Trabajador";
        // 
        // txtSaldo
        // 
        txtSaldo.Enabled = false;
        txtSaldo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        txtSaldo.Location = new Point(393, 443);
        txtSaldo.Name = "txtSaldo";
        txtSaldo.Size = new Size(100, 23);
        txtSaldo.TabIndex = 42;
        txtSaldo.TextAlign = HorizontalAlignment.Right;
        // 
        // txtAbonos
        // 
        txtAbonos.Enabled = false;
        txtAbonos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        txtAbonos.Location = new Point(255, 443);
        txtAbonos.Name = "txtAbonos";
        txtAbonos.Size = new Size(100, 23);
        txtAbonos.TabIndex = 41;
        txtAbonos.TextAlign = HorizontalAlignment.Right;
        // 
        // txtCargos
        // 
        txtCargos.Enabled = false;
        txtCargos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        txtCargos.Location = new Point(115, 443);
        txtCargos.Name = "txtCargos";
        txtCargos.Size = new Size(100, 23);
        txtCargos.TabIndex = 40;
        txtCargos.TextAlign = HorizontalAlignment.Right;
        // 
        // label17
        // 
        label17.AutoSize = true;
        label17.Location = new Point(393, 425);
        label17.Name = "label17";
        label17.Size = new Size(39, 15);
        label17.TabIndex = 36;
        label17.Text = "Saldo:";
        // 
        // label16
        // 
        label16.AutoSize = true;
        label16.Location = new Point(255, 425);
        label16.Name = "label16";
        label16.Size = new Size(51, 15);
        label16.TabIndex = 35;
        label16.Text = "Abonos:";
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Location = new Point(115, 425);
        label15.Name = "label15";
        label15.Size = new Size(47, 15);
        label15.TabIndex = 34;
        label15.Text = "Cargos:";
        // 
        // txtTelefono
        // 
        txtTelefono.CharacterCasing = CharacterCasing.Upper;
        txtTelefono.Location = new Point(109, 311);
        txtTelefono.MaxLength = 20;
        txtTelefono.Name = "txtTelefono";
        txtTelefono.Size = new Size(180, 23);
        txtTelefono.TabIndex = 17;
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Location = new Point(47, 314);
        label14.Name = "label14";
        label14.Size = new Size(56, 15);
        label14.TabIndex = 32;
        label14.Text = "Teléfono:";
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(109, 282);
        txtEmail.MaxLength = 100;
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(250, 23);
        txtEmail.TabIndex = 16;
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Location = new Point(64, 285);
        label13.Name = "label13";
        label13.Size = new Size(39, 15);
        label13.TabIndex = 30;
        label13.Text = "Email:";
        // 
        // txtDomicilio
        // 
        txtDomicilio.CharacterCasing = CharacterCasing.Upper;
        txtDomicilio.Location = new Point(109, 253);
        txtDomicilio.MaxLength = 250;
        txtDomicilio.Name = "txtDomicilio";
        txtDomicilio.Size = new Size(450, 23);
        txtDomicilio.TabIndex = 15;
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(42, 256);
        label12.Name = "label12";
        label12.Size = new Size(61, 15);
        label12.TabIndex = 28;
        label12.Text = "Domicilio:";
        // 
        // txtIMSS
        // 
        txtIMSS.CharacterCasing = CharacterCasing.Upper;
        txtIMSS.Location = new Point(109, 224);
        txtIMSS.MaxLength = 15;
        txtIMSS.Name = "txtIMSS";
        txtIMSS.Size = new Size(180, 23);
        txtIMSS.TabIndex = 14;
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(67, 227);
        label11.Name = "label11";
        label11.Size = new Size(36, 15);
        label11.TabIndex = 26;
        label11.Text = "IMSS:";
        // 
        // txtCURP
        // 
        txtCURP.CharacterCasing = CharacterCasing.Upper;
        txtCURP.Location = new Point(343, 180);
        txtCURP.MaxLength = 18;
        txtCURP.Name = "txtCURP";
        txtCURP.Size = new Size(150, 23);
        txtCURP.TabIndex = 13;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(343, 162);
        label10.Name = "label10";
        label10.Size = new Size(40, 15);
        label10.TabIndex = 24;
        label10.Text = "CURP:";
        // 
        // txtRFC
        // 
        txtRFC.CharacterCasing = CharacterCasing.Upper;
        txtRFC.Location = new Point(499, 180);
        txtRFC.MaxLength = 13;
        txtRFC.Name = "txtRFC";
        txtRFC.Size = new Size(150, 23);
        txtRFC.TabIndex = 12;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(499, 162);
        label9.Name = "label9";
        label9.Size = new Size(31, 15);
        label9.TabIndex = 22;
        label9.Text = "RFC:";
        // 
        // txtAlias
        // 
        txtAlias.CharacterCasing = CharacterCasing.Upper;
        txtAlias.Location = new Point(109, 180);
        txtAlias.MaxLength = 50;
        txtAlias.Name = "txtAlias";
        txtAlias.Size = new Size(225, 23);
        txtAlias.TabIndex = 11;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(105, 162);
        label8.Name = "label8";
        label8.Size = new Size(35, 15);
        label8.TabIndex = 20;
        label8.Text = "Alias:";
        // 
        // txtApMaterno
        // 
        txtApMaterno.CharacterCasing = CharacterCasing.Upper;
        txtApMaterno.Location = new Point(499, 133);
        txtApMaterno.MaxLength = 50;
        txtApMaterno.Name = "txtApMaterno";
        txtApMaterno.Size = new Size(150, 23);
        txtApMaterno.TabIndex = 10;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(499, 115);
        label7.Name = "label7";
        label7.Size = new Size(55, 15);
        label7.TabIndex = 18;
        label7.Text = "Ap. Mat.:";
        // 
        // txtApPaterno
        // 
        txtApPaterno.CharacterCasing = CharacterCasing.Upper;
        txtApPaterno.Location = new Point(343, 133);
        txtApPaterno.MaxLength = 50;
        txtApPaterno.Name = "txtApPaterno";
        txtApPaterno.Size = new Size(150, 23);
        txtApPaterno.TabIndex = 9;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(343, 115);
        label6.Name = "label6";
        label6.Size = new Size(51, 15);
        label6.TabIndex = 16;
        label6.Text = "Ap. Pat.:";
        // 
        // txtNombre
        // 
        txtNombre.CharacterCasing = CharacterCasing.Upper;
        txtNombre.Location = new Point(109, 133);
        txtNombre.MaxLength = 50;
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(225, 23);
        txtNombre.TabIndex = 8;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(105, 116);
        label5.Name = "label5";
        label5.Size = new Size(54, 15);
        label5.TabIndex = 14;
        label5.Text = "Nombre:";
        // 
        // chkEstatus
        // 
        chkEstatus.AutoSize = true;
        chkEstatus.Checked = true;
        chkEstatus.CheckState = CheckState.Checked;
        chkEstatus.Location = new Point(579, 78);
        chkEstatus.Name = "chkEstatus";
        chkEstatus.Size = new Size(60, 19);
        chkEstatus.TabIndex = 7;
        chkEstatus.Text = "Activo";
        chkEstatus.UseVisualStyleBackColor = true;
        // 
        // dtpFechaIngreso
        // 
        dtpFechaIngreso.Location = new Point(380, 50);
        dtpFechaIngreso.Name = "dtpFechaIngreso";
        dtpFechaIngreso.Size = new Size(269, 23);
        dtpFechaIngreso.TabIndex = 6;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(313, 53);
        label4.Name = "label4";
        label4.Size = new Size(61, 15);
        label4.TabIndex = 11;
        label4.Text = "F. Ingreso:";
        // 
        // cbxPuesto
        // 
        cbxPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxPuesto.FormattingEnabled = true;
        cbxPuesto.Location = new Point(379, 79);
        cbxPuesto.Name = "cbxPuesto";
        cbxPuesto.Size = new Size(180, 23);
        cbxPuesto.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(327, 82);
        label3.Name = "label3";
        label3.Size = new Size(46, 15);
        label3.TabIndex = 9;
        label3.Text = "Puesto:";
        // 
        // cbxDepartamento
        // 
        cbxDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxDepartamento.FormattingEnabled = true;
        cbxDepartamento.Location = new Point(109, 79);
        cbxDepartamento.Name = "cbxDepartamento";
        cbxDepartamento.Size = new Size(176, 23);
        cbxDepartamento.TabIndex = 4;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(58, 82);
        label2.Name = "label2";
        label2.Size = new Size(45, 15);
        label2.TabIndex = 7;
        label2.Text = "Depto.:";
        // 
        // cbxTipoEmpleado
        // 
        cbxTipoEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxTipoEmpleado.FormattingEnabled = true;
        cbxTipoEmpleado.Items.AddRange(new object[] { "SOCIO", "EXTRA", "RETIRADOS", "OTROS" });
        cbxTipoEmpleado.Location = new Point(109, 50);
        cbxTipoEmpleado.Name = "cbxTipoEmpleado";
        cbxTipoEmpleado.Size = new Size(180, 23);
        cbxTipoEmpleado.TabIndex = 3;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(69, 53);
        label1.Name = "label1";
        label1.Size = new Size(34, 15);
        label1.TabIndex = 4;
        label1.Text = "Tipo:";
        // 
        // txtNoCuenta
        // 
        txtNoCuenta.Location = new Point(109, 21);
        txtNoCuenta.Name = "txtNoCuenta";
        txtNoCuenta.Size = new Size(120, 23);
        txtNoCuenta.TabIndex = 2;
        // 
        // lblNoCuenta
        // 
        lblNoCuenta.AutoSize = true;
        lblNoCuenta.Location = new Point(55, 24);
        lblNoCuenta.Name = "lblNoCuenta";
        lblNoCuenta.Size = new Size(48, 15);
        lblNoCuenta.TabIndex = 2;
        lblNoCuenta.Text = "Cuenta:";
        // 
        // txtIdEmpleado
        // 
        txtIdEmpleado.Location = new Point(589, 21);
        txtIdEmpleado.Name = "txtIdEmpleado";
        txtIdEmpleado.ReadOnly = true;
        txtIdEmpleado.Size = new Size(60, 23);
        txtIdEmpleado.TabIndex = 1;
        txtIdEmpleado.TabStop = false;
        // 
        // lblIdEmpleado
        // 
        lblIdEmpleado.AutoSize = true;
        lblIdEmpleado.Location = new Point(562, 24);
        lblIdEmpleado.Name = "lblIdEmpleado";
        lblIdEmpleado.Size = new Size(21, 15);
        lblIdEmpleado.TabIndex = 0;
        lblIdEmpleado.Text = "ID:";
        // 
        // groupBoxFiltros
        // 
        groupBoxFiltros.Controls.Add(cbxFiltrarPuesto);
        groupBoxFiltros.Controls.Add(lblFiltrarPuesto);
        groupBoxFiltros.Controls.Add(cbxFiltrarDepartamento);
        groupBoxFiltros.Controls.Add(lblFiltrarDepartamento);
        groupBoxFiltros.Controls.Add(cbxFiltrarTipoEmpleado);
        groupBoxFiltros.Controls.Add(lblFiltrarTipoEmpleado);
        groupBoxFiltros.Controls.Add(radInactivos);
        groupBoxFiltros.Controls.Add(radActivos);
        groupBoxFiltros.Controls.Add(txtFiltrar);
        groupBoxFiltros.Controls.Add(lblFiltrar);
        groupBoxFiltros.Dock = DockStyle.Top;
        groupBoxFiltros.Location = new Point(5, 5);
        groupBoxFiltros.Name = "groupBoxFiltros";
        groupBoxFiltros.Padding = new Padding(10);
        groupBoxFiltros.Size = new Size(750, 94);
        groupBoxFiltros.TabIndex = 0;
        groupBoxFiltros.TabStop = false;
        groupBoxFiltros.Text = "Filtros";
        // 
        // cbxFiltrarPuesto
        // 
        cbxFiltrarPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxFiltrarPuesto.FormattingEnabled = true;
        cbxFiltrarPuesto.Location = new Point(477, 62);
        cbxFiltrarPuesto.Name = "cbxFiltrarPuesto";
        cbxFiltrarPuesto.Size = new Size(180, 23);
        cbxFiltrarPuesto.TabIndex = 9;
        cbxFiltrarPuesto.SelectedIndexChanged += AplicarFiltro;
        // 
        // lblFiltrarPuesto
        // 
        lblFiltrarPuesto.AutoSize = true;
        lblFiltrarPuesto.Location = new Point(477, 44);
        lblFiltrarPuesto.Name = "lblFiltrarPuesto";
        lblFiltrarPuesto.Size = new Size(46, 15);
        lblFiltrarPuesto.TabIndex = 8;
        lblFiltrarPuesto.Text = "Puesto:";
        // 
        // cbxFiltrarDepartamento
        // 
        cbxFiltrarDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxFiltrarDepartamento.FormattingEnabled = true;
        cbxFiltrarDepartamento.Location = new Point(291, 62);
        cbxFiltrarDepartamento.Name = "cbxFiltrarDepartamento";
        cbxFiltrarDepartamento.Size = new Size(180, 23);
        cbxFiltrarDepartamento.TabIndex = 7;
        cbxFiltrarDepartamento.SelectedIndexChanged += AplicarFiltro;
        // 
        // lblFiltrarDepartamento
        // 
        lblFiltrarDepartamento.AutoSize = true;
        lblFiltrarDepartamento.Location = new Point(289, 44);
        lblFiltrarDepartamento.Name = "lblFiltrarDepartamento";
        lblFiltrarDepartamento.Size = new Size(45, 15);
        lblFiltrarDepartamento.TabIndex = 6;
        lblFiltrarDepartamento.Text = "Depto.:";
        // 
        // cbxFiltrarTipoEmpleado
        // 
        cbxFiltrarTipoEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
        cbxFiltrarTipoEmpleado.FormattingEnabled = true;
        cbxFiltrarTipoEmpleado.Items.AddRange(new object[] { "TODOS", "SOCIO", "EXTRA", "RETIRADOS", "OTROS" });
        cbxFiltrarTipoEmpleado.Location = new Point(105, 62);
        cbxFiltrarTipoEmpleado.Name = "cbxFiltrarTipoEmpleado";
        cbxFiltrarTipoEmpleado.Size = new Size(180, 23);
        cbxFiltrarTipoEmpleado.TabIndex = 5;
        cbxFiltrarTipoEmpleado.SelectedIndexChanged += AplicarFiltro;
        // 
        // lblFiltrarTipoEmpleado
        // 
        lblFiltrarTipoEmpleado.AutoSize = true;
        lblFiltrarTipoEmpleado.Location = new Point(105, 44);
        lblFiltrarTipoEmpleado.Name = "lblFiltrarTipoEmpleado";
        lblFiltrarTipoEmpleado.Size = new Size(34, 15);
        lblFiltrarTipoEmpleado.TabIndex = 4;
        lblFiltrarTipoEmpleado.Text = "Tipo:";
        // 
        // radInactivos
        // 
        radInactivos.AutoSize = true;
        radInactivos.Location = new Point(431, 21);
        radInactivos.Name = "radInactivos";
        radInactivos.Size = new Size(72, 19);
        radInactivos.TabIndex = 3;
        radInactivos.Text = "Inactivos";
        radInactivos.UseVisualStyleBackColor = true;
        radInactivos.CheckedChanged += AplicarFiltro;
        // 
        // radActivos
        // 
        radActivos.AutoSize = true;
        radActivos.Checked = true;
        radActivos.Location = new Point(361, 21);
        radActivos.Name = "radActivos";
        radActivos.Size = new Size(64, 19);
        radActivos.TabIndex = 2;
        radActivos.TabStop = true;
        radActivos.Text = "Activos";
        radActivos.UseVisualStyleBackColor = true;
        radActivos.CheckedChanged += AplicarFiltro;
        // 
        // txtFiltrar
        // 
        txtFiltrar.CharacterCasing = CharacterCasing.Upper;
        txtFiltrar.Location = new Point(105, 18);
        txtFiltrar.Name = "txtFiltrar";
        txtFiltrar.PlaceholderText = "Buscar por nombre, cuenta, RFC...";
        txtFiltrar.Size = new Size(250, 23);
        txtFiltrar.TabIndex = 1;
        txtFiltrar.TextChanged += AplicarFiltro;
        // 
        // lblFiltrar
        // 
        lblFiltrar.AutoSize = true;
        lblFiltrar.Location = new Point(54, 21);
        lblFiltrar.Name = "lblFiltrar";
        lblFiltrar.Size = new Size(45, 15);
        lblFiltrar.TabIndex = 0;
        lblFiltrar.Text = "Buscar:";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(dgvEmpleados);
        groupBox1.Dock = DockStyle.Fill;
        groupBox1.Location = new Point(5, 5);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(10);
        groupBox1.Size = new Size(369, 590);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Catálogo";
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = DockStyle.Fill;
        splitContainer1.Location = new Point(0, 0);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(groupBox1);
        splitContainer1.Panel1.Padding = new Padding(5);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(groupBoxDetalles);
        splitContainer1.Panel2.Controls.Add(groupBoxFiltros);
        splitContainer1.Panel2.Padding = new Padding(5);
        splitContainer1.Size = new Size(1143, 600);
        splitContainer1.SplitterDistance = 379;
        splitContainer1.TabIndex = 2;
        // 
        // colIdEmpleado
        // 
        colIdEmpleado.DataPropertyName = "idEmpleado";
        colIdEmpleado.HeaderText = "ID";
        colIdEmpleado.Name = "colIdEmpleado";
        colIdEmpleado.ReadOnly = true;
        colIdEmpleado.Visible = false;
        // 
        // colNoCuenta
        // 
        colNoCuenta.DataPropertyName = "noCuenta";
        colNoCuenta.FillWeight = 25.38071F;
        colNoCuenta.HeaderText = "Cuenta";
        colNoCuenta.Name = "colNoCuenta";
        colNoCuenta.ReadOnly = true;
        // 
        // colEmpleado
        // 
        colEmpleado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colEmpleado.DataPropertyName = "Empleado";
        colEmpleado.FillWeight = 74.61929F;
        colEmpleado.HeaderText = "Trabajador";
        colEmpleado.Name = "colEmpleado";
        colEmpleado.ReadOnly = true;
        // 
        // TrabajadoresMantenimientoView
        // 
        BackColor = Color.White;
        Controls.Add(splitContainer1);
        Controls.Add(toolStrip);
        Name = "TrabajadoresMantenimientoView";
        Size = new Size(1143, 654);
        Load += TrabajadoresMantenimientoView_Load;
        toolStrip.ResumeLayout(false);
        toolStrip.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
        groupBoxDetalles.ResumeLayout(false);
        groupBoxDetalles.PerformLayout();
        groupBoxFiltros.ResumeLayout(false);
        groupBoxFiltros.PerformLayout();
        groupBox1.ResumeLayout(false);
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private ToolStrip toolStrip;
    private ToolStripButton btnNuevo;
    private ToolStripButton btnModificar;
    private ToolStripButton btnGuardar;
    private ToolStripButton btnEliminar;
    private DataGridView dgvEmpleados;
    private GroupBox groupBoxFiltros;
    private TextBox txtFiltrar;
    private Label lblFiltrar;
    private RadioButton radActivos;
    private RadioButton radInactivos;
    private ComboBox cbxFiltrarTipoEmpleado;
    private Label lblFiltrarTipoEmpleado;
    private ComboBox cbxFiltrarDepartamento;
    private Label lblFiltrarDepartamento;
    private ComboBox cbxFiltrarPuesto;
    private Label lblFiltrarPuesto;
    private GroupBox groupBoxDetalles;
    private TextBox txtIdEmpleado;
    private Label lblIdEmpleado;
    private TextBox txtNoCuenta;
    private Label lblNoCuenta;
    private ComboBox cbxTipoEmpleado;
    private Label label1;
    private ComboBox cbxDepartamento;
    private Label label2;
    private ComboBox cbxPuesto;
    private Label label3;
    private DateTimePicker dtpFechaIngreso;
    private Label label4;
    private CheckBox chkEstatus;
    private TextBox txtNombre;
    private Label label5;
    private TextBox txtApPaterno;
    private Label label6;
    private TextBox txtApMaterno;
    private Label label7;
    private TextBox txtAlias;
    private Label label8;
    private TextBox txtRFC;
    private Label label9;
    private TextBox txtCURP;
    private Label label10;
    private TextBox txtIMSS;
    private Label label11;
    private TextBox txtDomicilio;
    private Label label12;
    private TextBox txtEmail;
    private Label label13;
    private TextBox txtTelefono;
    private Label label14;
    private Label label15;
    private Label label16;
    private Label label17;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripButton toolStripButton1;
    private ToolStripButton toolStripButton2;
    private GroupBox groupBox1;
    private SplitContainer splitContainer1;
    private TextBox txtCargos;
    private TextBox txtSaldo;
    private TextBox txtAbonos;
    private DataGridViewTextBoxColumn colIdEmpleado;
    private DataGridViewTextBoxColumn colNoCuenta;
    private DataGridViewTextBoxColumn colEmpleado;
}
