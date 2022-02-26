using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace registration
{
    public class connection
    {
        SqlConnection conn = new SqlConnection();
        public connection()
        {
            conn.ConnectionString = @"Data Source=DESKTOP-ABI597E\SQLEXPRESS;Initial Catalog=teste;Integrated Security=True";
        }   
        public SqlConnection conectar()
        {
           if(conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }
        public void desconectar()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
            
        }

    }
}
