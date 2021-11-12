using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CXCSystem
{
    class DBConexion
    {
        public static SqlConnection getConnection()
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=CXC;Trusted_Connection=True;";
            SqlConnection ocon = new SqlConnection(connectionString);
            ocon.Open();
            return ocon;
        }

    }
}
