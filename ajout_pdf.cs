using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace projet1
{
    class ajout_pdf
    {
        connexionBD conn = new connexionBD();

        public DataTable getVentelist()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `vente`", conn.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public string nomcli(string idcli)
        {
            string query = "SELECT nom FROM client WHERE idclient = @idClient";
            conn.openConnect();
            {
                using (MySqlCommand command = new MySqlCommand(query, conn.getconnection))
                {
                    command.Parameters.AddWithValue("@IdClient", idcli);
                    conn.openConnect();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return result .ToString();
                    }
                }
            }
            return null;
        }

        public string prenomcli(string idcli)
        {
            string query = "SELECT prenom FROM client WHERE idclient = @idClient";
            conn.openConnect();
            {
                using (MySqlCommand command = new MySqlCommand(query, conn.getconnection))
                {
                    command.Parameters.AddWithValue("@IdClient", idcli);
                    conn.openConnect();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                }
            }
            return null;
        }

        public string numerocli(string idcli)
        {
            string query = "SELECT numerotel FROM client WHERE idclient = @idClient";
            conn.openConnect();
            {
                using (MySqlCommand command = new MySqlCommand(query, conn.getconnection))
                {
                    command.Parameters.AddWithValue("@IdClient", idcli);
                    conn.openConnect();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                }
            }
            return null;
        }

        public string nomprod(string idprod)
        {
            string query = "SELECT nom_produit FROM stock WHERE id_produit = @idprod";
            conn.openConnect();
            {
                using (MySqlCommand command = new MySqlCommand(query, conn.getconnection))
                {
                    command.Parameters.AddWithValue("@Idprod", idprod);
                    conn.openConnect();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                }
            }
            return null;
        }

        public string modeleprod(string idprod)
        {
            string query = "SELECT modele FROM stock WHERE id_produit = @idprod";
            conn.openConnect();
            {
                using (MySqlCommand command = new MySqlCommand(query, conn.getconnection))
                {
                    command.Parameters.AddWithValue("@Idprod", idprod);
                    conn.openConnect();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                }
            }
            return null;
        }

        public string couleurprod(string idprod)
        {
            string query = "SELECT couleur FROM stock WHERE id_produit = @idprod";
            conn.openConnect();
            {
                using (MySqlCommand command = new MySqlCommand(query, conn.getconnection))
                {
                    command.Parameters.AddWithValue("@Idprod", idprod);
                    conn.openConnect();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                }
            }
            return null;
        }

    }
}
