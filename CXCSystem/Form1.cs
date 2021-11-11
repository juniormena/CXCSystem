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
    public partial class Form1 : Form
    {
        Clientes cliente;
        TipoDocumentos tipoDocumentos;
        Transacciones transacciones;
        AsientoContables asientoContables;
        public Form1()
        {
            InitializeComponent();
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

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transacciones = new Transacciones();
            transacciones.ShowDialog();
        }

        private void asientosContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asientoContables = new AsientoContables();
            asientoContables.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
