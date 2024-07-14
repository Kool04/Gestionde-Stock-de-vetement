using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing.Printing;

namespace projet1
{
    public partial class pdf : Form
    {
        ajout_vente vendre = new ajout_vente();
        ajout_pdf imprim = new ajout_pdf();
        public pdf()
        {
            InitializeComponent();
        }

        private void pdf_Load(object sender, EventArgs e)
        {
            showTable();
        }

        public void showTable()
        {
            dataGridView_vente.DataSource = vendre.getVentelist();
        }

        private void dataGridView_vente_Click_1(object sender, EventArgs e)
        {
            label_idfacture.Text = "Facture N*:" + dataGridView_vente.CurrentRow.Cells[0].Value.ToString();
            label_idclient.Text = "ID Client:" + dataGridView_vente.CurrentRow.Cells[1].Value.ToString();
            label_idproduit.Text = "Designation:" + dataGridView_vente.CurrentRow.Cells[2].Value.ToString();
            label_pu.Text = "Prix unitaire:" + dataGridView_vente.CurrentRow.Cells[3].Value.ToString();
            label_quantite.Text = "Quantite:" + dataGridView_vente.CurrentRow.Cells[4].Value.ToString();
            label_remise.Text = "Remise:" + dataGridView_vente.CurrentRow.Cells[5].Value.ToString() + "%";
            label_payment.Text = "Type de payment:" + dataGridView_vente.CurrentRow.Cells[6].Value.ToString();
            label_paye.Text = "Paye:" + dataGridView_vente.CurrentRow.Cells[7].Value.ToString() + "AR";
            label_reste.Text = "Reste a payer:" + dataGridView_vente.CurrentRow.Cells[8].Value.ToString() + "AR";
            label_total.Text = "Total HT:" + dataGridView_vente.CurrentRow.Cells[9].Value.ToString() + "AR";
            label_date.Text = "Date:" + dataGridView_vente.CurrentRow.Cells[10].Value.ToString();

        // Iformations momban'i Client
            string idCli = dataGridView_vente.CurrentRow.Cells[1].Value.ToString();
            label_nomcli.Text = "Nom :  " + imprim.nomcli(idCli);
            label_prenomcli.Text = "Prenom:  " + imprim.prenomcli(idCli);
            label_numerocli.Text = "Numero:  " + imprim.numerocli(idCli);
        //---------//

        //informations mombanle article:
            string idprod= dataGridView_vente.CurrentRow.Cells[2].Value.ToString();
            label_nomproduit.Text = "Nom de l'article:" + imprim.nomprod(idprod);
            label_modele.Text = "Modele:" + imprim.modeleprod(idprod);
            label_couleur.Text = "Couleur:" + imprim.couleurprod(idprod);
        //----------//
        }

        private void ExportToPDF(Panel panel)
        {
            Document document = new Document();

           
            string outputPath = "C:/Users/KOOL/OneDrive/Bureau/c#/fichier.pdf"; 
            using (FileStream fs = new FileStream(outputPath, FileMode.Create))
            {
                PdfWriter writer = PdfWriter.GetInstance(document, fs);

                
                document.Open();

               
                using (Bitmap bitmap = new Bitmap(panel.Width, panel.Height))
                {
                    panel.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, panel.Width, panel.Height));

                    
                    iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(bitmap, System.Drawing.Imaging.ImageFormat.Bmp);

                    
                    document.Add(image);
                }

               
                document.Close();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous exporter en pdf ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ExportToPDF(panel_pdf);
                MessageBox.Show("succes", "valider", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                // Ne rien faire
            }
        }

       
    }
}
