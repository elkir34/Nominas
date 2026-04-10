namespace Nominas.Views.Reportes;

partial class RptAhorrosView
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
        lblTitle.Dock = DockStyle.Top;
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.Location = new Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Padding = new Padding(20, 0, 0, 0);
        lblTitle.Size = new Size(454, 50);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Reporte de Ahorros";
        lblTitle.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblPlaceholder
        // 
        lblPlaceholder.Dock = DockStyle.Fill;
        lblPlaceholder.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
        lblPlaceholder.ForeColor = Color.Gray;
        lblPlaceholder.Location = new Point(0, 50);
        lblPlaceholder.Name = "lblPlaceholder";
        lblPlaceholder.Size = new Size(454, 307);
        lblPlaceholder.TabIndex = 0;
        lblPlaceholder.Text = "Aquí irá el contenido del Reporte de Ahorros\n(Traer formulario desde VB.NET)";
        lblPlaceholder.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // RptAhorrosView
        // 
        BackColor = Color.White;
        Controls.Add(lblPlaceholder);
        Controls.Add(lblTitle);
        Name = "RptAhorrosView";
        Size = new Size(454, 357);
        ResumeLayout(false);
    }
}
