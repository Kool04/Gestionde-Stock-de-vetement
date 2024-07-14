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
using DGVPrinterHelper;
using System.Data;

namespace projet1
{
    public partial class vente : Form
    {
        ajout_vente vendre = new ajout_vente();
        DGVPrinter printer = new DGVPrinter();

        private DataTable stockData;
        connexionBD conn = new connexionBD();


        public vente()
        {
            InitializeComponent();

            //comboBox_produit.SelectedIndexChanged += comboBox_produit_SelectedIndexChanged;
        }

        bool verify()
        {
            if ((comboBox_client.Text == "") || (comboBox_produit.Text == "") ||
                (textBox_pu.Text == "") || (textBox_qte.Text == "") ||
                (textBox_remise.Text == "") || (comboBox_payment.Text == ""))
            {
                return false;
            }
            else
                return true;
        }

        private void ajout_vente_Click(object sender, EventArgs e)
        {
            //--------code calcul---------------//
            // calcul total normal
            decimal prixUnitaire = decimal.Parse(textBox_pu.Text);
            int quantite = int.Parse(textBox_qte.Text);

            decimal total1 = prixUnitaire * quantite;
            textBox_total.Text = total1.ToString();
            // -----------//

            //calcul remise
            int montantInitial = int.Parse(textBox_total.Text);
            decimal pourcentageRemise = decimal.Parse(textBox_remise.Text);

            decimal montantRemise = montantInitial * (pourcentageRemise / 100);

            decimal montantApresRemise = montantInitial - montantRemise;

            textBox_total.Text = montantApresRemise.ToString();
            //------------//

            //avec avance//
            string selectedPayment = comboBox_payment.SelectedItem.ToString();

            if (selectedPayment == "avec avance")
            {
                // Vérification des montants saisis
                if (int.TryParse(textBox_avance.Text, out int avance1) &&
                    decimal.TryParse(textBox_total.Text, out decimal init))
                {
                    decimal reste1 = init - avance1;
                    textBox_reste.Text = reste1.ToString();
                }
                else
                {
                    MessageBox.Show("Veuillez saisir des montants valides.");
                }
            }
            else if (selectedPayment == "tout payé")
            {
                textBox_avance.Text = "0";
                textBox_reste.Text = "0";
            }
            else
            {
                // Réinitialisation des champs
                textBox_avance.Text = "";
                textBox_reste.Text = "";
            }
            //------fin code calcul---------------//

            //------ajout vente------//

            string idlcli = comboBox_client.Text;
            string idprod = comboBox_produit.Text;
            string pu = textBox_pu.Text;
            string qte = textBox_qte.Text;
            string remise = textBox_remise.Text;
            string payment = comboBox_payment.Text;
            string avance = textBox_avance.Text;
            string reste = textBox_reste.Text;
            string total = textBox_total.Text;
            DateTime date = DateTime.Now;


            if (verify())
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment Ajouter cet vente ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int quantiteVente = Convert.ToInt32(textBox_qte.Text);
                    int idProduit = Convert.ToInt32(comboBox_produit.SelectedValue);

                    string query = "SELECT nombre FROM stock WHERE id_produit = @id";
                    string updateQuery = "UPDATE stock SET nombre = @nouveauNombre WHERE id_produit = @id";

                    {
                        conn.openConnect();
                        using (var command = new MySqlCommand(query, conn.getconnection))
                        {
                            command.Parameters.AddWithValue("@id", idProduit);

                            var nombre = command.ExecuteScalar();
                            if (nombre != null)
                            {

                                string nombreDisponibleString = nombre.ToString();

                                int nombreDisponible = Convert.ToInt32(nombreDisponibleString);
                                if (quantiteVente > nombreDisponible)
                                {

                                    MessageBox.Show("stock insuffisant.", "Erreur de quantité");
                                }
                                else
                                {
                                    if (vendre.insertvente(idlcli, idprod, pu, qte, remise, payment, avance, reste, total, date))
                                    {
                                        int nombreActuel = Convert.ToInt32(nombre);
                                        int nouveauNombre = nombreActuel - quantiteVente;

                                        using (var updateCommand = new MySqlCommand(updateQuery, conn.getconnection))
                                        {
                                            updateCommand.Parameters.AddWithValue("@nouveauNombre", nouveauNombre);
                                            updateCommand.Parameters.AddWithValue("@id", idProduit);
                                            updateCommand.ExecuteNonQuery();
                                        }

                                        showTable();
                                        textBox_pu.Clear();
                                        textBox_qte.Clear();
                                        textBox_remise.Clear();
                                        textBox_avance.Clear();
                                        textBox_reste.Clear();
                                        textBox_total.Clear();

                                        MessageBox.Show("Stock ajouter", "valider", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }

                            }
                            else
                            {
                                MessageBox.Show("erreur.", "Erreur de quantité");
                            }
                        }
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
            //------Fin ajout vente--------//
        }

        private void supprime_vente_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string idlcli = comboBox_client.Text;
            string idprod = comboBox_produit.Text;
            string pu = textBox_pu.Text;
            string qte = textBox_qte.Text;
            string remise = textBox_remise.Text;
            string payment = comboBox_payment.Text;
            string avance = textBox_avance.Text;
            string reste = textBox_reste.Text;
            string total = textBox_total.Text;


            if (verify())
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cet vente ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int quantiteVente = Convert.ToInt32(textBox_qte.Text);
                    int idProduit = Convert.ToInt32(comboBox_produit.SelectedValue);

                    string query = "SELECT nombre FROM stock WHERE id_produit = @id";
                    string updateQuery = "UPDATE stock SET nombre = @nouveauNombre WHERE id_produit = @id";
                    {
                        conn.openConnect();
                        using (var command = new MySqlCommand(query, conn.getconnection))
                        {
                            command.Parameters.AddWithValue("@id", idProduit);

                            var nombre = command.ExecuteScalar();
                            if (nombre != null)
                            {
                                string nombreDisponibleString = nombre.ToString();
                                int nombreDisponible = Convert.ToInt32(nombreDisponibleString);
                                if (vendre.supprimevente(id, idlcli, idprod, pu, qte, remise, payment, avance, reste, total))
                                {
                                    int nombreActuel = Convert.ToInt32(nombre);
                                    int nouveauNombre = nombreActuel + quantiteVente;

                                    using (var updateCommand = new MySqlCommand(updateQuery, conn.getconnection))
                                    {
                                        updateCommand.Parameters.AddWithValue("@nouveauNombre", nouveauNombre);
                                        updateCommand.Parameters.AddWithValue("@id", idProduit);
                                        updateCommand.ExecuteNonQuery();
                                    }

                                    showTable();
                                    textBox_id.Clear();
                                    textBox_pu.Clear();
                                    textBox_qte.Clear();
                                    textBox_remise.Clear();
                                    textBox_avance.Clear();
                                    textBox_reste.Clear();
                                    textBox_total.Clear();

                                    MessageBox.Show("vente supprimer", "valider", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("erreur.", "Erreur de quantité");
                            }
                        }
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


        public void showTable()
        {
            dataGridView_vente.DataSource = vendre.getVentelist();
        }

        private void supprimer_stock_Click(object sender, EventArgs e)
        {
            showTable();

            //comboBox_produit
            DataTable stockData = vendre.getDatavente(new MySqlCommand("SELECT * FROM `stock`"));
            comboBox_produit.DataSource = stockData;
            comboBox_produit.DisplayMember = "id_produit";
            comboBox_produit.ValueMember = "id_produit";

            //comboBox_client
            comboBox_client.DataSource = vendre.getDatavente(new MySqlCommand("SELECT * FROM `client`"));
            comboBox_client.DisplayMember = "idclient";
            comboBox_client.ValueMember = "idclient";

            //ajouter des valeurs sur le comboBox_payment
            comboBox_payment.Items.Add("avec avance");
            comboBox_payment.Items.Add("tout payé");

            textBox_pu.Clear();
            textBox_qte.Clear();
            textBox_remise.Clear();
            textBox_avance.Clear();
            textBox_reste.Clear();
            textBox_total.Clear();
        }

        private void comboBox_produit_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataRowView selectedRow = (DataRowView)comboBox_produit.SelectedItem;
            int idProduit = Convert.ToInt32(selectedRow["id_produit"]);

            string query = "SELECT prix_unitaire FROM stock WHERE id_produit = @id";

            {
                conn.openConnect();

                using (var command = new MySqlCommand(query, conn.getconnection))
                {
                    command.Parameters.AddWithValue("@id", idProduit);

                    var result = command.ExecuteScalar();

                    if (result != null)
                    {
                        textBox_pu.Text = result.ToString();
                    }
                    else
                    {
                        textBox_pu.Text = "Prix non disponible";
                    }
                }
            }

            string idprod = comboBox_produit.SelectedValue.ToString();
            label_nomprod.Text = "Nom du produit :  " + vendre.nomprod(idprod);
            label_modele.Text = "Modele:  " + vendre.modeleprod(idprod);
            label_couleur.Text = "couleur:  " + vendre.couleurprod(idprod);
            label7.Text = "stock:  " + vendre.stock(idprod);

        }

        private void dataGridView_vente_Click_1(object sender, EventArgs e)
        {
            textBox_id.Text = dataGridView_vente.CurrentRow.Cells[0].Value.ToString();
            comboBox_client.Text = dataGridView_vente.CurrentRow.Cells[1].Value.ToString();
            comboBox_produit.Text = dataGridView_vente.CurrentRow.Cells[2].Value.ToString();
            textBox_pu.Text = dataGridView_vente.CurrentRow.Cells[3].Value.ToString();
            textBox_qte.Text = dataGridView_vente.CurrentRow.Cells[4].Value.ToString();
            textBox_remise.Text = dataGridView_vente.CurrentRow.Cells[5].Value.ToString();
            comboBox_payment.Text = dataGridView_vente.CurrentRow.Cells[6].Value.ToString();
            textBox_avance.Text = dataGridView_vente.CurrentRow.Cells[7].Value.ToString();
            textBox_reste.Text = dataGridView_vente.CurrentRow.Cells[8].Value.ToString();
            textBox_total.Text = dataGridView_vente.CurrentRow.Cells[9].Value.ToString();
        }

        private void vente_Load_1(object sender, EventArgs e)
        {
            showTable();

            //comboBox_client
            comboBox_client.DataSource = vendre.getDatavente(new MySqlCommand("SELECT * FROM `client`"));
            comboBox_client.DisplayMember = "idclient";
            comboBox_client.ValueMember = "idclient";

            //comboBox_produit
            DataTable stockData = vendre.getDatavente(new MySqlCommand("SELECT * FROM `stock`"));
            comboBox_produit.DataSource = stockData;
            comboBox_produit.DisplayMember = "id_produit";
            comboBox_produit.ValueMember = "id_produit";


            //ajouter des valeurs sur le comboBox_payment
            comboBox_payment.Items.Add("avec avance");
            comboBox_payment.Items.Add("tout payé");

            comboBox_recherche.Items.Add("avec avance");
            comboBox_recherche.Items.Add("tout payé");


        }

        private void comboBox_client_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idCli = comboBox_client.SelectedValue.ToString();
            label_nomclient.Text = "Nom du Client :  " + vendre.nomcli(idCli);
            label_prenomcli.Text = "Prenom du client:  " + vendre.prenomcli(idCli);
            label_numcli.Text = "Numero du client:  " + vendre.numerocli(idCli);
        }

        private void id_client_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            printer.Title = "Inventaire Vente";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            //printer.HeaderCellAlignment = StringAlignment.Near;
            //printer.Footer = "fredom boutique";
            // printer.FooterSpacing = 15;
            //printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGridView_vente);
        }

        private void comboBox_recherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView_vente.DataSource = vendre.searchVente(comboBox_recherche.Text);
            comboBox_recherche.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView_vente.DataSource = vendre.searchVente2(textBox_recherche.Text);
            comboBox_recherche.ResetText();
        }

        private void modifier_stock_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string idlcli = comboBox_client.Text;
            string idprod = comboBox_produit.Text;
            string pu = textBox_pu.Text;
            string qte = textBox_qte.Text;
            string remise = textBox_remise.Text;
            string payment = comboBox_payment.Text;
            string avance = textBox_avance.Text;
            string reste = textBox_reste.Text;
            string total = textBox_total.Text;


            //--------code calcul---------------//
            // calcul total normal
            decimal prixUnitaire = decimal.Parse(textBox_pu.Text);
            int quantite = int.Parse(textBox_qte.Text);

            decimal total1 = prixUnitaire * quantite;
            textBox_total.Text = total1.ToString();
            // -----------//

            decimal totalInitial = decimal.Parse(textBox_total.Text);

            //calcul remise
            int montantInitial = int.Parse(textBox_total.Text);
            decimal pourcentageRemise = decimal.Parse(textBox_remise.Text);

            decimal montantRemise = montantInitial * (pourcentageRemise / 100);

            decimal montantApresRemise = montantInitial - montantRemise;

            //textBox_total.Text = montantApresRemise.ToString();

            textBox_total.BeginInvoke(new Action(() =>
            {
                textBox_total.Text = montantApresRemise.ToString();
            }));
            //------------//

            //avec avance//
            string selectedPayment = comboBox_payment.SelectedItem.ToString();

            if (selectedPayment == "avec avance")
            {
                // Vérification des montants saisis
                if (int.TryParse(textBox_avance.Text, out int avance1) &&
                    decimal.TryParse(textBox_total.Text, out decimal init))
                {
                    decimal reste1 = init - avance1;
                    textBox_reste.Text = reste1.ToString();
                }
                else
                {
                    MessageBox.Show("Veuillez saisir des montants valides.");
                }
            }
            else if (selectedPayment == "tout payé")
            {
                textBox_avance.Text = "0";
                textBox_reste.Text = "0";
            }
            else
            {
                // Réinitialisation des champs
                textBox_avance.Text = "";
                textBox_reste.Text = "";
            }
            //------fin code calcul---------------//

            if (verify())
            {
                DialogResult result = MessageBox.Show("Voulez-vous modifier cette vente ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int quantiteVente = Convert.ToInt32(textBox_qte.Text);
                    int idProduit = Convert.ToInt32(comboBox_produit.SelectedValue);

                    string query = "SELECT nombre FROM stock WHERE id_produit = @id";
                    string updateQuery = "UPDATE stock SET nombre = @nouveauNombre WHERE id_produit = @id";

                    {
                        conn.openConnect();
                        using (var command = new MySqlCommand(query, conn.getconnection))
                        {
                            command.Parameters.AddWithValue("@id", idProduit);

                            var nombre = command.ExecuteScalar();
                            if (nombre != null)
                            {

                                string nombreDisponibleString = nombre.ToString();

                                int nombreDisponible = Convert.ToInt32(nombreDisponibleString);
                                if (quantiteVente > nombreDisponible)
                                {

                                    MessageBox.Show("stock insuffisant.", "Erreur de quantité");
                                }
                                else
                                {
                                    if (vendre.updatevente(id,idlcli, idprod, pu, qte, remise, payment, avance, reste, total))
                                    {
                                        int nombreActuel = Convert.ToInt32(nombre);
                                        int nouveauNombre = nombreActuel - quantiteVente;

                                        using (var updateCommand = new MySqlCommand(updateQuery, conn.getconnection))
                                        {
                                            updateCommand.Parameters.AddWithValue("@nouveauNombre", nouveauNombre);
                                            updateCommand.Parameters.AddWithValue("@id", idProduit);
                                            updateCommand.ExecuteNonQuery();
                                        }

                                        showTable();
                                        textBox_pu.Clear();
                                        textBox_qte.Clear();
                                        textBox_remise.Clear();
                                        textBox_avance.Clear();
                                        textBox_reste.Clear();
                                        textBox_total.Clear();

                                        MessageBox.Show("vente modifier", "valider", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }

                            }
                            else
                            {
                                MessageBox.Show("erreur.", "Erreur de quantité");
                            }
                        }
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
            //------Fin ajout vente--------//

        }

        private void button3_Click(object sender, EventArgs e)
        {
 
                int quantiteVente = Convert.ToInt32(textBox_qte.Text);
                int idProduit = Convert.ToInt32(comboBox_produit.SelectedValue);

                string query = "SELECT nombre FROM stock WHERE id_produit = @id";
                string updateQuery = "UPDATE stock SET nombre = @nouveauNombre WHERE id_produit = @id";

                {
                    conn.openConnect();
                    using (var command = new MySqlCommand(query, conn.getconnection))
                    {
                        command.Parameters.AddWithValue("@id", idProduit);

                        var nombre = command.ExecuteScalar();
                        if (nombre != null)
                        {
                            string nombreDisponibleString = nombre.ToString();
                            int nombreDisponible = Convert.ToInt32(nombreDisponibleString);

                            int nombreActuel = Convert.ToInt32(nombre);
                            int nouveauNombre = nombreActuel + quantiteVente;

                            using (var updateCommand = new MySqlCommand(updateQuery, conn.getconnection))
                            {
                                updateCommand.Parameters.AddWithValue("@nouveauNombre", nouveauNombre);
                                updateCommand.Parameters.AddWithValue("@id", idProduit);
                                updateCommand.ExecuteNonQuery();
                            }
                            textBox_qte.Clear();
                        }
                        else
                        {
                            MessageBox.Show("erreur.", "Erreur de quantité");
                        }
                    }
                }
            }
     
        }
    }

 


