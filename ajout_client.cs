using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace projet1
{
    class ajout_client
    {
        connexionBD conn = new connexionBD();
        public DataTable getClientlist()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `client`", conn.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public string clicount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, conn.getconnection);
            conn.openConnect();
            string count = command.ExecuteScalar().ToString();
            conn.closeConnect();
            return count;
        }
        public string totalclient()
        {
            return clicount("SELECT COUNT(*) FROM client");
        }


        public bool insertclient(string nom, string prenom, string telephone, string adresse )
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `client`(`nom`, `prenom`, `numerotel`, `Adresse`) VALUES(@nom, @prenom, @num, @adresse)", conn.getconnection);

            command.Parameters.Add("@nom", MySqlDbType.VarChar).Value = nom;
            command.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = prenom;
            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = telephone;
            command.Parameters.Add("@adresse", MySqlDbType.VarChar).Value = adresse;

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


        internal bool updateclient(string id,string nom, string prenom, string telephone, string adresse)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `client` SET `nom`=@nom,`prenom`=@prenom,`numerotel`=@num,`Adresse`=@adresse where idclient=@id", conn.getconnection);

            command.Parameters.Add("@id", MySqlDbType.Int16).Value = id;
            command.Parameters.Add("@nom", MySqlDbType.VarChar).Value = nom;
            command.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = prenom;
            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = telephone;
            command.Parameters.Add("@adresse", MySqlDbType.VarChar).Value = adresse;

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

        internal bool supprimeclient(string id, string nom, string prenom, string telephone, string adresse)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `client` WHERE idclient=@id", conn.getconnection);

            command.Parameters.Add("@id", MySqlDbType.Int16).Value = id;
            command.Parameters.Add("@nom", MySqlDbType.VarChar).Value = nom;
            command.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = prenom;
            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = telephone;
            command.Parameters.Add("@adresse", MySqlDbType.VarChar).Value = adresse;

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

        public DataTable searchClient(string client)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM client WHERE `numerotel` LIKE '%"+client+"%' OR nom LIKE'%"+client+ "%' OR prenom LIKE'%"+client+"%'", conn.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getList(MySqlCommand command)
        {
            command.Connection = conn.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
