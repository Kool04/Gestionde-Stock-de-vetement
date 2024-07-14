using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projet1
{
    class ajout_vente
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

       public DataTable getDatavente(MySqlCommand command)
        {
            command.Connection = conn.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool insertvente(string idlcli, string idprod, string pu, string qte, string remise, string payment,string avance,string reste,string total, DateTime date)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `vente`(`idclient`, `id_produit`, `prix_unitaire`, `qte`, `remise`, `payment`, `montant_avance`, `reste`, `total`, `Date`) VALUES(@cli, @prod, @pu, @qte, @remise, @paye, @avance, @reste, @total, @date)", conn.getconnection);
  
            command.Parameters.Add("@cli", MySqlDbType.Int32).Value = idlcli;
            command.Parameters.Add("@prod", MySqlDbType.Int32).Value = idprod;
            command.Parameters.Add("@pu", MySqlDbType.VarChar).Value = pu;
            command.Parameters.Add("@qte", MySqlDbType.Int32).Value = qte;
            command.Parameters.Add("@remise", MySqlDbType.VarChar).Value = remise;
            command.Parameters.Add("@paye", MySqlDbType.VarChar).Value = payment;
            command.Parameters.Add("@avance", MySqlDbType.VarChar).Value = avance;
            command.Parameters.Add("@reste", MySqlDbType.VarChar).Value = reste;
            command.Parameters.Add("@total", MySqlDbType.VarChar).Value = total;
            command.Parameters.Add("@date", MySqlDbType.Datetime).Value = date;

            conn.openConnect();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnect();
                return true;
            }
            else
            {
                conn.closeConnect();
                return false;
            }
        }

        public bool updatevente(string id, string idlcli, string idprod, string pu, string qte, string remise, string payment, string avance, string reste, string total)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `vente` SET `idclient`=@cli,`id_produit`=@prod,`prix_unitaire`=@pu,`qte`=@qte,`remise`=@remise,`payment`=@paye,`montant_avance`=@avance,`reste`=@reste,`total`=@total WHERE `id_vente`=@id", conn.getconnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@cli", MySqlDbType.Int32).Value = idlcli;
            command.Parameters.Add("@prod", MySqlDbType.Int32).Value = idprod;
            command.Parameters.Add("@pu", MySqlDbType.VarChar).Value = pu;
            command.Parameters.Add("@qte", MySqlDbType.Int32).Value = qte;
            command.Parameters.Add("@remise", MySqlDbType.VarChar).Value = remise;
            command.Parameters.Add("@paye", MySqlDbType.VarChar).Value = payment;
            command.Parameters.Add("@avance", MySqlDbType.VarChar).Value = avance;
            command.Parameters.Add("@reste", MySqlDbType.VarChar).Value = reste;
            command.Parameters.Add("@total", MySqlDbType.VarChar).Value = total;

            conn.openConnect();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnect();
                return true;
            }
            else
            {
                conn.closeConnect();
                return false;
            }
        }

        public bool supprimevente(string id,string idlcli, string idprod, string pu, string qte, string remise, string payment, string avance, string reste, string total)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `vente` WHERE `id_vente`=@id", conn.getconnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@cli", MySqlDbType.Int32).Value = idlcli;
            command.Parameters.Add("@prod", MySqlDbType.Int32).Value = idprod;
            command.Parameters.Add("@pu", MySqlDbType.VarChar).Value = pu;
            command.Parameters.Add("@qte", MySqlDbType.Int32).Value = qte;
            command.Parameters.Add("@remise", MySqlDbType.VarChar).Value = remise;
            command.Parameters.Add("@paye", MySqlDbType.VarChar).Value = payment;
            command.Parameters.Add("@avance", MySqlDbType.VarChar).Value = avance;
            command.Parameters.Add("@reste", MySqlDbType.VarChar).Value = reste;
            command.Parameters.Add("@total", MySqlDbType.VarChar).Value = total;

            conn.openConnect();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnect();
                return true;
            }
            else
            {
                conn.closeConnect();
                return false;
            }
        }

        public string prixunitaire(string idprod)
        {
            string query = "SELECT prix_unitaire FROM stock WHERE id_produit = @idprod";
            conn.openConnect();
            {
                using (MySqlCommand command = new MySqlCommand(query, conn.getconnection))
                {
                    command.Parameters.AddWithValue("@idprod", idprod);

                    // Assurez-vous que la propriété CommandText est définie correctement
                    command.CommandText = query;

                    conn.openConnect();

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                }
                return null;
            }
        }
        public string excount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, conn.getconnection);
            conn.openConnect();
            string count = command.ExecuteScalar().ToString();
            conn.closeConnect();
            return count;
        }
        public string totalvente()
        {
            return excount("SELECT COUNT(*) FROM vente");
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
                        return result.ToString();
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

        public string stock(string idprod)
        {
            string query = "SELECT nombre FROM stock WHERE id_produit = @idprod";
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

        public DataTable searchVente(string vente)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM vente WHERE `payment` LIKE '%"+vente+"%'", conn.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable searchVente2(string vente)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM vente WHERE `idclient` LIKE '%"+vente+"%'", conn.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
