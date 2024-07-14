using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projet1
{
    class connexionBD
    {
        MySqlConnection conn = new MySqlConnection("database=boutique;server=localhost; username=root;password=");
        
        public MySqlConnection getconnection
        {
            get
            {
                return conn;
            }
        }

        public void openConnect()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }

        public void closeConnect()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }


    }
}
