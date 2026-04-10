namespace Nominas.Views.Inicio;

partial class InicioPolizasView
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
        lblTitle = new Label();
        txtServidor = new TextBox();
        label1 = new Label();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.Dock = DockStyle.Top;
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.Location = new Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Padding = new Padding(20, 0, 0, 0);
        lblTitle.Size = new Size(660, 50);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Pólizas";
        lblTitle.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtServidor
        // 
        txtServidor.Location = new Point(216, 135);
        txtServidor.Name = "txtServidor";
        txtServidor.Size = new Size(190, 23);
        txtServidor.TabIndex = 2;
        txtServidor.TextChanged += txtServidor_TextChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(157, 138);
        label1.Name = "label1";
        label1.Size = new Size(53, 15);
        label1.TabIndex = 3;
        label1.Text = "Servidor:";
        // 
        // InicioPolizasView
        // 
        BackColor = Color.White;
        Controls.Add(label1);
        Controls.Add(txtServidor);
        Controls.Add(lblTitle);
        Name = "InicioPolizasView";
        Size = new Size(660, 514);
        Load += InicioPolizasView_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private TextBox txtServidor;
    private Label label1;
}
