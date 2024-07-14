using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DGVPrinterHelper;
using System.Windows.Forms;

namespace projet1
{
    public partial class client : Form
    {
        ajout_client cli = new ajout_client();
        DGVPrinter printer = new DGVPrinter();
        public client()
        {
            InitializeComponent();
        }


        private void supprimer_stock_Click(object sender, EventArgs e)
        {
            showTableclient();
            textBox_nom.Clear();
            textBox_prenom.Clear();
            textBox_telephone.Clear();
            textBox_adresse.Clear();
        }

        private void dataGridView_client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ajout_stock_Click(object sender, EventArgs e)
        {

            //ajouter client
            string nom = textBox_nom.Text;
            string prenom = textBox_prenom.Text;
            string telephone = textBox_telephone.Text;
            string adresse = textBox_adresse.Text;
            

            if (verify())
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment ajouter ce client ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (cli.insertclient(nom, prenom, telephone, adresse))
                    {
                        showTableclient();
                        textBox_nom.Clear();
                        textBox_prenom.Clear();
                        textBox_telephone.Clear();
                        textBox_adresse.Clear();
                        MessageBox.Show("Client ajouter", "valider", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.No)
                {
                    // Ne rien faire
                }
            }
            else
            {
                MessageBox.Show("champ vide", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool verify()
        {
            if ((textBox_nom.Text == "") || (textBox_prenom.Text == "") ||
                (textBox_telephone.Text == "") || (textBox_adresse.Text == ""))
            {
                return false;
            }
            else
                return true;
        }

        private void modifier_stock_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string nom = textBox_nom.Text;
            string prenom = textBox_prenom.Text;
            string telephone = textBox_telephone.Text;
            string adresse = textBox_adresse.Text;

            if (verify())
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment modifier le client ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (cli.updateclient(id, nom, prenom, telephone, adresse))
                    {
                        showTableclient();
                        textBox_nom.Clear();
                        textBox_prenom.Clear();
                        textBox_telephone.Clear();
                        textBox_adresse.Clear();
                        MessageBox.Show("Client modifié", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la modification du client", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.No)
                {
                    // Ne rien faire
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_supprime2_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string nom = textBox_nom.Text;
            string prenom = textBox_prenom.Text;
            string telephone = textBox_telephone.Text;
            string adresse = textBox_adresse.Text;


            if (verify())
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer le client ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (cli.supprimeclient(id, nom, prenom, telephone, adresse))
                    {
                        showTableclient();
                        textBox_nom.Clear();
                        textBox_prenom.Clear();
                        textBox_telephone.Clear();
                        textBox_adresse.Clear();
                        MessageBox.Show("Client supprimer", "valider", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.No)
                {
                    // Ne rien faire
                }
            }
            else
            {
                MessageBox.Show("champ vide", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void showTableclient()
        {
            dataGridView_client.DataSource = cli.getClientlist();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView_client.DataSource = cli.searchClient(textBox_rechercheclient.Text);
            textBox_rechercheclient.Clear();
        }

        private void textBox_nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void client_Load_1(object sender, EventArgs e)
        {
            showTableclient();
        }

        private void dataGridView_client_Click_1(object sender, EventArgs e)
        {
            textBox_id.Text = dataGridView_client.CurrentRow.Cells[0].Value.ToString();
            textBox_nom.Text = dataGridView_client.CurrentRow.Cells[1].Value.ToString();
            textBox_prenom.Text = dataGridView_client.CurrentRow.Cells[2].Value.ToString(); ;
            textBox_telephone.Text = dataGridView_client.CurrentRow.Cells[3].Value.ToString();
            textBox_adresse.Text = dataGridView_client.CurrentRow.Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printer.Title = "Inventaire CLIENT";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "fredom boutique";
            // printer.FooterSpacing = 15;
            //printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGridView_client);
        }
    }
}
