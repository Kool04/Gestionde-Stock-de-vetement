
namespace projet1
{
    partial class stock2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.bienvenue = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_recherchestock = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.Label();
            this.comboBox_rechercheStock = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_supprime2 = new System.Windows.Forms.Button();
            this.supprimer_stock = new System.Windows.Forms.Button();
            this.modifier_stock = new System.Windows.Forms.Button();
            this.textBox_prix = new System.Windows.Forms.TextBox();
            this.ajout_stock = new System.Windows.Forms.Button();
            this.textBox_couleur = new System.Windows.Forms.TextBox();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.Label();
            this.taille = new System.Windows.Forms.Label();
            this.couleur = new System.Windows.Forms.Label();
            this.prix = new System.Windows.Forms.Label();
            this.textBox_taille = new System.Windows.Forms.TextBox();
            this.textBox_modele = new System.Windows.Forms.TextBox();
            this.modele = new System.Windows.Forms.Label();
            this.textBox_produit = new System.Windows.Forms.TextBox();
            this.nom_prod = new System.Windows.Forms.Label();
            this.panel_droite = new System.Windows.Forms.Panel();
            this.dataGridView_stock = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_header.SuspendLayout();
            this.panel_droite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // panel_header
            // 
            this.panel_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_header.BackColor = System.Drawing.Color.Maroon;
            this.panel_header.Controls.Add(this.bienvenue);
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1138, 68);
            this.panel_header.TabIndex = 19;
            // 
            // bienvenue
            // 
            this.bienvenue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bienvenue.AutoSize = true;
            this.bienvenue.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bienvenue.Location = new System.Drawing.Point(480, 9);
            this.bienvenue.Name = "bienvenue";
            this.bienvenue.Size = new System.Drawing.Size(105, 45);
            this.bienvenue.TabIndex = 0;
            this.bienvenue.Text = "Stock";
            this.bienvenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_id
            // 
            this.textBox_id.ForeColor = System.Drawing.Color.White;
            this.textBox_id.Location = new System.Drawing.Point(248, 301);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(10, 22);
            this.textBox_id.TabIndex = 65;
            // 
            // textBox_recherchestock
            // 
            this.textBox_recherchestock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_recherchestock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_recherchestock.Location = new System.Drawing.Point(785, 82);
            this.textBox_recherchestock.Name = "textBox_recherchestock";
            this.textBox_recherchestock.Size = new System.Drawing.Size(147, 30);
            this.textBox_recherchestock.TabIndex = 70;
            // 
            // type
            // 
            this.type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.type.Location = new System.Drawing.Point(49, 84);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(50, 20);
            this.type.TabIndex = 69;
            this.type.Text = "Type:";
            // 
            // comboBox_rechercheStock
            // 
            this.comboBox_rechercheStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_rechercheStock.FormattingEnabled = true;
            this.comboBox_rechercheStock.Location = new System.Drawing.Point(120, 79);
            this.comboBox_rechercheStock.Name = "comboBox_rechercheStock";
            this.comboBox_rechercheStock.Size = new System.Drawing.Size(253, 33);
            this.comboBox_rechercheStock.TabIndex = 68;
            this.comboBox_rechercheStock.SelectedIndexChanged += new System.EventHandler(this.comboBox_rechercheStock_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(938, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 33);
            this.button1.TabIndex = 67;
            this.button1.Text = "Recherche";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_supprime2
            // 
            this.button_supprime2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_supprime2.BackColor = System.Drawing.Color.Red;
            this.button_supprime2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_supprime2.Location = new System.Drawing.Point(97, 626);
            this.button_supprime2.Name = "button_supprime2";
            this.button_supprime2.Size = new System.Drawing.Size(112, 38);
            this.button_supprime2.TabIndex = 104;
            this.button_supprime2.Text = "SUPPRIMER";
            this.button_supprime2.UseVisualStyleBackColor = false;
            this.button_supprime2.Click += new System.EventHandler(this.button_supprime2_Click_1);
            // 
            // supprimer_stock
            // 
            this.supprimer_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.supprimer_stock.BackColor = System.Drawing.Color.Red;
            this.supprimer_stock.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer_stock.Location = new System.Drawing.Point(169, 721);
            this.supprimer_stock.Name = "supprimer_stock";
            this.supprimer_stock.Size = new System.Drawing.Size(107, 38);
            this.supprimer_stock.TabIndex = 103;
            this.supprimer_stock.Text = "Actualiser";
            this.supprimer_stock.UseVisualStyleBackColor = false;
            this.supprimer_stock.Click += new System.EventHandler(this.supprimer_stock_Click_1);
            // 
            // modifier_stock
            // 
            this.modifier_stock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modifier_stock.BackColor = System.Drawing.Color.YellowGreen;
            this.modifier_stock.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier_stock.Location = new System.Drawing.Point(97, 582);
            this.modifier_stock.Name = "modifier_stock";
            this.modifier_stock.Size = new System.Drawing.Size(112, 38);
            this.modifier_stock.TabIndex = 102;
            this.modifier_stock.Text = "MODIFIER";
            this.modifier_stock.UseVisualStyleBackColor = false;
            this.modifier_stock.Click += new System.EventHandler(this.modifier_stock_Click_1);
            // 
            // textBox_prix
            // 
            this.textBox_prix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_prix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_prix.Location = new System.Drawing.Point(39, 240);
            this.textBox_prix.Name = "textBox_prix";
            this.textBox_prix.Size = new System.Drawing.Size(221, 27);
            this.textBox_prix.TabIndex = 98;
            // 
            // ajout_stock
            // 
            this.ajout_stock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ajout_stock.BackColor = System.Drawing.Color.Blue;
            this.ajout_stock.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajout_stock.Location = new System.Drawing.Point(97, 538);
            this.ajout_stock.Name = "ajout_stock";
            this.ajout_stock.Size = new System.Drawing.Size(112, 38);
            this.ajout_stock.TabIndex = 101;
            this.ajout_stock.Text = "AJOUTER";
            this.ajout_stock.UseVisualStyleBackColor = false;
            this.ajout_stock.Click += new System.EventHandler(this.ajout_stock_Click_1);
            // 
            // textBox_couleur
            // 
            this.textBox_couleur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_couleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_couleur.Location = new System.Drawing.Point(39, 356);
            this.textBox_couleur.Name = "textBox_couleur";
            this.textBox_couleur.Size = new System.Drawing.Size(219, 27);
            this.textBox_couleur.TabIndex = 94;
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nombre.Location = new System.Drawing.Point(39, 414);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(219, 27);
            this.textBox_nombre.TabIndex = 100;
            // 
            // nombre
            // 
            this.nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.Color.White;
            this.nombre.Location = new System.Drawing.Point(38, 386);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(91, 25);
            this.nombre.TabIndex = 99;
            this.nombre.Text = "Nombre:";
            // 
            // taille
            // 
            this.taille.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.taille.AutoSize = true;
            this.taille.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taille.ForeColor = System.Drawing.Color.White;
            this.taille.Location = new System.Drawing.Point(38, 270);
            this.taille.Name = "taille";
            this.taille.Size = new System.Drawing.Size(66, 25);
            this.taille.TabIndex = 95;
            this.taille.Text = "Taille:";
            // 
            // couleur
            // 
            this.couleur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.couleur.AutoSize = true;
            this.couleur.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.couleur.ForeColor = System.Drawing.Color.White;
            this.couleur.Location = new System.Drawing.Point(38, 328);
            this.couleur.Name = "couleur";
            this.couleur.Size = new System.Drawing.Size(86, 25);
            this.couleur.TabIndex = 93;
            this.couleur.Text = "couleur:";
            // 
            // prix
            // 
            this.prix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prix.AutoSize = true;
            this.prix.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prix.ForeColor = System.Drawing.Color.White;
            this.prix.Location = new System.Drawing.Point(38, 202);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(128, 25);
            this.prix.TabIndex = 97;
            this.prix.Text = "Prix unitaire:";
            // 
            // textBox_taille
            // 
            this.textBox_taille.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_taille.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_taille.Location = new System.Drawing.Point(39, 298);
            this.textBox_taille.Name = "textBox_taille";
            this.textBox_taille.Size = new System.Drawing.Size(221, 27);
            this.textBox_taille.TabIndex = 96;
            // 
            // textBox_modele
            // 
            this.textBox_modele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_modele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_modele.Location = new System.Drawing.Point(39, 172);
            this.textBox_modele.Name = "textBox_modele";
            this.textBox_modele.Size = new System.Drawing.Size(219, 27);
            this.textBox_modele.TabIndex = 92;
            // 
            // modele
            // 
            this.modele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modele.AutoSize = true;
            this.modele.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modele.ForeColor = System.Drawing.Color.White;
            this.modele.Location = new System.Drawing.Point(38, 135);
            this.modele.Name = "modele";
            this.modele.Size = new System.Drawing.Size(86, 25);
            this.modele.TabIndex = 91;
            this.modele.Text = "Modele:";
            // 
            // textBox_produit
            // 
            this.textBox_produit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_produit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox_produit.Location = new System.Drawing.Point(39, 105);
            this.textBox_produit.Name = "textBox_produit";
            this.textBox_produit.Size = new System.Drawing.Size(219, 27);
            this.textBox_produit.TabIndex = 90;
            // 
            // nom_prod
            // 
            this.nom_prod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nom_prod.AutoSize = true;
            this.nom_prod.BackColor = System.Drawing.Color.Transparent;
            this.nom_prod.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_prod.ForeColor = System.Drawing.Color.White;
            this.nom_prod.Location = new System.Drawing.Point(34, 66);
            this.nom_prod.Name = "nom_prod";
            this.nom_prod.Size = new System.Drawing.Size(132, 25);
            this.nom_prod.TabIndex = 89;
            this.nom_prod.Text = "Nom produit:";
            // 
            // panel_droite
            // 
            this.panel_droite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_droite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel_droite.Controls.Add(this.supprimer_stock);
            this.panel_droite.Controls.Add(this.button_supprime2);
            this.panel_droite.Controls.Add(this.textBox_produit);
            this.panel_droite.Controls.Add(this.modifier_stock);
            this.panel_droite.Controls.Add(this.nom_prod);
            this.panel_droite.Controls.Add(this.ajout_stock);
            this.panel_droite.Controls.Add(this.textBox_prix);
            this.panel_droite.Controls.Add(this.textBox_nombre);
            this.panel_droite.Controls.Add(this.textBox_id);
            this.panel_droite.Controls.Add(this.nombre);
            this.panel_droite.Controls.Add(this.textBox_couleur);
            this.panel_droite.Controls.Add(this.textBox_modele);
            this.panel_droite.Controls.Add(this.modele);
            this.panel_droite.Controls.Add(this.couleur);
            this.panel_droite.Controls.Add(this.prix);
            this.panel_droite.Controls.Add(this.taille);
            this.panel_droite.Controls.Add(this.textBox_taille);
            this.panel_droite.Location = new System.Drawing.Point(1138, 0);
            this.panel_droite.Name = "panel_droite";
            this.panel_droite.Size = new System.Drawing.Size(302, 786);
            this.panel_droite.TabIndex = 74;
            // 
            // dataGridView_stock
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_stock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_stock.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_stock.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_stock.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView_stock.Location = new System.Drawing.Point(0, 124);
            this.dataGridView_stock.Name = "dataGridView_stock";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_stock.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_stock.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridView_stock.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView_stock.RowTemplate.Height = 40;
            this.dataGridView_stock.Size = new System.Drawing.Size(1138, 602);
            this.dataGridView_stock.TabIndex = 75;
            this.dataGridView_stock.Click += new System.EventHandler(this.dataGridView_stock_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(434, 732);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(317, 48);
            this.button2.TabIndex = 76;
            this.button2.Text = "imprimer inventaire Stock";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // stock2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 788);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView_stock);
            this.Controls.Add(this.panel_droite);
            this.Controls.Add(this.textBox_recherchestock);
            this.Controls.Add(this.type);
            this.Controls.Add(this.comboBox_rechercheStock);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "stock2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "stock2";
            this.Load += new System.EventHandler(this.stock2_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel_droite.ResumeLayout(false);
            this.panel_droite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label bienvenue;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_recherchestock;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.ComboBox comboBox_rechercheStock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_supprime2;
        private System.Windows.Forms.Button modifier_stock;
        private System.Windows.Forms.TextBox textBox_prix;
        private System.Windows.Forms.Button ajout_stock;
        private System.Windows.Forms.TextBox textBox_couleur;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label taille;
        private System.Windows.Forms.Label couleur;
        private System.Windows.Forms.Label prix;
        private System.Windows.Forms.TextBox textBox_taille;
        private System.Windows.Forms.TextBox textBox_modele;
        private System.Windows.Forms.Label modele;
        private System.Windows.Forms.TextBox textBox_produit;
        private System.Windows.Forms.Label nom_prod;
        private System.Windows.Forms.Button supprimer_stock;
        private System.Windows.Forms.Panel panel_droite;
        private System.Windows.Forms.DataGridView dataGridView_stock;
        private System.Windows.Forms.Button button2;
    }
}