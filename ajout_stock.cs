using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace projet1
{
    class ajout_stock
    {
        connexionBD conn = new connexionBD();

        [Obsolete]
        public bool insertStock(string nom_prod,string modele,string couleur,string taille,string prix,string nombre, DateTime date)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `stock`(`nom_produit`, `modele`, `couleur`, `taille`, `prix_unitaire`, `nombre`, `date_ajout`) VALUES(@np, @mdl, @clr, @taille, @prix, @nbr, @date)",conn.getconnection);

            command.Parameters.Add("@np", MySqlDbType.VarChar).Value =nom_prod ;
            command.Parameters.Add("@mdl", MySqlDbType.VarChar).Value = modele;
            command.Parameters.Add("@clr", MySqlDbType.VarChar).Value = couleur;
            command.Parameters.Add("@taille", MySqlDbType.VarChar).Value = taille;
            command.Parameters.Add("@prix", MySqlDbType.VarChar).Value = prix;
            command.Parameters.Add("@nbr", MySqlDbType.VarChar).Value = nombre;
            command.Parameters.Add("@date", MySqlDbType.Datetime).Value = date ;

            conn.openConnect();
            if (command.ExecuteNonQuery()==1)
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
       
        public DataTable getStocklist()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `stock`", conn.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public string excount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, conn.getconnection);
            conn.openConnect();
            string count = command.ExecuteScalar().ToString();
            conn.closeConnect();
            return count;
        }
        public string totalstock()
        {
            return excount("SELECT COUNT(*) FROM stock");
        }

        public bool updateStock(string id, string nom_prod, string modele, string couleur, string taille, string prix, string nombre)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `stock` SET `nom_produit`=@np,modele=@mdl,couleur=@clr,`taille`=@taille,`prix_unitaire`=@prix,`nombre`=@nbr where id_produit=@id", conn.getconnection);

            command.Parameters.Add("@id", MySqlDbType.Int16).Value = id;
            command.Parameters.Add("@np", MySqlDbType.VarChar).Value = nom_prod;
            command.Parameters.Add("@mdl", MySqlDbType.VarChar).Value = modele;
            command.Parameters.Add("@clr", MySqlDbType.VarChar).Value = couleur;
            command.Parameters.Add("@taille", MySqlDbType.VarChar).Value = taille;
            command.Parameters.Add("@prix", MySqlDbType.VarChar).Value = prix;
            command.Parameters.Add("@nbr", MySqlDbType.VarChar).Value = nombre;

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
            throw new NotImplementedException();
        }

        public bool supprimeStock(string id, string nom_prod, string modele, string couleur, string taille, string prix, string nombre)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `stock` WHERE id_produit=@id", conn.getconnection);

            command.Parameters.Add("@id", MySqlDbType.Int16).Value = id;
            command.Parameters.Add("@np", MySqlDbType.VarChar).Value = nom_prod;
            command.Parameters.Add("@mdl", MySqlDbType.VarChar).Value = modele;
            command.Parameters.Add("@clr", MySqlDbType.VarChar).Value = couleur;
            command.Parameters.Add("@taille", MySqlDbType.VarChar).Value = taille;
            command.Parameters.Add("@prix", MySqlDbType.VarChar).Value = prix;
            command.Parameters.Add("@nbr", MySqlDbType.VarChar).Value = nombre;

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
            throw new NotImplementedException();
        }

        public DataTable searchStock (string stock)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM stock WHERE `couleur` LIKE '%"+stock+"%' OR `modele` LIKE '%"+stock+"%'", conn.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable() ;
            adapter.Fill( table );
            return table;
        }
        public DataTable searchcomboBox(string stock)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM stock WHERE `nom_produit` LIKE '%"+stock+"%'", conn.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
