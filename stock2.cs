using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
using System.IO;

namespace projet1
{
    public partial class stock2 : Form
    {
        ajout_stock stock = new ajout_stock();
        DGVPrinter printer = new DGVPrinter(); 

        public stock2()
        {
            InitializeComponent();
        }

        bool verify()
        {
            if ((textBox_produit.Text =="") || (textBox_modele.Text =="") ||
                (textBox_couleur.Text =="") || (textBox_taille.Text == "")||
                (textBox_prix.Text == "") || (textBox_nombre.Text == ""))
            {
                return false;
            }
            else
                return true;
        }
        
        private void stock2_Load(object sender, EventArgs e)
        {
            showTable();

            comboBox_rechercheStock.Items.Add("tee-shirt");
            comboBox_rechercheStock.Items.Add("robe");
            comboBox_rechercheStock.Items.Add("tennis");
            comboBox_rechercheStock.Items.Add("pantalon");
            comboBox_rechercheStock.Items.Add("short");
            comboBox_rechercheStock.Items.Add("blouson");
            comboBox_rechercheStock.Items.Add("chemise");
            comboBox_rechercheStock.Items.Add("costard");

        }
        public void showTable()
        {
            dataGridView_stock.DataSource = stock.getStocklist();
            dataGridView_stock.RowTemplate.Height = 40;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView_stock.DataSource = stock.searchStock(textBox_recherchestock.Text);
            textBox_recherchestock.Clear();
        }
        private void comboBox_rechercheStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView_stock.DataSource = stock.searchcomboBox(comboBox_rechercheStock.Text);
            comboBox_rechercheStock.ResetText();
        }

        private void ajout_stock_Click_1(object sender, EventArgs e)
        {
            //ajouter stock
            string nom_prod = textBox_produit.Text;
            string modele = textBox_modele.Text;
            string couleur = textBox_couleur.Text;
            string taille = textBox_taille.Text;
            string prix = textBox_prix.Text;
            string nombre = textBox_nombre.Text;
            DateTime date = DateTime.Now;

            if (verify())
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment Ajouter ce stock ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (stock.insertStock(nom_prod, modele, couleur, taille, prix, nombre, date))
                    {
                        showTable();
                        textBox_produit.Clear();
                        textBox_modele.Clear();
                        textBox_couleur.Clear();
                        textBox_taille.Clear();
                        textBox_prix.Clear();
                        textBox_nombre.Clear();
                        MessageBox.Show("Stock ajouter", "valider", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void supprimer_stock_Click_1(object sender, EventArgs e)
        {
            showTable();
            textBox_produit.Clear();
            textBox_modele.Clear();
            textBox_couleur.Clear();
            textBox_taille.Clear();
            textBox_prix.Clear();
            textBox_nombre.Clear();

            textBox_recherchestock.Clear();
        }

        private void button_supprime2_Click_1(object sender, EventArgs e)
        {
            //supprimer stock
            string id = textBox_id.Text;
            string nom_prod = textBox_produit.Text;
            string modele = textBox_modele.Text;
            string couleur = textBox_couleur.Text;
            string taille = textBox_taille.Text;
            string prix = textBox_prix.Text;
            string nombre = textBox_nombre.Text;

            if (verify())
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce stock ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (stock.supprimeStock(id, nom_prod, modele, couleur, taille, prix, nombre))
                    {
                        showTable();
                        textBox_produit.Clear();
                        textBox_modele.Clear();
                        textBox_couleur.Clear();
                        textBox_taille.Clear();
                        textBox_prix.Clear();
                        textBox_nombre.Clear();
                        MessageBox.Show("Stock supprimer", "valider", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void modifier_stock_Click_1(object sender, EventArgs e)
        {
            //modifier stock
            string id = textBox_id.Text;
            string nom_prod = textBox_produit.Text;
            string modele = textBox_modele.Text;
            string couleur = textBox_couleur.Text;
            string taille = textBox_taille.Text;
            string prix = textBox_prix.Text;
            string nombre = textBox_nombre.Text;

            if (verify())
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment modifier ce stock ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (stock.updateStock(id, nom_prod, modele, couleur, taille, prix, nombre))
                    {
                        showTable();
                        textBox_produit.Clear();
                        textBox_modele.Clear();
                        textBox_couleur.Clear();
                        textBox_taille.Clear();
                        textBox_prix.Clear();
                        textBox_nombre.Clear();
                        MessageBox.Show("Stock modifier", "valider", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dataGridView_stock_Click(object sender, EventArgs e)
        {
            textBox_id.Text = dataGridView_stock.CurrentRow.Cells[0].Value.ToString();
            textBox_produit.Text = dataGridView_stock.CurrentRow.Cells[1].Value.ToString();
            textBox_modele.Text = dataGridView_stock.CurrentRow.Cells[2].Value.ToString(); ;
            textBox_couleur.Text = dataGridView_stock.CurrentRow.Cells[3].Value.ToString();
            textBox_taille.Text = dataGridView_stock.CurrentRow.Cells[4].Value.ToString();
            textBox_prix.Text = dataGridView_stock.CurrentRow.Cells[5].Value.ToString();
            textBox_nombre.Text = dataGridView_stock.CurrentRow.Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printer.Title = "Inventaire stock";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "fredom boutique";
            printer.FooterSpacing = 15;
            //printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGridView_stock);

            showTable();
        }
    }
}

