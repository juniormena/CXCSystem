using CXCSystem.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CXCSystem
{
    public partial class AsientoContables : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        Asiento asiento = new Asiento();
        public AsientoContables()
        {
            InitializeComponent();
            LoadComboBox();
        }

        private void AsientoContables_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void LoadComboBox()
        {
            List<ComboBoxItem> listItem = new List<ComboBoxItem>();
            try
            {
                using (CxCEntities db = new CxCEntities())
                {
                    List<Cliente> listClientes = db.Clientes.Select(s => s).Where(w => w.Estado == "A").ToList();
                    foreach (var item in listClientes)
                    {
                        ComboBoxItem comboxBoxItem = new ComboBoxItem(item.Nombre, item.Id);
                        listItem.Add(comboxBoxItem);
                    }

                    cbxCliente.DataSource = listItem;
                    cbxCliente.DisplayMember = "Name";
                    cbxCliente.ValueMember = "Value";

                }
            }
            catch (Exception ex)
            {
                Util.MessageError(ex.Message);
            }
        }
        private bool ValidarCampos()
        {

            bool ok = true;

            if (txtCuentaContable.Text == "")
            {
                ok = false;
                errorProvider.SetError(txtCuentaContable, "Ingresar una cuenta contable");
            }

            if (txtDescripcion.Text == "") 
            {
                ok = false;
                errorProvider.SetError(txtDescripcion, "Ingresar una descripcion");
            }
            if (txtMonto.Text == "")
            {
                ok = false;
                errorProvider.SetError(txtMonto, "Ingresar un monto");
            }

            return ok;
        }

        void Clear()
        {
            asiento.Id = 0;
            txtDescripcion.Text = txtMonto.Text = txtCuentaContable.Text = cbxMovimiento.Text = cbxEstado.Text = "";
            btnAdd.Text = "Agregar";
            btnDelete.Enabled = false;
        }

        private void BorrarMensajeError()
        {
            errorProvider.SetError(txtCuentaContable, "");
            errorProvider.SetError(txtDescripcion, "");
            errorProvider.SetError(txtMonto, "");
        }

        void PopulateDataGridView()
        {
            dgvAsientos.AutoGenerateColumns = false;
            using (CxCEntities db = new CxCEntities())
            {

                dgvAsientos.DataSource = db.Asientos
                    .Select(p => new { p.Id, p.Id_Asiento, p.Descripcion, p.Tipo_movimiento, p.Cuenta, p.Fecha, p.Monto, p.Cliente.Nombre, p.Estado }).ToList();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    Guid myuuid = Guid.NewGuid();
                    string myuuidAsString = myuuid.ToString();

                    ComboBoxItem itemCliente;
                    itemCliente = (ComboBoxItem)cbxCliente.SelectedItem;
                    int clienteId = itemCliente.Value;

                    asiento.Id_Asiento = myuuidAsString.Split('-')[0];
                    asiento.Descripcion = txtDescripcion.Text;
                    asiento.Cliente_ID = clienteId;
                    asiento.Monto = int.Parse(txtMonto.Text.Trim());
                    asiento.Cuenta = txtCuentaContable.Text.Trim();
                    asiento.Fecha = dtFecha.Value;
                    asiento.Tipo_movimiento = cbxMovimiento.Text.Trim();
                    asiento.Estado = cbxEstado.Text;

                    using (CxCEntities db = new CxCEntities())
                    {

                        if (asiento.Id == 0)//Insert
                            db.Asientos.Add(asiento);
                        else //Update
                            db.Entry(asiento).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    Clear();
                    BorrarMensajeError();
                    PopulateDataGridView();
                    MessageBox.Show("Enviado correctamente");
                }
            }
            catch (Exception ex)
            {

                Util.MessageError(ex.Message);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvAsientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAsientos.CurrentRow.Index != -1)
            {
                asiento.Id = Convert.ToInt32(dgvAsientos.CurrentRow.Cells["Id"].Value);
                using (CxCEntities db = new CxCEntities())
                {
                    asiento = db.Asientos.Where(x => x.Id == asiento.Id).FirstOrDefault();
                    txtDescripcion.Text = asiento.Descripcion;
                    txtMonto.Text = asiento.Monto.ToString();
                    txtCuentaContable.Text = asiento.Cuenta;
                    cbxMovimiento.Text = asiento.Tipo_movimiento;
                    cbxCliente.SelectedValue = asiento.Cliente_ID;
                    dtFecha.Value = asiento.Fecha;
                    cbxEstado.Text = asiento.Estado;
                }
                btnAdd.Text = "Actualizar";
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres eliminar este asiento?", "Eliminar asiento", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (CxCEntities db = new CxCEntities())
                {
                    var entry = db.Entry(asiento);
                    if (entry.State == EntityState.Detached)
                        db.Asientos.Attach(asiento);
                    db.Asientos.Remove(asiento);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Eliminado correctamente");
                }
            }
        }
    }
}
