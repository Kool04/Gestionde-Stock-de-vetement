using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projet1
{
    public partial class login : Form
    {
        ajout_client client = new ajout_client();
        public login()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_utilisateur.Text=="" || textBox_motdepasse.Text=="")
            {
                MessageBox.Show("champ vide", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string utilisateur = textBox_utilisateur.Text;
                string pass = textBox_motdepasse.Text;

                DataTable table = client.getList(new MySqlCommand("SELECT * FROM `login` WHERE `nom_utilisateur`='" + utilisateur + "' AND `mot_de_pass`='" + pass + "'"));
                if (table.Rows.Count > 0)
                {

                    stock main = new stock();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("le nom d'utilisateur et le mot de passe saisie est incorrecte", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
        }

        private void textBox_utilisateur_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
