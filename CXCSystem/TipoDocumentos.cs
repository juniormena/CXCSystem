using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CXCSystem
{
    public partial class TipoDocumentos : Form
    {
        Tipos_Documentos tipodocs = new Tipos_Documentos();
        ErrorProvider errorProvider = new ErrorProvider();
        public TipoDocumentos()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                tipodocs.Descripcion = txtDescripcion.Text.Trim();
                tipodocs.Cuenta_contable = txtCuentaContable.Text.Trim();
                tipodocs.Estado = cbxEstado.Text.Trim();

                using (CxCEntities db = new CxCEntities())
                {
                    if (tipodocs.Id == 0)//Insert
                        db.Tipos_Documentos.Add(tipodocs);
                    else //Update
                        db.Entry(tipodocs).State = EntityState.Modified;
                    db.SaveChanges();
                }
                Clear();
                BorrarMensajeError();
                PopulateDataGridView();
                MessageBox.Show("Enviado correctamente");
            }
        }

        void PopulateDataGridView()
        {
            dgvTipoDocs.AutoGenerateColumns = false;
            using (CxCEntities db = new CxCEntities())
            {

                dgvTipoDocs.DataSource = db.Tipos_Documentos.ToList();

            }
        }

        void Clear()
        {
            txtDescripcion.Text = txtCuentaContable.Text = cbxEstado.Text = "";
            btnAdd.Text = "Agregar";
            btnDelete.Enabled = false;
        }

        private bool ValidarCampos()
        {

            bool ok = true;

            if (txtDescripcion.Text == "")
            {
                ok = false;
                errorProvider.SetError(txtDescripcion, "Ingresar descripcion");
            }
            if (txtCuentaContable.Text == "")
            {
                ok = false;
                errorProvider.SetError(txtCuentaContable, "Ingresar cuenta contable");
            }

            return ok;
        }

        private void BorrarMensajeError()
        {
            errorProvider.SetError(txtDescripcion, "");
            errorProvider.SetError(txtCuentaContable, "");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres eliminar este tipo de documento?", "Eliminar tipo de documento", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (CxCEntities db = new CxCEntities())
                {
                    var entry = db.Entry(tipodocs);
                    if (entry.State == EntityState.Detached)
                        db.Tipos_Documentos.Attach(tipodocs);
                    db.Tipos_Documentos.Remove(tipodocs);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Eliminado correctamente");
                }
            }
        }

        private void TipoDocumentos_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void dgvTipoDocs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTipoDocs.CurrentRow.Index != -1)
            {
                tipodocs.Id = Convert.ToInt32(dgvTipoDocs.CurrentRow.Cells["Id"].Value);
                using (CxCEntities db = new CxCEntities())
                {
                    tipodocs = db.Tipos_Documentos.Where(x => x.Id == tipodocs.Id).FirstOrDefault();
                    txtDescripcion.Text = tipodocs.Descripcion;
                    txtCuentaContable.Text = tipodocs.Cuenta_contable;
                    cbxEstado.Text = tipodocs.Estado;
                }
                btnAdd.Text = "Actualizar";
                btnDelete.Enabled = true;
            }
        }
    }
}
