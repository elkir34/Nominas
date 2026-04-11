namespace Nominas.Views.Importar;

partial class ImportarNominasView
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
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        tableLayoutPanel1 = new TableLayoutPanel();
        dataGridView1 = new DataGridView();
        Cta = new DataGridViewTextBoxColumn();
        Empleado = new DataGridViewTextBoxColumn();
        ConceptoExcel = new DataGridViewTextBoxColumn();
        Rubro = new DataGridViewTextBoxColumn();
        ConceptoGenerado = new DataGridViewTextBoxColumn();
        Abono = new DataGridViewTextBoxColumn();
        panel2 = new Panel();
        lblArchivoExcel = new Label();
        TxtArchivoExcel = new TextBox();
        BtnArchivoExcel = new Button();
        lblFecha = new Label();
        DtpFecha = new DateTimePicker();
        lblPoliza = new Label();
        TxtPoliza = new TextBox();
        panel4 = new Panel();
        lblPeriodo = new Label();
        TxtPeriodo = new TextBox();
        lblTotal = new Label();
        TxtTotal = new TextBox();
        OpenSeleccionarArchivo = new OpenFileDialog();
        toolStrip1 = new ToolStrip();
        btnGuardar = new ToolStripButton();
        btnCancelar = new ToolStripButton();
        lblCargosDetectados = new ToolStripLabel();
        txtCargosDetectados = new ToolStripTextBox();
        Separador1 = new ToolStripSeparator();
        lblRenSeleccion = new ToolStripLabel();
        txtRenSeleccion = new ToolStripTextBox();
        lblRenSuma = new ToolStripLabel();
        txtRenSuma = new ToolStripTextBox();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        panel2.SuspendLayout();
        panel4.SuspendLayout();
        toolStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
        tableLayoutPanel1.Controls.Add(panel2, 0, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel1.Size = new Size(990, 583);
        tableLayoutPanel1.TabIndex = 2;
        // 
        // dataGridView1
        // 
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridViewCellStyle1.BackColor = Color.Silver;
        dataGridViewCellStyle1.ForeColor = Color.Black;
        dataGridViewCellStyle1.SelectionBackColor = Color.DodgerBlue;
        dataGridViewCellStyle1.SelectionForeColor = Color.White;
        dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Cta, Empleado, ConceptoExcel, Rubro, ConceptoGenerado, Abono });
        dataGridView1.Dock = DockStyle.Fill;
        dataGridView1.Location = new Point(3, 83);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridView1.RowHeadersWidth = 25;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.Size = new Size(984, 497);
        dataGridView1.TabIndex = 0;
        dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        // 
        // Cta
        // 
        Cta.DataPropertyName = "NoCuenta";
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
        Cta.DefaultCellStyle = dataGridViewCellStyle2;
        Cta.HeaderText = "Cta";
        Cta.Name = "Cta";
        Cta.ReadOnly = true;
        Cta.Width = 60;
        // 
        // Empleado
        // 
        Empleado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        Empleado.DataPropertyName = "NombreEmpleado";
        Empleado.HeaderText = "Empleado";
        Empleado.Name = "Empleado";
        Empleado.ReadOnly = true;
        // 
        // ConceptoExcel
        // 
        ConceptoExcel.DataPropertyName = "ConceptoOriginal";
        ConceptoExcel.HeaderText = "Concepto de Excel";
        ConceptoExcel.Name = "ConceptoExcel";
        ConceptoExcel.ReadOnly = true;
        ConceptoExcel.Width = 150;
        // 
        // Rubro
        // 
        Rubro.DataPropertyName = "RubroNombre";
        Rubro.HeaderText = "Rubro";
        Rubro.Name = "Rubro";
        Rubro.ReadOnly = true;
        Rubro.Width = 150;
        // 
        // ConceptoGenerado
        // 
        ConceptoGenerado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        ConceptoGenerado.DataPropertyName = "MiConcepto";
        ConceptoGenerado.HeaderText = "Concepto Generado";
        ConceptoGenerado.Name = "ConceptoGenerado";
        ConceptoGenerado.ReadOnly = true;
        // 
        // Abono
        // 
        Abono.DataPropertyName = "Abono";
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
        dataGridViewCellStyle3.Format = "N2";
        Abono.DefaultCellStyle = dataGridViewCellStyle3;
        Abono.HeaderText = "Abono";
        Abono.Name = "Abono";
        Abono.ReadOnly = true;
        // 
        // panel2
        // 
        panel2.Controls.Add(lblArchivoExcel);
        panel2.Controls.Add(TxtArchivoExcel);
        panel2.Controls.Add(BtnArchivoExcel);
        panel2.Controls.Add(lblFecha);
        panel2.Controls.Add(DtpFecha);
        panel2.Controls.Add(lblPoliza);
        panel2.Controls.Add(TxtPoliza);
        panel2.Controls.Add(panel4);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(3, 3);
        panel2.Name = "panel2";
        panel2.Size = new Size(984, 74);
        panel2.TabIndex = 2;
        // 
        // lblArchivoExcel
        // 
        lblArchivoExcel.AutoSize = true;
        lblArchivoExcel.Location = new Point(15, 16);
        lblArchivoExcel.Name = "lblArchivoExcel";
        lblArchivoExcel.Size = new Size(95, 15);
        lblArchivoExcel.TabIndex = 0;
        lblArchivoExcel.Text = "Ruta del archivo:";
        // 
        // TxtArchivoExcel
        // 
        TxtArchivoExcel.Location = new Point(116, 13);
        TxtArchivoExcel.Name = "TxtArchivoExcel";
        TxtArchivoExcel.Size = new Size(462, 23);
        TxtArchivoExcel.TabIndex = 3;
        // 
        // BtnArchivoExcel
        // 
        BtnArchivoExcel.Image = Properties.Resources.menu_search;
        BtnArchivoExcel.ImageAlign = ContentAlignment.MiddleLeft;
        BtnArchivoExcel.Location = new Point(584, 3);
        BtnArchivoExcel.Name = "BtnArchivoExcel";
        BtnArchivoExcel.Size = new Size(43, 41);
        BtnArchivoExcel.TabIndex = 4;
        BtnArchivoExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
        BtnArchivoExcel.UseVisualStyleBackColor = true;
        BtnArchivoExcel.Click += BtnSeleccionarArchivo_Click;
        // 
        // lblFecha
        // 
        lblFecha.AutoSize = true;
        lblFecha.Location = new Point(19, 46);
        lblFecha.Name = "lblFecha";
        lblFecha.Size = new Size(91, 15);
        lblFecha.TabIndex = 1;
        lblFecha.Text = "Fecha de póliza:";
        // 
        // DtpFecha
        // 
        DtpFecha.Location = new Point(116, 40);
        DtpFecha.Name = "DtpFecha";
        DtpFecha.Size = new Size(231, 23);
        DtpFecha.TabIndex = 2;
        // 
        // lblPoliza
        // 
        lblPoliza.AutoSize = true;
        lblPoliza.Location = new Point(362, 46);
        lblPoliza.Name = "lblPoliza";
        lblPoliza.Size = new Size(104, 15);
        lblPoliza.TabIndex = 5;
        lblPoliza.Text = "Número de póliza:";
        // 
        // TxtPoliza
        // 
        TxtPoliza.Location = new Point(468, 40);
        TxtPoliza.Name = "TxtPoliza";
        TxtPoliza.Size = new Size(110, 23);
        TxtPoliza.TabIndex = 6;
        // 
        // panel4
        // 
        panel4.Controls.Add(lblPeriodo);
        panel4.Controls.Add(TxtPeriodo);
        panel4.Controls.Add(lblTotal);
        panel4.Controls.Add(TxtTotal);
        panel4.Dock = DockStyle.Right;
        panel4.Location = new Point(704, 0);
        panel4.Name = "panel4";
        panel4.Size = new Size(280, 74);
        panel4.TabIndex = 9;
        // 
        // lblPeriodo
        // 
        lblPeriodo.AutoSize = true;
        lblPeriodo.Location = new Point(3, 35);
        lblPeriodo.Name = "lblPeriodo";
        lblPeriodo.Size = new Size(48, 15);
        lblPeriodo.TabIndex = 3;
        lblPeriodo.Text = "Periódo";
        // 
        // TxtPeriodo
        // 
        TxtPeriodo.Enabled = false;
        TxtPeriodo.Location = new Point(3, 48);
        TxtPeriodo.Name = "TxtPeriodo";
        TxtPeriodo.Size = new Size(168, 23);
        TxtPeriodo.TabIndex = 6;
        // 
        // lblTotal
        // 
        lblTotal.AutoSize = true;
        lblTotal.Location = new Point(177, 35);
        lblTotal.Name = "lblTotal";
        lblTotal.Size = new Size(33, 15);
        lblTotal.TabIndex = 4;
        lblTotal.Text = "Total";
        // 
        // TxtTotal
        // 
        TxtTotal.Enabled = false;
        TxtTotal.Location = new Point(177, 48);
        TxtTotal.Name = "TxtTotal";
        TxtTotal.Size = new Size(100, 23);
        TxtTotal.TabIndex = 7;
        TxtTotal.TextAlign = HorizontalAlignment.Right;
        // 
        // OpenSeleccionarArchivo
        // 
        OpenSeleccionarArchivo.FileName = "openFileDialog1";
        OpenSeleccionarArchivo.Filter = "Archivos Excel (*.xls;*.xlsx)|*.xls;*.xlsx|Todos los archivos (*.*)|*.*";
        OpenSeleccionarArchivo.Title = "Seleccionar archivo de nómina CONTPAQi";
        // 
        // toolStrip1
        // 
        toolStrip1.AutoSize = false;
        toolStrip1.Dock = DockStyle.Bottom;
        toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
        toolStrip1.Items.AddRange(new ToolStripItem[] { btnGuardar, btnCancelar, lblCargosDetectados, txtCargosDetectados, Separador1, lblRenSeleccion, txtRenSeleccion, lblRenSuma, txtRenSuma });
        toolStrip1.Location = new Point(0, 583);
        toolStrip1.Name = "toolStrip1";
        toolStrip1.Size = new Size(990, 52);
        toolStrip1.TabIndex = 3;
        toolStrip1.Text = "toolStrip1";
        // 
        // btnGuardar
        // 
        btnGuardar.Alignment = ToolStripItemAlignment.Right;
        btnGuardar.AutoSize = false;
        btnGuardar.Image = Properties.Resources.menu_save;
        btnGuardar.ImageScaling = ToolStripItemImageScaling.None;
        btnGuardar.ImageTransparentColor = Color.Magenta;
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(100, 49);
        btnGuardar.Text = "Guardar";
        btnGuardar.Click += BtnGuardar_Click;
        // 
        // btnCancelar
        // 
        btnCancelar.Alignment = ToolStripItemAlignment.Right;
        btnCancelar.AutoSize = false;
        btnCancelar.Image = Properties.Resources.menu_cancel;
        btnCancelar.ImageScaling = ToolStripItemImageScaling.None;
        btnCancelar.ImageTransparentColor = Color.Magenta;
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(100, 49);
        btnCancelar.Text = "Cancelar";
        btnCancelar.Click += BtnCancelar_Click;
        // 
        // lblCargosDetectados
        // 
        lblCargosDetectados.Name = "lblCargosDetectados";
        lblCargosDetectados.Size = new Size(57, 49);
        lblCargosDetectados.Text = "# Cargos:";
        // 
        // txtCargosDetectados
        // 
        txtCargosDetectados.Name = "txtCargosDetectados";
        txtCargosDetectados.Size = new Size(60, 52);
        txtCargosDetectados.TextBoxTextAlign = HorizontalAlignment.Center;
        // 
        // Separador1
        // 
        Separador1.Name = "Separador1";
        Separador1.Size = new Size(6, 52);
        // 
        // lblRenSeleccion
        // 
        lblRenSeleccion.Name = "lblRenSeleccion";
        lblRenSeleccion.Size = new Size(60, 49);
        lblRenSeleccion.Text = "Selección:";
        // 
        // txtRenSeleccion
        // 
        txtRenSeleccion.Name = "txtRenSeleccion";
        txtRenSeleccion.Size = new Size(60, 52);
        txtRenSeleccion.TextBoxTextAlign = HorizontalAlignment.Center;
        // 
        // lblRenSuma
        // 
        lblRenSuma.Name = "lblRenSuma";
        lblRenSuma.Size = new Size(12, 49);
        lblRenSuma.Text = "-";
        // 
        // txtRenSuma
        // 
        txtRenSuma.Name = "txtRenSuma";
        txtRenSuma.Size = new Size(100, 52);
        txtRenSuma.TextBoxTextAlign = HorizontalAlignment.Right;
        // 
        // ImportarNominasView
        // 
        BackColor = Color.White;
        Controls.Add(tableLayoutPanel1);
        Controls.Add(toolStrip1);
        Name = "ImportarNominasView";
        Size = new Size(990, 635);
        Load += ImportarNominasView_Load;
        tableLayoutPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        panel4.ResumeLayout(false);
        panel4.PerformLayout();
        toolStrip1.ResumeLayout(false);
        toolStrip1.PerformLayout();
        ResumeLayout(false);
    }

    private TableLayoutPanel tableLayoutPanel1;
    private DataGridView dataGridView1;
    private Panel panel1;
    private Panel panel2;
    private Button BtnArchivoExcel;
    private TextBox TxtArchivoExcel;
    private DateTimePicker DtpFecha;
    private Label lblFecha;
    private Label lblArchivoExcel;
    private TextBox TxtPoliza;
    private Label lblPoliza;
    private OpenFileDialog OpenSeleccionarArchivo;
    private TextBox TxtTotal;
    private TextBox TxtPeriodo;
    private Label lblTotal;
    private Label lblPeriodo;
    private Panel panel4;
    private DataGridViewTextBoxColumn Cta;
    private DataGridViewTextBoxColumn Empleado;
    private DataGridViewTextBoxColumn ConceptoExcel;
    private DataGridViewTextBoxColumn Rubro;
    private DataGridViewTextBoxColumn ConceptoGenerado;
    private DataGridViewTextBoxColumn Abono;
    private ToolStrip toolStrip1;
    private ToolStripButton btnCancelar;
    private ToolStripButton btnGuardar;
    private ToolStripLabel lblCargosDetectados;
    private ToolStripTextBox txtCargosDetectados;
    private ToolStripSeparator Separador1;
    private ToolStripLabel lblRenSeleccion;
    private ToolStripTextBox txtRenSeleccion;
    private ToolStripLabel lblRenSuma;
    private ToolStripTextBox txtRenSuma;
}
