using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CXCSystem
{
    public partial class Principal : Form
    {
        Clientes cliente;
        TipoDocumentos tipoDocumentos;
        Transacciones transacciones;
        AsientoContables asientoContables;
        public Principal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cliente = new Clientes();
            cliente.ShowDialog();
        }

        private void tiposDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tipoDocumentos = new TipoDocumentos();
            tipoDocumentos.ShowDialog();
        }

        private void asientosContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asientoContables = new AsientoContables();
            asientoContables.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transacciones = new Transacciones();
            transacciones.ShowDialog();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}
