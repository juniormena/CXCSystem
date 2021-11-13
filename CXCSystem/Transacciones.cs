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
    public partial class Transacciones : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        Transaccione transaccione = new Transaccione();
        public Transacciones()
        {
            InitializeComponent();
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            List<ComboBoxItem> listItem = new List<ComboBoxItem>();
            try
            {
                using (CxCEntities db = new CxCEntities())
                {
                    List<Tipos_Documentos> listTipoDocumentos = db.Tipos_Documentos.Select(s => s).Where(w => w.Estado == "A").ToList();
                    foreach (var item in listTipoDocumentos)
                    {
                        ComboBoxItem comboxBoxItem = new ComboBoxItem(item.Descripcion, item.Id);
                        listItem.Add(comboxBoxItem);
                    }

                    cbxTipoDoc.DataSource = listItem;
                    cbxTipoDoc.DisplayMember = "Name";
                    cbxTipoDoc.ValueMember = "Value";

                    listItem = new List<ComboBoxItem>();
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

            if (txtNumDoc.Text == "")
            {
                ok = false;
                errorProvider.SetError(txtNumDoc, "Ingresar un numero de documento");
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
            transaccione.Id = 0;
            txtNumDoc.Text = txtMonto.Text = cbxMovimiento.Text = "";
            btnAdd.Text = "Agregar";
            btnDelete.Enabled = false;
        }

        void PopulateDataGridView()
        {
            dgvTransacciones.AutoGenerateColumns = false;
            using (CxCEntities db = new CxCEntities())
            {

                dgvTransacciones.DataSource = db.Transacciones.Select(p => new { p.Id,p.Id_transaccion, p.Tipo_Mov, p.Num_doc, p.Fecha, p.Monto, p.Cliente.Nombre, p.Tipos_Documentos.Descripcion }).ToList();

            }
        }

        private void BorrarMensajeError()
        {
            errorProvider.SetError(txtMonto, "");
            errorProvider.SetError(txtNumDoc, "");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    Guid myuuid = Guid.NewGuid();
                    string myuuidAsString = myuuid.ToString();

                    ComboBoxItem itemCliente, itemTipoDoc;
                    itemCliente = (ComboBoxItem)cbxCliente.SelectedItem;
                    itemTipoDoc = (ComboBoxItem)cbxTipoDoc.SelectedItem;
                    int clienteId = itemCliente.Value;
                    int tipoDocId = itemTipoDoc.Value;

                    transaccione.Id_transaccion = myuuidAsString.Split('-')[0];
                    transaccione.Cliente_ID = clienteId;
                    transaccione.TipoDoc_ID = tipoDocId;
                    transaccione.Monto = int.Parse(txtMonto.Text.Trim());
                    transaccione.Num_doc = txtNumDoc.Text.Trim();
                    transaccione.Fecha = dtFecha.Value;
                    transaccione.Tipo_Mov = cbxMovimiento.Text.Trim();

                    using (CxCEntities db = new CxCEntities())
                    {

                        if (transaccione.Id == 0)//Insert
                            db.Transacciones.Add(transaccione);
                        else //Update
                            db.Entry(transaccione).State = EntityState.Modified;
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

        private void Transacciones_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres eliminar esta transaccion?", "Eliminar transaccion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (CxCEntities db = new CxCEntities())
                {
                    var entry = db.Entry(transaccione);
                    if (entry.State == EntityState.Detached)
                        db.Transacciones.Attach(transaccione);
                    db.Transacciones.Remove(transaccione);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Eliminado correctamente");
                }
            }
        }

        private void dgvTransacciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTransacciones.CurrentRow.Index != -1)
            {
                transaccione.Id = Convert.ToInt32(dgvTransacciones.CurrentRow.Cells["Id"].Value);
                using (CxCEntities db = new CxCEntities())
                {
                    transaccione = db.Transacciones.Where(x => x.Id == transaccione.Id).FirstOrDefault();
                    txtMonto.Text = transaccione.Monto.ToString();
                    txtNumDoc.Text = transaccione.Num_doc;
                    cbxMovimiento.Text = transaccione.Tipo_Mov;
                    cbxTipoDoc.SelectedValue = transaccione.TipoDoc_ID;
                    cbxCliente.SelectedValue = transaccione.Cliente_ID;
                    dtFecha.Value = transaccione.Fecha;
                }
                btnAdd.Text = "Actualizar";
                btnDelete.Enabled = true;
            }
        }
    }
}