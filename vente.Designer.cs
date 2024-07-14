
namespace projet1
{
    partial class vente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.supprime_vente = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.modifier_stock = new System.Windows.Forms.Button();
            this.textBox_qte = new System.Windows.Forms.TextBox();
            this.ajout_vente = new System.Windows.Forms.Button();
            this.taille = new System.Windows.Forms.Label();
            this.prix = new System.Windows.Forms.Label();
            this.textBox_pu = new System.Windows.Forms.TextBox();
            this.modele = new System.Windows.Forms.Label();
            this.id_client = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.bienvenue = new System.Windows.Forms.Label();
            this.supprimer_stock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_client = new System.Windows.Forms.ComboBox();
            this.comboBox_produit = new System.Windows.Forms.ComboBox();
            this.idproduit = new System.Windows.Forms.Label();
            this.textBox_remise = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_payment = new System.Windows.Forms.ComboBox();
            this.textBox_avance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_reste = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_droite = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView_vente = new System.Windows.Forms.DataGridView();
            this.panel_info = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label_couleur = new System.Windows.Forms.Label();
            this.label_modele = new System.Windows.Forms.Label();
            this.label_nomprod = new System.Windows.Forms.Label();
            this.label_numcli = new System.Windows.Forms.Label();
            this.label_prenomcli = new System.Windows.Forms.Label();
            this.label_nomclient = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.comboBox_recherche = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_recherche = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_header.SuspendLayout();
            this.panel_droite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_vente)).BeginInit();
            this.panel_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // supprime_vente
            // 
            this.supprime_vente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.supprime_vente.BackColor = System.Drawing.Color.Red;
            this.supprime_vente.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprime_vente.Location = new System.Drawing.Point(94, 699);
            this.supprime_vente.Name = "supprime_vente";
            this.supprime_vente.Size = new System.Drawing.Size(128, 35);
            this.supprime_vente.TabIndex = 69;
            this.supprime_vente.Text = "SUPPRIMER";
            this.supprime_vente.UseVisualStyleBackColor = false;
            this.supprime_vente.Click += new System.EventHandler(this.supprime_vente_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.ForeColor = System.Drawing.Color.White;
            this.textBox_id.Location = new System.Drawing.Point(226, 446);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(18, 22);
            this.textBox_id.TabIndex = 64;
            // 
            // modifier_stock
            // 
            this.modifier_stock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modifier_stock.BackColor = System.Drawing.Color.YellowGreen;
            this.modifier_stock.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier_stock.Location = new System.Drawing.Point(94, 658);
            this.modifier_stock.Name = "modifier_stock";
            this.modifier_stock.Size = new System.Drawing.Size(128, 35);
            this.modifier_stock.TabIndex = 63;
            this.modifier_stock.Text = "MODIFIER";
            this.modifier_stock.UseVisualStyleBackColor = false;
            this.modifier_stock.Click += new System.EventHandler(this.modifier_stock_Click);
            // 
            // textBox_qte
            // 
            this.textBox_qte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_qte.Location = new System.Drawing.Point(75, 259);
            this.textBox_qte.Name = "textBox_qte";
            this.textBox_qte.Size = new System.Drawing.Size(169, 27);
            this.textBox_qte.TabIndex = 61;
            // 
            // ajout_vente
            // 
            this.ajout_vente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ajout_vente.BackColor = System.Drawing.Color.Blue;
            this.ajout_vente.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajout_vente.Location = new System.Drawing.Point(94, 617);
            this.ajout_vente.Name = "ajout_vente";
            this.ajout_vente.Size = new System.Drawing.Size(128, 35);
            this.ajout_vente.TabIndex = 62;
            this.ajout_vente.Text = "AJOUTER";
            this.ajout_vente.UseVisualStyleBackColor = false;
            this.ajout_vente.Click += new System.EventHandler(this.ajout_vente_Click);
            // 
            // taille
            // 
            this.taille.AutoSize = true;
            this.taille.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taille.ForeColor = System.Drawing.Color.White;
            this.taille.Location = new System.Drawing.Point(70, 356);
            this.taille.Name = "taille";
            this.taille.Size = new System.Drawing.Size(99, 25);
            this.taille.TabIndex = 58;
            this.taille.Text = "Payment:";
            // 
            // prix
            // 
            this.prix.AutoSize = true;
            this.prix.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prix.ForeColor = System.Drawing.Color.White;
            this.prix.Location = new System.Drawing.Point(71, 231);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(98, 25);
            this.prix.TabIndex = 60;
            this.prix.Text = "Quantite:";
            // 
            // textBox_pu
            // 
            this.textBox_pu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pu.Location = new System.Drawing.Point(76, 192);
            this.textBox_pu.Name = "textBox_pu";
            this.textBox_pu.Size = new System.Drawing.Size(168, 27);
            this.textBox_pu.TabIndex = 57;
            // 
            // modele
            // 
            this.modele.AutoSize = true;
            this.modele.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modele.ForeColor = System.Drawing.Color.White;
            this.modele.Location = new System.Drawing.Point(68, 164);
            this.modele.Name = "modele";
            this.modele.Size = new System.Drawing.Size(128, 25);
            this.modele.TabIndex = 56;
            this.modele.Text = "Prix unitaire:";
            // 
            // id_client
            // 
            this.id_client.AutoSize = true;
            this.id_client.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_client.ForeColor = System.Drawing.Color.White;
            this.id_client.Location = new System.Drawing.Point(69, 26);
            this.id_client.Name = "id_client";
            this.id_client.Size = new System.Drawing.Size(98, 25);
            this.id_client.TabIndex = 54;
            this.id_client.Text = "ID Client:";
            this.id_client.Click += new System.EventHandler(this.id_client_Click);
            // 
            // panel_header
            // 
            this.panel_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_header.BackColor = System.Drawing.Color.Maroon;
            this.panel_header.Controls.Add(this.bienvenue);
            this.panel_header.Location = new System.Drawing.Point(2, 3);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1146, 68);
            this.panel_header.TabIndex = 66;
            // 
            // bienvenue
            // 
            this.bienvenue.AutoSize = true;
            this.bienvenue.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bienvenue.Location = new System.Drawing.Point(522, 9);
            this.bienvenue.Name = "bienvenue";
            this.bienvenue.Size = new System.Drawing.Size(109, 45);
            this.bienvenue.TabIndex = 0;
            this.bienvenue.Text = "Vente";
            this.bienvenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // supprimer_stock
            // 
            this.supprimer_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.supprimer_stock.BackColor = System.Drawing.Color.Red;
            this.supprimer_stock.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer_stock.Location = new System.Drawing.Point(207, 740);
            this.supprimer_stock.Name = "supprimer_stock";
            this.supprimer_stock.Size = new System.Drawing.Size(86, 33);
            this.supprimer_stock.TabIndex = 65;
            this.supprimer_stock.Text = "Actualiser";
            this.supprimer_stock.UseVisualStyleBackColor = false;
            this.supprimer_stock.Click += new System.EventHandler(this.supprimer_stock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-27, -46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "label1";
            // 
            // comboBox_client
            // 
            this.comboBox_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_client.FormattingEnabled = true;
            this.comboBox_client.Location = new System.Drawing.Point(76, 54);
            this.comboBox_client.Name = "comboBox_client";
            this.comboBox_client.Size = new System.Drawing.Size(84, 28);
            this.comboBox_client.TabIndex = 70;
            this.comboBox_client.SelectedIndexChanged += new System.EventHandler(this.comboBox_client_SelectedIndexChanged);
            // 
            // comboBox_produit
            // 
            this.comboBox_produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_produit.FormattingEnabled = true;
            this.comboBox_produit.Location = new System.Drawing.Point(76, 125);
            this.comboBox_produit.Name = "comboBox_produit";
            this.comboBox_produit.Size = new System.Drawing.Size(84, 28);
            this.comboBox_produit.TabIndex = 72;
            this.comboBox_produit.SelectedIndexChanged += new System.EventHandler(this.comboBox_produit_SelectedIndexChanged);
            // 
            // idproduit
            // 
            this.idproduit.AutoSize = true;
            this.idproduit.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idproduit.ForeColor = System.Drawing.Color.White;
            this.idproduit.Location = new System.Drawing.Point(71, 97);
            this.idproduit.Name = "idproduit";
            this.idproduit.Size = new System.Drawing.Size(140, 25);
            this.idproduit.TabIndex = 71;
            this.idproduit.Text = "ID du Produit:";
            // 
            // textBox_remise
            // 
            this.textBox_remise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_remise.Location = new System.Drawing.Point(75, 326);
            this.textBox_remise.Name = "textBox_remise";
            this.textBox_remise.Size = new System.Drawing.Size(169, 27);
            this.textBox_remise.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 73;
            this.label2.Text = "Remise:";
            // 
            // comboBox_payment
            // 
            this.comboBox_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_payment.FormattingEnabled = true;
            this.comboBox_payment.Location = new System.Drawing.Point(75, 384);
            this.comboBox_payment.Name = "comboBox_payment";
            this.comboBox_payment.Size = new System.Drawing.Size(169, 28);
            this.comboBox_payment.TabIndex = 75;
            // 
            // textBox_avance
            // 
            this.textBox_avance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_avance.Location = new System.Drawing.Point(74, 443);
            this.textBox_avance.Name = "textBox_avance";
            this.textBox_avance.Size = new System.Drawing.Size(170, 27);
            this.textBox_avance.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 76;
            this.label3.Text = "Avance:";
            // 
            // textBox_reste
            // 
            this.textBox_reste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_reste.Location = new System.Drawing.Point(75, 510);
            this.textBox_reste.Name = "textBox_reste";
            this.textBox_reste.Size = new System.Drawing.Size(169, 27);
            this.textBox_reste.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(70, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 78;
            this.label4.Text = "Reste:";
            // 
            // textBox_total
            // 
            this.textBox_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_total.Location = new System.Drawing.Point(75, 579);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.Size = new System.Drawing.Size(169, 27);
            this.textBox_total.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(70, 551);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 80;
            this.label5.Text = "Total:";
            // 
            // panel_droite
            // 
            this.panel_droite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_droite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel_droite.Controls.Add(this.button3);
            this.panel_droite.Controls.Add(this.comboBox_client);
            this.panel_droite.Controls.Add(this.textBox_id);
            this.panel_droite.Controls.Add(this.supprime_vente);
            this.panel_droite.Controls.Add(this.textBox_total);
            this.panel_droite.Controls.Add(this.label5);
            this.panel_droite.Controls.Add(this.modifier_stock);
            this.panel_droite.Controls.Add(this.supprimer_stock);
            this.panel_droite.Controls.Add(this.id_client);
            this.panel_droite.Controls.Add(this.ajout_vente);
            this.panel_droite.Controls.Add(this.comboBox_produit);
            this.panel_droite.Controls.Add(this.textBox_reste);
            this.panel_droite.Controls.Add(this.label4);
            this.panel_droite.Controls.Add(this.idproduit);
            this.panel_droite.Controls.Add(this.textBox_pu);
            this.panel_droite.Controls.Add(this.textBox_avance);
            this.panel_droite.Controls.Add(this.label3);
            this.panel_droite.Controls.Add(this.modele);
            this.panel_droite.Controls.Add(this.textBox_qte);
            this.panel_droite.Controls.Add(this.comboBox_payment);
            this.panel_droite.Controls.Add(this.prix);
            this.panel_droite.Controls.Add(this.textBox_remise);
            this.panel_droite.Controls.Add(this.label2);
            this.panel_droite.Controls.Add(this.taille);
            this.panel_droite.Location = new System.Drawing.Point(1145, 3);
            this.panel_droite.Name = "panel_droite";
            this.panel_droite.Size = new System.Drawing.Size(307, 786);
            this.panel_droite.TabIndex = 82;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.Location = new System.Drawing.Point(14, 747);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 27);
            this.button3.TabIndex = 82;
            this.button3.Text = "modifier pu";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView_vente
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_vente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_vente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_vente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_vente.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_vente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_vente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_vente.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_vente.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView_vente.Location = new System.Drawing.Point(2, 128);
            this.dataGridView_vente.Name = "dataGridView_vente";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_vente.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_vente.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridView_vente.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_vente.RowTemplate.Height = 40;
            this.dataGridView_vente.Size = new System.Drawing.Size(1137, 527);
            this.dataGridView_vente.TabIndex = 83;
            this.dataGridView_vente.Click += new System.EventHandler(this.dataGridView_vente_Click_1);
            // 
            // panel_info
            // 
            this.panel_info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_info.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_info.Controls.Add(this.label7);
            this.panel_info.Controls.Add(this.button2);
            this.panel_info.Controls.Add(this.label_couleur);
            this.panel_info.Controls.Add(this.label_modele);
            this.panel_info.Controls.Add(this.label_nomprod);
            this.panel_info.Controls.Add(this.label_numcli);
            this.panel_info.Controls.Add(this.label_prenomcli);
            this.panel_info.Controls.Add(this.label_nomclient);
            this.panel_info.Location = new System.Drawing.Point(2, 661);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(1137, 128);
            this.panel_info.TabIndex = 84;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(924, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 35);
            this.button2.TabIndex = 85;
            this.button2.Text = "imprimer inventaire vente";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_couleur
            // 
            this.label_couleur.AutoSize = true;
            this.label_couleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_couleur.ForeColor = System.Drawing.Color.Black;
            this.label_couleur.Location = new System.Drawing.Point(568, 89);
            this.label_couleur.Name = "label_couleur";
            this.label_couleur.Size = new System.Drawing.Size(80, 20);
            this.label_couleur.TabIndex = 5;
            this.label_couleur.Text = "Couleur:";
            // 
            // label_modele
            // 
            this.label_modele.AutoSize = true;
            this.label_modele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_modele.ForeColor = System.Drawing.Color.Black;
            this.label_modele.Location = new System.Drawing.Point(573, 59);
            this.label_modele.Name = "label_modele";
            this.label_modele.Size = new System.Drawing.Size(75, 20);
            this.label_modele.TabIndex = 4;
            this.label_modele.Text = "Modele:";
            // 
            // label_nomprod
            // 
            this.label_nomprod.AutoSize = true;
            this.label_nomprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nomprod.ForeColor = System.Drawing.Color.Black;
            this.label_nomprod.Location = new System.Drawing.Point(505, 30);
            this.label_nomprod.Name = "label_nomprod";
            this.label_nomprod.Size = new System.Drawing.Size(143, 20);
            this.label_nomprod.TabIndex = 3;
            this.label_nomprod.Text = "Nom du produit:";
            // 
            // label_numcli
            // 
            this.label_numcli.AutoSize = true;
            this.label_numcli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numcli.ForeColor = System.Drawing.Color.Black;
            this.label_numcli.Location = new System.Drawing.Point(49, 89);
            this.label_numcli.Name = "label_numcli";
            this.label_numcli.Size = new System.Drawing.Size(158, 20);
            this.label_numcli.TabIndex = 2;
            this.label_numcli.Text = "Numero du client:";
            // 
            // label_prenomcli
            // 
            this.label_prenomcli.AutoSize = true;
            this.label_prenomcli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prenomcli.ForeColor = System.Drawing.Color.Black;
            this.label_prenomcli.Location = new System.Drawing.Point(50, 59);
            this.label_prenomcli.Name = "label_prenomcli";
            this.label_prenomcli.Size = new System.Drawing.Size(157, 20);
            this.label_prenomcli.TabIndex = 1;
            this.label_prenomcli.Text = "Prenom du client:";
            // 
            // label_nomclient
            // 
            this.label_nomclient.AutoSize = true;
            this.label_nomclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nomclient.ForeColor = System.Drawing.Color.Black;
            this.label_nomclient.Location = new System.Drawing.Point(74, 30);
            this.label_nomclient.Name = "label_nomclient";
            this.label_nomclient.Size = new System.Drawing.Size(131, 20);
            this.label_nomclient.TabIndex = 0;
            this.label_nomclient.Text = "Nom du client:";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // comboBox_recherche
            // 
            this.comboBox_recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_recherche.FormattingEnabled = true;
            this.comboBox_recherche.Location = new System.Drawing.Point(127, 82);
            this.comboBox_recherche.Name = "comboBox_recherche";
            this.comboBox_recherche.Size = new System.Drawing.Size(121, 33);
            this.comboBox_recherche.TabIndex = 85;
            this.comboBox_recherche.SelectedIndexChanged += new System.EventHandler(this.comboBox_recherche_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 86;
            this.label6.Text = "Payment:";
            // 
            // textBox_recherche
            // 
            this.textBox_recherche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_recherche.Location = new System.Drawing.Point(904, 85);
            this.textBox_recherche.Name = "textBox_recherche";
            this.textBox_recherche.Size = new System.Drawing.Size(103, 27);
            this.textBox_recherche.TabIndex = 87;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1024, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 33);
            this.button1.TabIndex = 88;
            this.button1.Text = "recherche";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(818, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 86;
            this.label7.Text = "stock:";
            // 
            // vente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 788);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_recherche);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_recherche);
            this.Controls.Add(this.panel_info);
            this.Controls.Add(this.dataGridView_vente);
            this.Controls.Add(this.panel_droite);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "vente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+";
            this.Load += new System.EventHandler(this.vente_Load_1);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel_droite.ResumeLayout(false);
            this.panel_droite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_vente)).EndInit();
            this.panel_info.ResumeLayout(false);
            this.panel_info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button supprime_vente;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Button modifier_stock;
        private System.Windows.Forms.TextBox textBox_qte;
        private System.Windows.Forms.Button ajout_vente;
        private System.Windows.Forms.Label taille;
        private System.Windows.Forms.Label prix;
        private System.Windows.Forms.TextBox textBox_pu;
        private System.Windows.Forms.Label modele;
        private System.Windows.Forms.Label id_client;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label bienvenue;
        private System.Windows.Forms.Button supprimer_stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_client;
        private System.Windows.Forms.ComboBox comboBox_produit;
        private System.Windows.Forms.Label idproduit;
        private System.Windows.Forms.TextBox textBox_remise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_payment;
        private System.Windows.Forms.TextBox textBox_avance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_reste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_droite;
        private System.Windows.Forms.DataGridView dataGridView_vente;
        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.Label label_numcli;
        private System.Windows.Forms.Label label_prenomcli;
        private System.Windows.Forms.Label label_nomclient;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label_couleur;
        private System.Windows.Forms.Label label_modele;
        private System.Windows.Forms.Label label_nomprod;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox_recherche;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_recherche;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
    }
}