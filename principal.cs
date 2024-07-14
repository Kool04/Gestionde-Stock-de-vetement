using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projet1
{
    public partial class stock : Form
    {
        ajout_stock count = new ajout_stock();
        ajout_client countcli = new ajout_client();
        ajout_vente countvente = new ajout_vente();
        public stock()
        {
            InitializeComponent();
        }
       // MySqlconnexion con = new MySqlconnexion("database=boutique,server=localhost,userid=root,pwd=");

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlconnexion con = new MySqlconnexion("database=boutique;server=localhost; username=root;password=");

            try
            {
                con.open();
                MessageBox.Show("connexion reussi");  

            }
            catch(Exception)
            {
                MessageBox.Show("erreur");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void customizeDesign()
        {
            panel_stock.Visible = false;
            panel_client.Visible = false;
            panel_vente.Visible = false;
        }
        private void hideSubmenu()
        {
            if (panel_stock.Visible == true)
                panel_stock.Visible = false;
            if (panel_client.Visible == true)
                panel_client.Visible = false;
            if (panel_vente.Visible == true)
                panel_vente.Visible = false;
        }
        private void showSubmenu(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                hideSubmenu();
                Submenu.Visible = true;
            }
            else
                Submenu.Visible = false;
        }

  

        private Form stock2()
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //.....
            //....code....
            //
            hideSubmenu();
            
        }

        private void modifier_stock_Click(object sender, EventArgs e)
        {
            //.....
            //....code....
            //
            hideSubmenu();
        }

        private void supprimer_stock_Click(object sender, EventArgs e)
        {
            //.....
            //....code....
            //
            hideSubmenu();
        }
       
        private void client_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_client);

            openchildForm(new client());
        }

        private void ajouter_client_Click(object sender, EventArgs e)
        {
            //.....
            //....code....
            //
            hideSubmenu();
        }

        private void modifier_client_Click(object sender, EventArgs e)
        {
            //.....
            //....code....
            //
            hideSubmenu();
        }

        private void supprimer_client_Click(object sender, EventArgs e)
        {
            //.....
            //....code....
            //
            hideSubmenu();
        }

        private void vente_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_vente);

            openchildForm(new vente());

        }

        private void ajouter_vente_Click(object sender, EventArgs e)
        {
            //.....
            //....code....
            //
            hideSubmenu();
        }

        private void modifier_vente_Click(object sender, EventArgs e)
        {
            //.....
            //....code....
            //
            hideSubmenu();
        }

        private void supprimer_vente_Click(object sender, EventArgs e)
        {
            //.....
            //....code....
            //
            hideSubmenu();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //.....
            //....code....
            //
            hideSubmenu();
            openchildForm(new pdf());

        }

        private void quitter_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter l'application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                login log = new login();
                this.Hide();
                log.Show();
            }
            else if (result == DialogResult.No)
            {
                // Ne rien faire
            }
        }

        private void stock_Load(object sender, EventArgs e)
        {
            label_totalstock.Text = "Total Stock:" + count.totalstock();
            label_totalclient.Text = "Total Client:" + countcli.totalclient();
            label_totalvente.Text = "Total vente:" + countvente.totalvente();
        }

        private void client_Load(object sender, EventArgs e)
        {
            label_totalclient.Text = "Total Client:" + countcli.totalclient();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private Form activeForm= null;
        private void openchildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
   

        private void button1_Click_2(object sender, EventArgs e)
        {
            showSubmenu(panel_stock);

            openchildForm(new stock2());
        }


        private void button3_Click(object sender, EventArgs e)
        {
            stock main = new stock();
            this.Hide();
            main.Show();
        }
    }
}
