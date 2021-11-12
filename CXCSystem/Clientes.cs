using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CXCSystem
{
    public partial class Clientes : Form
    {
        Cliente cliente = new Cliente();
        ErrorProvider errorProvider = new ErrorProvider();
        public Clientes()
        {
            InitializeComponent();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                cliente.Nombre = txtNombre.Text.Trim();
                cliente.Cédula = txtCedula.Text.Trim();
                cliente.Limite_credit = int.Parse(txtCredito.Text.Trim());
                cliente.Estado = cbxEstado.Text.Trim();

                using (CxCEntities db = new CxCEntities())
                {
                    if (cliente.Id == 0)//Insert
                        db.Clientes.Add(cliente);
                    else //Update
                        db.Entry(cliente).State = EntityState.Modified;
                    db.SaveChanges();
                }
                Clear();
                BorrarMensajeError();
                PopulateDataGridView();
                MessageBox.Show("Enviado correctamente");
            }

        }

        void Clear()
        {
            txtNombre.Text = txtCedula.Text = txtCredito.Text = cbxEstado.Text = "";
            btnAdd.Text = "Agregar";
            btnDelete.Enabled = false;
        }

        void PopulateDataGridView()
        {
            dgvClientes.AutoGenerateColumns = false;
            using (CxCEntities db = new CxCEntities())
            {
                // List<Cliente> clienteslst = db.Clientes.Where(s => s.Estado != "I").ToList();

                dgvClientes.DataSource = db.Clientes.ToList();

            }
        }

        private bool ValidarCampos()
        {

            bool ok = true;

            if (txtNombre.Text == "")
            {
                ok = false;
                errorProvider.SetError(txtNombre, "Ingresar nombre");
            }
            if (txtCedula.Text == "")
            {
                ok = false;
                errorProvider.SetError(txtCedula, "Ingresar cedula");
            }
            if (txtCredito.Text == "")
            {
                ok = false;
                errorProvider.SetError(txtCredito, "Ingresar credito");
            }

            return ok;
        }

        private void BorrarMensajeError()
        {
            errorProvider.SetError(txtNombre, "");
            errorProvider.SetError(txtCedula, "");
            errorProvider.SetError(txtCredito, "");
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres eliminar el cliente?", "Eliminar cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (CxCEntities db = new CxCEntities())
                {
                    var entry = db.Entry(cliente);
                    if (entry.State == EntityState.Detached)
                        db.Clientes.Attach(cliente);
                    db.Clientes.Remove(cliente);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Eliminado correctamente");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.CurrentRow.Index != -1)
            {
                cliente.Id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Id"].Value);
                using (CxCEntities db = new CxCEntities())
                {
                    cliente = db.Clientes.Where(x => x.Id == cliente.Id).FirstOrDefault();
                    txtNombre.Text = cliente.Nombre;
                    txtCedula.Text = cliente.Cédula;
                    txtCredito.Text = cliente.Limite_credit.ToString();
                    cbxEstado.Text = cliente.Estado;
                }
                btnAdd.Text = "Actualizar";
                btnDelete.Enabled = true;
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }
    }
}
