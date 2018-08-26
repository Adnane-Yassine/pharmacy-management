namespace Gestion_Pharmacie_V3.Presentations.Admin
{
    partial class F_ListeProduits
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ListeProduits));
            this.Btn_Rechercher = new System.Windows.Forms.Button();
            this.Grid_Produit = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.T_NamePro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.T_MAJ = new System.Windows.Forms.TextBox();
            this.Btn_ValiderMAJ = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Rd_Supprimer = new System.Windows.Forms.RadioButton();
            this.Rd_Modifier = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.T_RechercherProduit = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rd_Desactives = new System.Windows.Forms.RadioButton();
            this.Rd_Actifs = new System.Windows.Forms.RadioButton();
            this.Rd_Tous = new System.Windows.Forms.RadioButton();
            this.Rd_Libelle = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rd_Code = new System.Windows.Forms.RadioButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichierDeBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Produit)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Rechercher
            // 
            this.Btn_Rechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Rechercher.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Btn_Rechercher.Location = new System.Drawing.Point(398, 58);
            this.Btn_Rechercher.Name = "Btn_Rechercher";
            this.Btn_Rechercher.Size = new System.Drawing.Size(177, 36);
            this.Btn_Rechercher.TabIndex = 9;
            this.Btn_Rechercher.Text = "Rechercher";
            this.Btn_Rechercher.UseVisualStyleBackColor = true;
            this.Btn_Rechercher.Click += new System.EventHandler(this.Btn_Rechercher_Click);
            // 
            // Grid_Produit
            // 
            this.Grid_Produit.AllowUserToAddRows = false;
            this.Grid_Produit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Produit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.Grid_Produit.Location = new System.Drawing.Point(14, 187);
            this.Grid_Produit.Name = "Grid_Produit";
            this.Grid_Produit.Size = new System.Drawing.Size(1345, 275);
            this.Grid_Produit.TabIndex = 10;
            this.Grid_Produit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Produit_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ProduitID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CodeBarre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Designation";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix d\'Achat";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Prix de Vente";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Form Produit";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Categorie";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "FamTarif";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Produit Actif";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Qte Stock";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Laboratoire";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Grossiste";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = false;
            this.Column13.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column13.HeaderText = "CHECK";
            this.Column13.Name = "Column13";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.Grid_Produit);
            this.groupBox2.Location = new System.Drawing.Point(21, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1378, 486);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.T_NamePro);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.T_MAJ);
            this.groupBox4.Controls.Add(this.Btn_ValiderMAJ);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(646, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(690, 136);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "MAJ Produit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(292, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nom Produit ";
            // 
            // T_NamePro
            // 
            this.T_NamePro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_NamePro.Location = new System.Drawing.Point(441, 64);
            this.T_NamePro.Name = "T_NamePro";
            this.T_NamePro.ReadOnly = true;
            this.T_NamePro.Size = new System.Drawing.Size(220, 26);
            this.T_NamePro.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(292, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Code Produit ";
            // 
            // T_MAJ
            // 
            this.T_MAJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_MAJ.Location = new System.Drawing.Point(441, 30);
            this.T_MAJ.Name = "T_MAJ";
            this.T_MAJ.ReadOnly = true;
            this.T_MAJ.Size = new System.Drawing.Size(220, 26);
            this.T_MAJ.TabIndex = 18;
            // 
            // Btn_ValiderMAJ
            // 
            this.Btn_ValiderMAJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ValiderMAJ.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Btn_ValiderMAJ.Location = new System.Drawing.Point(462, 94);
            this.Btn_ValiderMAJ.Name = "Btn_ValiderMAJ";
            this.Btn_ValiderMAJ.Size = new System.Drawing.Size(177, 36);
            this.Btn_ValiderMAJ.TabIndex = 13;
            this.Btn_ValiderMAJ.Text = "Valider";
            this.Btn_ValiderMAJ.UseVisualStyleBackColor = true;
            this.Btn_ValiderMAJ.Click += new System.EventHandler(this.Btn_ValiderMAJ_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Rd_Supprimer);
            this.groupBox6.Controls.Add(this.Rd_Modifier);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(15, 42);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(261, 59);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            // 
            // Rd_Supprimer
            // 
            this.Rd_Supprimer.AutoSize = true;
            this.Rd_Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rd_Supprimer.Location = new System.Drawing.Point(129, 22);
            this.Rd_Supprimer.Name = "Rd_Supprimer";
            this.Rd_Supprimer.Size = new System.Drawing.Size(128, 29);
            this.Rd_Supprimer.TabIndex = 2;
            this.Rd_Supprimer.Text = "Supprimer";
            this.Rd_Supprimer.UseVisualStyleBackColor = true;
            // 
            // Rd_Modifier
            // 
            this.Rd_Modifier.AutoSize = true;
            this.Rd_Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rd_Modifier.Location = new System.Drawing.Point(18, 22);
            this.Rd_Modifier.Name = "Rd_Modifier";
            this.Rd_Modifier.Size = new System.Drawing.Size(107, 29);
            this.Rd_Modifier.TabIndex = 1;
            this.Rd_Modifier.Text = "Modifier";
            this.Rd_Modifier.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.T_RechercherProduit);
            this.groupBox5.Controls.Add(this.Btn_Rechercher);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(14, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(611, 148);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Taper Produit ( Nom / Code Produit )";
            // 
            // T_RechercherProduit
            // 
            this.T_RechercherProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_RechercherProduit.Location = new System.Drawing.Point(373, 26);
            this.T_RechercherProduit.Name = "T_RechercherProduit";
            this.T_RechercherProduit.Size = new System.Drawing.Size(220, 26);
            this.T_RechercherProduit.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rd_Desactives);
            this.groupBox3.Controls.Add(this.Rd_Actifs);
            this.groupBox3.Controls.Add(this.Rd_Tous);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(667, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 85);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Produits Actifs";
            // 
            // rd_Desactives
            // 
            this.rd_Desactives.AutoSize = true;
            this.rd_Desactives.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_Desactives.Location = new System.Drawing.Point(211, 39);
            this.rd_Desactives.Name = "rd_Desactives";
            this.rd_Desactives.Size = new System.Drawing.Size(136, 29);
            this.rd_Desactives.TabIndex = 2;
            this.rd_Desactives.Text = "Désactivés";
            this.rd_Desactives.UseVisualStyleBackColor = true;
            // 
            // Rd_Actifs
            // 
            this.Rd_Actifs.AutoSize = true;
            this.Rd_Actifs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rd_Actifs.Location = new System.Drawing.Point(113, 39);
            this.Rd_Actifs.Name = "Rd_Actifs";
            this.Rd_Actifs.Size = new System.Drawing.Size(83, 29);
            this.Rd_Actifs.TabIndex = 1;
            this.Rd_Actifs.Text = "Actifs";
            this.Rd_Actifs.UseVisualStyleBackColor = true;
            // 
            // Rd_Tous
            // 
            this.Rd_Tous.AutoSize = true;
            this.Rd_Tous.Checked = true;
            this.Rd_Tous.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rd_Tous.Location = new System.Drawing.Point(16, 39);
            this.Rd_Tous.Name = "Rd_Tous";
            this.Rd_Tous.Size = new System.Drawing.Size(78, 29);
            this.Rd_Tous.TabIndex = 0;
            this.Rd_Tous.TabStop = true;
            this.Rd_Tous.Text = "Tous";
            this.Rd_Tous.UseVisualStyleBackColor = true;
            // 
            // Rd_Libelle
            // 
            this.Rd_Libelle.AutoSize = true;
            this.Rd_Libelle.Checked = true;
            this.Rd_Libelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rd_Libelle.Location = new System.Drawing.Point(190, 39);
            this.Rd_Libelle.Name = "Rd_Libelle";
            this.Rd_Libelle.Size = new System.Drawing.Size(93, 29);
            this.Rd_Libelle.TabIndex = 2;
            this.Rd_Libelle.TabStop = true;
            this.Rd_Libelle.Text = "Libellé";
            this.Rd_Libelle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rd_Libelle);
            this.groupBox1.Controls.Add(this.Rd_Code);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(21, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 85);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher Par";
            // 
            // Rd_Code
            // 
            this.Rd_Code.AutoSize = true;
            this.Rd_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rd_Code.Location = new System.Drawing.Point(31, 39);
            this.Rd_Code.Name = "Rd_Code";
            this.Rd_Code.Size = new System.Drawing.Size(81, 29);
            this.Rd_Code.TabIndex = 1;
            this.Rd_Code.Text = "Code";
            this.Rd_Code.UseVisualStyleBackColor = true;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 29);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 29);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quitterToolStripMenuItem.Image")));
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modifierToolStripMenuItem.Image")));
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(179, 29);
            this.modifierToolStripMenuItem.Text = "Modifier Produit";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ajouterToolStripMenuItem.Image")));
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(169, 29);
            this.ajouterToolStripMenuItem.Text = "Ajouter Produit";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // fichierDeBaseToolStripMenuItem
            // 
            this.fichierDeBaseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fichierDeBaseToolStripMenuItem.Image")));
            this.fichierDeBaseToolStripMenuItem.Name = "fichierDeBaseToolStripMenuItem";
            this.fichierDeBaseToolStripMenuItem.Size = new System.Drawing.Size(166, 29);
            this.fichierDeBaseToolStripMenuItem.Text = "Fichier de Base";
            // 
            // menuToolStripMenuItem1
            // 
            this.menuToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("menuToolStripMenuItem1.Image")));
            this.menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            this.menuToolStripMenuItem1.Size = new System.Drawing.Size(89, 29);
            this.menuToolStripMenuItem1.Text = "Menu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem1,
            this.fichierDeBaseToolStripMenuItem,
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1405, 33);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // F_ListeProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1405, 628);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "F_ListeProduits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ListeProduitsAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Produit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Rechercher;
        private System.Windows.Forms.DataGridView Grid_Produit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox T_RechercherProduit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rd_Desactives;
        private System.Windows.Forms.RadioButton Rd_Actifs;
        private System.Windows.Forms.RadioButton Rd_Tous;
        private System.Windows.Forms.RadioButton Rd_Libelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rd_Code;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichierDeBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton Rd_Supprimer;
        private System.Windows.Forms.RadioButton Rd_Modifier;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Btn_ValiderMAJ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox T_MAJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox T_NamePro;
    }
}