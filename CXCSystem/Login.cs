using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CXCSystem
{
    public partial class Login : Form
    {
        string connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;";
        public Login()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tiposDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void asientosContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
        }

        private void mantenimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TitlePrincipal_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = DBConexion.getConnection();
                string queryToExceute = "SELECT COUNT(*) FROM Users WHERE Usuario='" + txtUser.Text.ToString() + "' AND Contraseña='" + txtContra.Text.ToString() + "'";                                                         // 
                SqlDataAdapter sda = new SqlDataAdapter(queryToExceute, con);
                /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                    Principal home = new Principal();
                    this.Hide();

                    home.Show();
                }
                else 
                {
                    MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                con.Close();
                    
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
