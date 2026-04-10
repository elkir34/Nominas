namespace Nominas.Views.Trabajadores;

partial class TrabajadoresPermisosView
{
    private System.ComponentModel.IContainer components = null;
    
    private Label lblTitle;
    private Label lblPlaceholder;

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
        lblPlaceholder = new Label();
        SuspendLayout();
        
        // 
        // lblTitle
        // 
        lblTitle.Text = "Permisos";
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.Dock = DockStyle.Top;
        lblTitle.Height = 50;
        lblTitle.TextAlign = ContentAlignment.MiddleLeft;
        lblTitle.Padding = new Padding(20, 0, 0, 0);
        
        // 
        // lblPlaceholder
        // 
        lblPlaceholder.Text = "Aquí irá el contenido de Permisos\n(Traer formulario desde VB.NET)";
        lblPlaceholder.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
        lblPlaceholder.ForeColor = Color.Gray;
        lblPlaceholder.Dock = DockStyle.Fill;
        lblPlaceholder.TextAlign = ContentAlignment.MiddleCenter;
        
        // 
        // TrabajadoresPermisosView
        // 
        Controls.Add(lblPlaceholder);
        Controls.Add(lblTitle);
        BackColor = Color.White;
        
        ResumeLayout(false);
    }
}
