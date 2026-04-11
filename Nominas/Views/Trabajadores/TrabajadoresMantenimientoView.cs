using Nominas.Models;
using Nominas.Services;
using System.Data;

namespace Nominas.Views.Trabajadores;

public partial class TrabajadoresMantenimientoView : UserControl
{
    private readonly TrabajadorService _servicios;
    private readonly BindingSource _empleadosBS;
    private DataTable _empleadosDT;
    private DataTable _departamentosDT;
    private DataTable _puestosDT;

    public TrabajadoresMantenimientoView()
    {
        InitializeComponent();
        _servicios = new TrabajadorService();
        _empleadosBS = new BindingSource();
    }

    private void TrabajadoresMantenimientoView_Load(object sender, EventArgs e)
    {
        try
        {
            CargarDatos();
            ConfigurarFiltros();
            BloquearControles(false);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CargarDatos()
    {
        _empleadosDT = _servicios.CargarEmpleados();
        _departamentosDT = _servicios.CargarDepartamentos();
        _puestosDT = _servicios.CargarPuestos();

        _empleadosBS.DataSource = _empleadosDT;
        dgvEmpleados.AutoGenerateColumns = false;
        dgvEmpleados.DataSource = _empleadosBS;

        CargarCombos();
        MyEnlazarDatos();
        AplicarFiltro(null, EventArgs.Empty);

    }

    private void MyEnlazarDatos()
    {
        txtIdEmpleado.DataBindings.Clear();
        txtNoCuenta.DataBindings.Clear();
        cbxTipoEmpleado.DataBindings.Clear();
        cbxDepartamento.DataBindings.Clear();
        cbxPuesto.DataBindings.Clear();
        dtpFechaIngreso.DataBindings.Clear();
        chkEstatus.DataBindings.Clear();
        txtNombre.DataBindings.Clear();
        txtApPaterno.DataBindings.Clear();
        txtApMaterno.DataBindings.Clear();
        txtAlias.DataBindings.Clear();
        txtRFC.DataBindings.Clear();
        txtCURP.DataBindings.Clear();
        txtIMSS.DataBindings.Clear();
        txtDomicilio.DataBindings.Clear();
        txtEmail.DataBindings.Clear();
        txtTelefono.DataBindings.Clear();
        txtCargos.DataBindings.Clear();
        txtAbonos.DataBindings.Clear();
        txtSaldo.DataBindings.Clear();

        txtIdEmpleado.DataBindings.Add("Text", _empleadosBS, "idEmpleado");
        txtNoCuenta.DataBindings.Add("Text", _empleadosBS, "noCuenta");
        cbxTipoEmpleado.DataBindings.Add("SelectedIndex", _empleadosBS, "TipoEmpleado");
        cbxDepartamento.DataBindings.Add("SelectedValue", _empleadosBS, "idDepartamento");
        cbxPuesto.DataBindings.Add("SelectedValue", _empleadosBS, "idPuesto");
        dtpFechaIngreso.DataBindings.Add("Value", _empleadosBS, "FechaIngreso");
        chkEstatus.DataBindings.Add("Checked", _empleadosBS, "Status");
        txtNombre.DataBindings.Add("Text", _empleadosBS, "Nombre");
        txtApPaterno.DataBindings.Add("Text", _empleadosBS, "ApPaterno");
        txtApMaterno.DataBindings.Add("Text", _empleadosBS, "ApMaterno");
        txtAlias.DataBindings.Add("Text", _empleadosBS, "Alias");
        txtRFC.DataBindings.Add("Text", _empleadosBS, "RFC");
        txtCURP.DataBindings.Add("Text", _empleadosBS, "CURP");
        txtIMSS.DataBindings.Add("Text", _empleadosBS, "IMSS");
        txtDomicilio.DataBindings.Add("Text", _empleadosBS, "Domicilio");
        txtEmail.DataBindings.Add("Text", _empleadosBS, "Email");
        txtTelefono.DataBindings.Add("Text", _empleadosBS, "Telefono");
        txtAbonos.DataBindings.Add("Text", _empleadosBS, "Abonos");
        txtCargos.DataBindings.Add("Text", _empleadosBS, "Cargos");
        txtSaldo.DataBindings.Add("Text", _empleadosBS, "Saldo");
    }   

    private void CargarCombos()
    {
        cbxDepartamento.DataSource = _departamentosDT; //.Copy();
        cbxDepartamento.DisplayMember = "Departamento";
        cbxDepartamento.ValueMember = "idDepartamento";

        cbxPuesto.DataSource = _puestosDT; //.Copy();
        cbxPuesto.DisplayMember = "Puesto";
        cbxPuesto.ValueMember = "idPuesto";

        DataTable deptosFiltro = _departamentosDT.Copy();
        DataRow rowTodosDeptos = deptosFiltro.NewRow();
        rowTodosDeptos["idDepartamento"] = 0;
        rowTodosDeptos["Departamento"] = "TODOS";
        deptosFiltro.Rows.InsertAt(rowTodosDeptos, 0);

        cbxFiltrarDepartamento.DataSource = deptosFiltro;
        cbxFiltrarDepartamento.DisplayMember = "Departamento";
        cbxFiltrarDepartamento.ValueMember = "idDepartamento";
        cbxFiltrarDepartamento.SelectedIndex = 0;

        DataTable puestosFiltro = _puestosDT.Copy();
        DataRow rowTodosPuestos = puestosFiltro.NewRow();
        rowTodosPuestos["idPuesto"] = 0;
        rowTodosPuestos["Puesto"] = "TODOS";
        puestosFiltro.Rows.InsertAt(rowTodosPuestos, 0);

        cbxFiltrarPuesto.DataSource = puestosFiltro;
        cbxFiltrarPuesto.DisplayMember = "Puesto";
        cbxFiltrarPuesto.ValueMember = "idPuesto";
        cbxFiltrarPuesto.SelectedIndex = 0;

        cbxTipoEmpleado.SelectedIndex = 0;
        cbxFiltrarTipoEmpleado.SelectedIndex = 0;
    }

    private void ConfigurarFiltros()
    {
        radActivos.Checked = true;
    }

    private void AplicarFiltro(object? sender, EventArgs e)
    {
        List<string> filtros = new();

        if (radActivos.Checked)
            filtros.Add("Status = 1");
        else if (radInactivos.Checked)
            filtros.Add("Status = 0");

        if (!string.IsNullOrWhiteSpace(txtFiltrar.Text))
        {
            string busqueda = txtFiltrar.Text.Replace("'", "''");
            filtros.Add($"(Empleado LIKE '%{busqueda}%' OR noCuenta LIKE '%{busqueda}%' OR RFC LIKE '%{busqueda}%' OR CURP LIKE '%{busqueda}%')");
        }
        if (cbxFiltrarTipoEmpleado.SelectedIndex > 0)
        {
            int tipoEmpleado = cbxFiltrarTipoEmpleado.SelectedIndex;
            filtros.Add($"TipoEmpleado = {tipoEmpleado}");
        }

        if (cbxFiltrarDepartamento.SelectedValue != null && int.TryParse(cbxFiltrarDepartamento.SelectedValue.ToString(), out int idDepto) && idDepto > 0)
        {
            filtros.Add($"idDepartamento = {idDepto}");
        }

        if (cbxFiltrarPuesto.SelectedValue != null && int.TryParse(cbxFiltrarPuesto.SelectedValue.ToString(), out int idPuesto) && idPuesto > 0)
        {
            filtros.Add($"idPuesto = {idPuesto}");
        }

        _empleadosBS.Filter = filtros.Count > 0 ? string.Join(" AND ", filtros) : string.Empty;
    }

    private void BtnNuevo_Click(object? sender, EventArgs e)
    {
        BloquearControles(true);
        LimpiarCampos();
        txtNoCuenta.Focus();
    }

    private void BtnModificar_Click(object? sender, EventArgs e)
    {
        if (dgvEmpleados.CurrentRow == null)
        {
            MessageBox.Show("Seleccione un empleado para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        BloquearControles(true);
        txtNoCuenta.Focus();
    }

    private void BtnGuardar_Click(object? sender, EventArgs e)
    {
        if (!ValidarCampos()) return;
        
        try
        {
            Empleado empleado = new()
            {
                IdEmpleado = string.IsNullOrWhiteSpace(txtIdEmpleado.Text) ? 0 : Convert.ToInt32(txtIdEmpleado.Text),
                NoCuenta = Convert.ToInt32(txtNoCuenta.Text),
                FechaIngreso = dtpFechaIngreso.Value,
                TipoEmpleado = cbxTipoEmpleado.SelectedIndex,
                IdDepartamento = Convert.ToInt32(cbxDepartamento.SelectedValue),
                IdPuesto = Convert.ToInt32(cbxPuesto.SelectedValue),
                Status = chkEstatus.Checked,
                Nombre = txtNombre.Text.Trim(),
                ApPaterno = txtApPaterno.Text.Trim(),
                ApMaterno = txtApMaterno.Text.Trim(),
                Alias = txtAlias.Text.Trim(),
                RFC = txtRFC.Text.Trim(),
                CURP = txtCURP.Text.Trim(),
                IMSS = txtIMSS.Text.Trim(),
                Domicilio = txtDomicilio.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Telefono = txtTelefono.Text.Trim()
            };

            if (empleado.IdEmpleado == 0)
            {
                if( _empleadosBS.Find("noCuenta", empleado.NoCuenta) >= 0)
                {
                    MessageBox.Show("Ya existe un empleado con ese número de cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNoCuenta.Focus();
                    return;
                }
            }
            int nuevoId = _servicios.GuardarEmpleado(empleado);
            MessageBox.Show("Empleado guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BloquearControles(false);

            CargarDatos();

            DataRow? rowEncontrado = _empleadosDT.AsEnumerable().FirstOrDefault(r => Convert.ToInt32(r["idEmpleado"]) == nuevoId);

            if (rowEncontrado != null)
            {
                //int index = _empleadosView.Find(nuevoId);
                int index = _empleadosBS.Find("idEmpleado", nuevoId);
                if (index >= 0) _empleadosBS.Position = index;
                /*{
                    dgvEmpleados.ClearSelection();
                    dgvEmpleados.Rows[index].Selected = true;
                    dgvEmpleados.FirstDisplayedScrollingRowIndex = index;
                }*/
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnEliminar_Click(object? sender, EventArgs e)
    {
        if (dgvEmpleados.CurrentRow == null)
        {
            MessageBox.Show("Seleccione un empleado para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int idEmpleado = Convert.ToInt32(txtIdEmpleado.Text);
        string nombreEmpleado = dgvEmpleados.CurrentRow.Cells["colEmpleado"].Value.ToString() ?? "";

        if (MessageBox.Show($"¿Está seguro de eliminar al empleado {nombreEmpleado}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            try
            {
                int movimientos = _servicios.ContarMovimientosEmpleado(idEmpleado);
                if (movimientos > 0)
                {
                    MessageBox.Show($"No se puede eliminar el empleado porque tiene {movimientos} movimientos registrados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_servicios.EliminarEmpleado(idEmpleado))
                {
                    MessageBox.Show("Empleado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private bool ValidarCampos()
    {
        if (string.IsNullOrWhiteSpace(txtNoCuenta.Text))
        {
            MessageBox.Show("El número de cuenta es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNoCuenta.Focus();
            return false;
        }

        if (!int.TryParse(txtNoCuenta.Text, out _))
        {
            MessageBox.Show("El número de cuenta debe ser numérico.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNoCuenta.Focus();
            return false;
        }

        if (cbxTipoEmpleado.SelectedIndex < 0)
        {
            MessageBox.Show("Seleccione un tipo de empleado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cbxTipoEmpleado.Focus();
            return false;
        }

        if (cbxDepartamento.SelectedValue == null)
        {
            MessageBox.Show("Seleccione un departamento.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cbxDepartamento.Focus();
            return false;
        }

        if (cbxPuesto.SelectedValue == null)
        {
            MessageBox.Show("Seleccione un puesto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cbxPuesto.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNombre.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtApPaterno.Text))
        {
            MessageBox.Show("El apellido paterno es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtApPaterno.Focus();
            return false;
        }

        return true;
    }

    private void LimpiarCampos()
    {
        txtIdEmpleado.Clear();
        txtNoCuenta.Clear();
        cbxTipoEmpleado.SelectedIndex = 0;
        cbxDepartamento.SelectedIndex = -1;
        cbxPuesto.SelectedIndex = -1;
        dtpFechaIngreso.Value = DateTime.Now;
        chkEstatus.Checked = true;
        txtNombre.Clear();
        txtApPaterno.Clear();
        txtApMaterno.Clear();
        txtAlias.Clear();
        txtRFC.Clear();
        txtCURP.Clear();
        txtIMSS.Clear();
        txtDomicilio.Clear();
        txtEmail.Clear();
        txtTelefono.Clear();
        txtCargos.Text = "$0.00";
        txtAbonos.Text = "$0.00";
        txtSaldo.Text = "$0.00";
    }

    private void BloquearControles(bool bloquear)
    {
        txtFiltrar.Enabled = !bloquear;
        radActivos.Enabled = !bloquear;
        radInactivos.Enabled = !bloquear;
        cbxFiltrarDepartamento.Enabled = !bloquear;
        cbxFiltrarPuesto.Enabled = !bloquear;
        cbxFiltrarTipoEmpleado.Enabled = !bloquear;

        txtIdEmpleado.Enabled = false;
        txtNoCuenta.Enabled = bloquear;
        cbxTipoEmpleado.Enabled = bloquear;
        cbxDepartamento.Enabled = bloquear;
        cbxPuesto.Enabled = bloquear;
        txtNombre.Enabled = bloquear;
        txtApPaterno.Enabled = bloquear;
        txtApMaterno.Enabled = bloquear;
        txtAlias.Enabled = bloquear;
        txtRFC.Enabled = bloquear;
        txtCURP.Enabled = bloquear;
        txtIMSS.Enabled = bloquear;
        txtDomicilio.Enabled = bloquear;
        chkEstatus.Enabled = bloquear;
        dtpFechaIngreso.Enabled = bloquear;
        txtEmail.Enabled = bloquear;
        txtTelefono.Enabled = bloquear;

        dgvEmpleados.Enabled = bloquear;

        btnNuevo.Enabled = bloquear;
        btnModificar.Enabled = bloquear;
        btnGuardar.Enabled = !bloquear;
        btnEliminar.Enabled = bloquear;
    }
}

