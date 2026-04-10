using Nominas.Configuration;

namespace Nominas.Views.Inicio;

public partial class InicioPolizasView : UserControl
{
    public InicioPolizasView()
    {
        InitializeComponent();
    }

    private void InicioPolizasView_Load(object sender, EventArgs e)
    {
        //Acceder a la configuración para mostrar el servidor
        var config = ConfiguracionManager.Instancia;

        //string servidor = archivoConfiguracion.ErpLocal.Servidor;
        string servidor = config.ErpLocal.Servidor;

        // Mostrar el servidor en un Label o TextBox
        txtServidor.Text = servidor;

    }

    private void txtServidor_TextChanged(object sender, EventArgs e)
    {

    }
}
