namespace Nominas.Dialogs;

partial class AyudaAcercaDeDialog
{
    private System.ComponentModel.IContainer components = null;
    
    private Label lblTitle;
    private Label lblVersion;
    private Label lblDescription;
    private Button BtnCerrar;

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
        lblVersion = new Label();
        lblDescription = new Label();
        BtnCerrar = new Button();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitle.Location = new Point(20, 20);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(246, 32);
        lblTitle.TabIndex = 3;
        lblTitle.Text = "Sistema de Nóminas";
        // 
        // lblVersion
        // 
        lblVersion.AutoSize = true;
        lblVersion.Font = new Font("Segoe UI", 11F);
        lblVersion.ForeColor = Color.Gray;
        lblVersion.Location = new Point(20, 60);
        lblVersion.Name = "lblVersion";
        lblVersion.Size = new Size(91, 20);
        lblVersion.TabIndex = 2;
        lblVersion.Text = "Versión 1.0.0";
        // 
        // lblDescription
        // 
        lblDescription.Font = new Font("Segoe UI", 10F);
        lblDescription.Location = new Point(20, 100);
        lblDescription.Name = "lblDescription";
        lblDescription.Size = new Size(360, 120);
        lblDescription.TabIndex = 1;
        lblDescription.Text = "Sistema de gestión de nóminas y administración de personal.\n\nDesarrollado con .NET 10 y WinForms.\n\n© 2024 Todos los derechos reservados.";
        // 
        // BtnCerrar
        // 
        BtnCerrar.BackColor = Color.FromArgb(0, 120, 215);
        BtnCerrar.Cursor = Cursors.Hand;
        BtnCerrar.FlatAppearance.BorderSize = 0;
        BtnCerrar.FlatStyle = FlatStyle.Flat;
        BtnCerrar.Font = new Font("Segoe UI", 10F);
        BtnCerrar.ForeColor = Color.White;
        BtnCerrar.Location = new Point(290, 240);
        BtnCerrar.Name = "BtnCerrar";
        BtnCerrar.Size = new Size(100, 35);
        BtnCerrar.TabIndex = 0;
        BtnCerrar.Text = "Cerrar";
        BtnCerrar.UseVisualStyleBackColor = false;
        BtnCerrar.Click += BtnCerrar_Click;
        // 
        // AyudaAcercaDeDialog
        // 
        BackColor = Color.White;
        ClientSize = new Size(400, 300);
        Controls.Add(BtnCerrar);
        Controls.Add(lblDescription);
        Controls.Add(lblVersion);
        Controls.Add(lblTitle);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "AyudaAcercaDeDialog";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Acerca de";
        ResumeLayout(false);
        PerformLayout();
    }
}
