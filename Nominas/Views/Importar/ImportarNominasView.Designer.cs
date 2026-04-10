namespace Nominas.Views.Importar;

partial class ImportarNominasView
{
    private System.ComponentModel.IContainer components = null;
    
    private Label lblTitle;

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
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        lblTitle = new Label();
        tableLayoutPanel1 = new TableLayoutPanel();
        dataGridView1 = new DataGridView();
        panel1 = new Panel();
        panel2 = new Panel();
        BtnGuardar = new Button();
        BtnCancelar = new Button();
        label1 = new Label();
        label2 = new Label();
        DtpFecha = new DateTimePicker();
        TxtArchivoExcel = new TextBox();
        BtnSeleccionarArchivo = new Button();
        label3 = new Label();
        TxtPoliza = new TextBox();
        Cta = new DataGridViewTextBoxColumn();
        Empleado = new DataGridViewTextBoxColumn();
        ConceptoExcel = new DataGridViewTextBoxColumn();
        Rubro = new DataGridViewTextBoxColumn();
        ConceptoGenerado = new DataGridViewTextBoxColumn();
        Abono = new DataGridViewTextBoxColumn();
        OpenSeleccionarArchivo = new OpenFileDialog();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        TxtCargosDetectados = new TextBox();
        TxtPeriodo = new TextBox();
        TxtTotal = new TextBox();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.Dock = DockStyle.Top;
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.Location = new Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Padding = new Padding(20, 0, 0, 0);
        lblTitle.Size = new Size(897, 50);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Importar desde CONTPAQi Nóminas";
        lblTitle.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
        tableLayoutPanel1.Controls.Add(panel1, 0, 2);
        tableLayoutPanel1.Controls.Add(panel2, 0, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 50);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.3647795F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.63522F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
        tableLayoutPanel1.Size = new Size(897, 636);
        tableLayoutPanel1.TabIndex = 2;
        // 
        // dataGridView1
        // 
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridViewCellStyle3.BackColor = Color.Silver;
        dataGridViewCellStyle3.ForeColor = Color.Black;
        dataGridViewCellStyle3.SelectionBackColor = Color.DodgerBlue;
        dataGridViewCellStyle3.SelectionForeColor = Color.White;
        dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Cta, Empleado, ConceptoExcel, Rubro, ConceptoGenerado, Abono });
        dataGridView1.Dock = DockStyle.Fill;
        dataGridView1.Location = new Point(3, 79);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridView1.RowHeadersWidth = 25;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.Size = new Size(891, 489);
        dataGridView1.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.Controls.Add(TxtTotal);
        panel1.Controls.Add(TxtPeriodo);
        panel1.Controls.Add(TxtCargosDetectados);
        panel1.Controls.Add(label6);
        panel1.Controls.Add(label5);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(BtnCancelar);
        panel1.Controls.Add(BtnGuardar);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(3, 574);
        panel1.Name = "panel1";
        panel1.Size = new Size(891, 59);
        panel1.TabIndex = 1;
        // 
        // panel2
        // 
        panel2.Controls.Add(TxtPoliza);
        panel2.Controls.Add(label3);
        panel2.Controls.Add(BtnSeleccionarArchivo);
        panel2.Controls.Add(TxtArchivoExcel);
        panel2.Controls.Add(DtpFecha);
        panel2.Controls.Add(label2);
        panel2.Controls.Add(label1);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(3, 3);
        panel2.Name = "panel2";
        panel2.Size = new Size(891, 70);
        panel2.TabIndex = 2;
        // 
        // BtnGuardar
        // 
        BtnGuardar.Enabled = false;
        BtnGuardar.Image = Properties.Resources.menu_save;
        BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
        BtnGuardar.Location = new Point(751, 8);
        BtnGuardar.Name = "BtnGuardar";
        BtnGuardar.Size = new Size(130, 42);
        BtnGuardar.TabIndex = 0;
        BtnGuardar.Text = "Guardar en BD";
        BtnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
        BtnGuardar.UseVisualStyleBackColor = true;
        // 
        // BtnCancelar
        // 
        BtnCancelar.Image = Properties.Resources.menu_cancel;
        BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
        BtnCancelar.Location = new Point(615, 8);
        BtnCancelar.Name = "BtnCancelar";
        BtnCancelar.Size = new Size(130, 42);
        BtnCancelar.TabIndex = 1;
        BtnCancelar.Text = "Cancelar";
        BtnCancelar.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(15, 16);
        label1.Name = "label1";
        label1.Size = new Size(95, 15);
        label1.TabIndex = 0;
        label1.Text = "Ruta del archivo:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(19, 46);
        label2.Name = "label2";
        label2.Size = new Size(91, 15);
        label2.TabIndex = 1;
        label2.Text = "Fecha de póliza:";
        // 
        // DtpFecha
        // 
        DtpFecha.Location = new Point(116, 40);
        DtpFecha.Name = "DtpFecha";
        DtpFecha.Size = new Size(231, 23);
        DtpFecha.TabIndex = 2;
        // 
        // TxtArchivoExcel
        // 
        TxtArchivoExcel.Location = new Point(116, 13);
        TxtArchivoExcel.Name = "TxtArchivoExcel";
        TxtArchivoExcel.Size = new Size(462, 23);
        TxtArchivoExcel.TabIndex = 3;
        // 
        // BtnSeleccionarArchivo
        // 
        BtnSeleccionarArchivo.Image = Properties.Resources.menu_search;
        BtnSeleccionarArchivo.ImageAlign = ContentAlignment.MiddleLeft;
        BtnSeleccionarArchivo.Location = new Point(584, 3);
        BtnSeleccionarArchivo.Name = "BtnSeleccionarArchivo";
        BtnSeleccionarArchivo.Size = new Size(43, 41);
        BtnSeleccionarArchivo.TabIndex = 4;
        BtnSeleccionarArchivo.TextImageRelation = TextImageRelation.ImageBeforeText;
        BtnSeleccionarArchivo.UseVisualStyleBackColor = true;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(362, 46);
        label3.Name = "label3";
        label3.Size = new Size(104, 15);
        label3.TabIndex = 5;
        label3.Text = "Número de póliza:";
        // 
        // TxtPoliza
        // 
        TxtPoliza.Location = new Point(468, 40);
        TxtPoliza.Name = "TxtPoliza";
        TxtPoliza.Size = new Size(110, 23);
        TxtPoliza.TabIndex = 6;
        // 
        // Cta
        // 
        Cta.DataPropertyName = "Cta";
        Cta.HeaderText = "Cta";
        Cta.Name = "Cta";
        Cta.ReadOnly = true;
        Cta.Width = 60;
        // 
        // Empleado
        // 
        Empleado.DataPropertyName = "Empleado";
        Empleado.HeaderText = "Empleado";
        Empleado.Name = "Empleado";
        Empleado.ReadOnly = true;
        Empleado.Width = 200;
        // 
        // ConceptoExcel
        // 
        ConceptoExcel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        ConceptoExcel.DataPropertyName = "ConceptoExcel";
        ConceptoExcel.HeaderText = "Concepto de Excel";
        ConceptoExcel.Name = "ConceptoExcel";
        ConceptoExcel.ReadOnly = true;
        // 
        // Rubro
        // 
        Rubro.DataPropertyName = "Rubro";
        Rubro.HeaderText = "Rubro";
        Rubro.Name = "Rubro";
        Rubro.ReadOnly = true;
        Rubro.Width = 150;
        // 
        // ConceptoGenerado
        // 
        ConceptoGenerado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        ConceptoGenerado.DataPropertyName = "ConceptoGenerado";
        ConceptoGenerado.HeaderText = "Concepto Generado";
        ConceptoGenerado.Name = "ConceptoGenerado";
        ConceptoGenerado.ReadOnly = true;
        // 
        // Abono
        // 
        Abono.DataPropertyName = "Abono";
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
        dataGridViewCellStyle4.Format = "N2";
        Abono.DefaultCellStyle = dataGridViewCellStyle4;
        Abono.HeaderText = "Abono";
        Abono.Name = "Abono";
        Abono.ReadOnly = true;
        // 
        // OpenSeleccionarArchivo
        // 
        OpenSeleccionarArchivo.FileName = "openFileDialog1";
        OpenSeleccionarArchivo.Filter = "Archivos Excel (*.xls;*.xlsx)|*.xls;*.xlsx|Todos los archivos (*.*)|*.*";
        OpenSeleccionarArchivo.Title = "Seleccionar archivo de nómina CONTPAQi";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(19, 9);
        label4.Name = "label4";
        label4.Size = new Size(44, 15);
        label4.TabIndex = 2;
        label4.Text = "Cargos";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(125, 9);
        label5.Name = "label5";
        label5.Size = new Size(48, 15);
        label5.TabIndex = 3;
        label5.Text = "Periódo";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(231, 9);
        label6.Name = "label6";
        label6.Size = new Size(33, 15);
        label6.TabIndex = 4;
        label6.Text = "Total";
        // 
        // TxtCargosDetectados
        // 
        TxtCargosDetectados.Enabled = false;
        TxtCargosDetectados.Location = new Point(19, 30);
        TxtCargosDetectados.Name = "TxtCargosDetectados";
        TxtCargosDetectados.Size = new Size(100, 23);
        TxtCargosDetectados.TabIndex = 5;
        // 
        // TxtPeriodo
        // 
        TxtPeriodo.Enabled = false;
        TxtPeriodo.Location = new Point(125, 30);
        TxtPeriodo.Name = "TxtPeriodo";
        TxtPeriodo.Size = new Size(100, 23);
        TxtPeriodo.TabIndex = 6;
        // 
        // TxtTotal
        // 
        TxtTotal.Enabled = false;
        TxtTotal.Location = new Point(231, 30);
        TxtTotal.Name = "TxtTotal";
        TxtTotal.Size = new Size(100, 23);
        TxtTotal.TabIndex = 7;
        // 
        // ImportarNominasView
        // 
        BackColor = Color.White;
        Controls.Add(tableLayoutPanel1);
        Controls.Add(lblTitle);
        Name = "ImportarNominasView";
        Size = new Size(897, 686);
        Load += ImportarNominasView_Load;
        tableLayoutPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
    }

    private TableLayoutPanel tableLayoutPanel1;
    private DataGridView dataGridView1;
    private Panel panel1;
    private Button BtnCancelar;
    private Button BtnGuardar;
    private Panel panel2;
    private Button BtnSeleccionarArchivo;
    private TextBox TxtArchivoExcel;
    private DateTimePicker DtpFecha;
    private Label label2;
    private Label label1;
    private TextBox TxtPoliza;
    private Label label3;
    private DataGridViewTextBoxColumn Cta;
    private DataGridViewTextBoxColumn Empleado;
    private DataGridViewTextBoxColumn ConceptoExcel;
    private DataGridViewTextBoxColumn Rubro;
    private DataGridViewTextBoxColumn ConceptoGenerado;
    private DataGridViewTextBoxColumn Abono;
    private OpenFileDialog OpenSeleccionarArchivo;
    private TextBox TxtTotal;
    private TextBox TxtPeriodo;
    private TextBox TxtCargosDetectados;
    private Label label6;
    private Label label5;
    private Label label4;
}
