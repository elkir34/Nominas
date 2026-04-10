using Nominas.Dialogs;
using Nominas.Navigation;
using Nominas.Views.Importar;
using Nominas.Views.Inicio;
using Nominas.Views.Nube;
using Nominas.Views.Produccion;
using Nominas.Views.Reportes;
using Nominas.Views.Trabajadores;

namespace Nominas;

public partial class MainForm : Form
{
    private readonly Dictionary<string, TabPage> _openTabs = new();
    private const int MENU_EXPANDED_WIDTH = 121;
    private const int MENU_COLLAPSED_WIDTH = 43;
    private const int MENU_ANIMATION_STEP = 5;
    private bool isMenuExpanded = true;
    private int targetWidth;
    private bool expandiendo;

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        //Configurar el TabControl para que use pestañas personalizadas
        tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
        tabControl.Padding = new Point(20, 4); // Espacio para el botón de cerrar
        tabControl.DrawItem += TabControl_DrawItem;
        tabControl.MouseDown += TabControl_MouseDown;
    }

    //Dibujar las pestañas con un botón de cerrar (X)
    private void TabControl_DrawItem(object? sender, DrawItemEventArgs e)
    {
        TabPage tabPage = tabControl.TabPages[e.Index];

        //Dibujar la pestaña
        Rectangle tabRect = tabControl.GetTabRect(e.Index);
        if (e.Index == tabControl.SelectedIndex)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), tabRect);
        }
        else
        {
            e.Graphics.FillRectangle(new SolidBrush(SystemColors.Control), tabRect);
        }
        TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font, tabRect, SystemColors.ControlText);

        // Dibujar el botón de cerrar (X)
        Rectangle closeButtonRect = new Rectangle(tabRect.Right - 18, tabRect.Top + (tabRect.Height - 14) / 2, 14, 14);
        TextRenderer.DrawText(e.Graphics, "X", SystemFonts.DefaultFont, closeButtonRect, Color.Gray);
    }

    //Manejar el clic en el botón de cerrar
    private void TabControl_MouseDown(object? sender, MouseEventArgs e)
    {
        for (int i = 0; i < tabControl.TabPages.Count; i++)
        {
            Rectangle tabRect = tabControl.GetTabRect(i);

            //Definir el area del botón de cerrar (X)
            Rectangle closeButtonRect = new Rectangle(tabRect.Right - 18, tabRect.Top + (tabRect.Height - 14) / 2, 14, 14);

            //Si el clic fue dentro del área del botón de cerrar, cerrar la pestaña
            if (closeButtonRect.Contains(e.Location))
            {
                TabPage tabPageToRemove = tabControl.TabPages[i];
                tabControl.TabPages.Remove(tabPageToRemove);
                _openTabs.Remove(_openTabs.FirstOrDefault(x => x.Value == tabPageToRemove).Key);
                break;
            }
        }
    }

    private void BtnToggleMenu_Click(object sender, EventArgs e)
    {
        expandiendo = !isMenuExpanded;
        targetWidth = expandiendo ? MENU_EXPANDED_WIDTH : MENU_COLLAPSED_WIDTH;

        // Cambiar imagen inmediatamente
        BtnToggleMenu.Image = expandiendo ? Properties.Resources.menu_fold : Properties.Resources.menu_unfold;

        // ⬅️ Si está expandiendo, mostrar textos ANTES de la animación
        if (expandiendo)
            MostrarTextoBotones();

        TimerExpanse.Start();
    }

    private void OcultarTextoBotones()
    {
        foreach (ToolStripItem Elemento in TstMenu.Items)
        {
            if (Elemento is ToolStripButton Btn)
                Btn.Text = "";
            if (Elemento is ToolStripDropDownButton BtnDropDown)
                BtnDropDown.Text = "";
        }
    }

    private void MostrarTextoBotones()
    {
        foreach (ToolStripItem Elemento in TstMenu.Items)
        {
            if (Elemento is ToolStripButton Btn)
                Btn.Text = Btn.Tag?.ToString() ?? "";

            if (Elemento is ToolStripDropDownButton BtnDropDown)
                BtnDropDown.Text = BtnDropDown.Tag?.ToString() ?? "";
        }
    }

    private void TimerExpanse_Tick(object sender, EventArgs e)
    {
        if (expandiendo && panelMenu.Width < targetWidth)
        {
            panelMenu.Width += MENU_ANIMATION_STEP;
            if (panelMenu.Width >= targetWidth)
            {
                panelMenu.Width = targetWidth;
                isMenuExpanded = true;
                TimerExpanse.Stop();
            }
        }
        else if (!expandiendo && panelMenu.Width > targetWidth)
        {
            panelMenu.Width -= MENU_ANIMATION_STEP;
            if (panelMenu.Width <= targetWidth)
            {
                panelMenu.Width = targetWidth;
                OcultarTextoBotones(); // ⬅️ Ocultar al terminar (después de colapsar)
                isMenuExpanded = false;
                TimerExpanse.Stop();
            }
        }
    }

    public void OpenTab(string key, Func<UserControl> factory, string title)
    {
        if (_openTabs.TryGetValue(key, out var existingTab))
        {
            tabControl.SelectedTab = existingTab;
            return;
        }
        var tabPage = new TabPage(title)
        {
            BackColor = Color.White,
            Padding = new Padding(10)
        };

        var control = factory();
        control.Dock = DockStyle.Fill;
        tabPage.Controls.Add(control);

        _openTabs[key] = tabPage;
        tabControl.TabPages.Add(tabPage);
        tabControl.SelectedTab = tabPage;
    }

    private void BtnInicioPolizasView_Click(object sender, EventArgs e)
    {
       OpenTab(NavigationKeys.InicioPolizas, () => new InicioPolizasView(), "Pólizas");
    }

    private void BtnInicioConfiguracionView_Click(object sender, EventArgs e)
    {
        using ConfiguracionDialog MyConfiguracionDialog = new();
        MyConfiguracionDialog.ShowDialog();
    }

    private void BtnInicioEventosView_Click(object sender, EventArgs e)
    {
        OpenTab(NavigationKeys.InicioEventos, () => new InicioEventosView(), "Eventos");
    }

    private void BtnTrabajadoresEstadoCuentaView_Click(object? sender, EventArgs e)
    {
        OpenTab(NavigationKeys.TrabajadoresEstadoCuenta, () => new TrabajadoresEstadoCuentaView(), "Estado de Cuenta");
    }

    private void BtnTrabajadoresMovimientosView_Click(object? sender, EventArgs e)
    {
        OpenTab(NavigationKeys.TrabajadoresMovimientos, () => new TrabajadoresMovimientosView(), "Movimientos");
    }

    private void BtnTrabajadoresMantenimientoView_Click(object? sender, EventArgs e)
    {
        OpenTab(NavigationKeys.TrabajadoresMantenimiento, () => new TrabajadoresMantenimientoView(), "Mantenimiento");
    }

    private void BtnTrabajadoresPermisosView_Click(object? sender, EventArgs e)
    {
        OpenTab(NavigationKeys.TrabajadoresPermisos, () => new TrabajadoresPermisosView(), "Permisos");
    }

    private void BtnRptAhorrosView_Click(object? sender, EventArgs e)
    {
        OpenTab(NavigationKeys.RptAhorros, () => new RptAhorrosView(), "Ahorros");
    }

    private void BtnRptSaldosRubrosView_Click(object? sender, EventArgs e)
    {
        OpenTab(NavigationKeys.RptSaldosRubros, () => new RptSaldosRubrosView(), "Saldos Rubros");
    }

    private void BtnRptAuxiliaresView_Click(object? sender, EventArgs e)
    {
        OpenTab(NavigationKeys.RptAuxiliares, () => new RptAuxiliaresView(), "Auxiliares");
    }
    private void BtnNubeValidarDatosView_Click(object? sender, EventArgs e)
    {
        OpenTab(NavigationKeys.NubeValidarDatos, () => new NubeValidarDatosView(), "Validar");
    }

    private void BtnNubeActualizarDatosView_Click(object? sender, EventArgs e)
    {
        OpenTab(NavigationKeys.NubeActualizarDatos, () => new NubeActualizarDatosView(), "Actualizar");
    }

    private void BtnImportarContabilidadView_Click(object? sender, EventArgs e)
    {
        OpenTab(NavigationKeys.ImportarContabilidad, () => new ImportarContabilidadView(), "Importar Contabilidad");
    }

    private void BtnImportarNominasView_Click(object? sender, EventArgs e)
    {
        OpenTab(NavigationKeys.ImportarNominas, () => new ImportarNominasView(), "Importar Nóminas");
    }

    private void BtnImportarAlmacenView_Click(object? sender, EventArgs e)
    {
        OpenTab(NavigationKeys.ImportarAlmacenes, () => new ImportarAlmacenView(), "Importar Almacén");
    }

    private void BtnProduccionEstadisticaLangostaView_Click(object? sender, EventArgs e)
    {
        OpenTab(NavigationKeys.ProduccionEstadisticaLangosta, () => new ProduccionEstadisticaLangostaView(), "Estadística Langosta");
    }

    private void BtnProduccionCortePesqueriaView_Click(object? sender, EventArgs e)
    {
        OpenTab(NavigationKeys.ProduccionCortePesqueria, () => new ProduccionCortePesqueriaView(), "Corte Pesquería");
    }
}