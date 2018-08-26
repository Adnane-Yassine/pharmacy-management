namespace Gestion_Pharmacie_V3.Presentations.F_Utilisateur
{
    partial class F_FichierBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_FichierBase));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Btn_Produit = new System.Windows.Forms.Button();
            this.Btn_CodeABarre = new System.Windows.Forms.Button();
            this.Btn_Parametre = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(240)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fichiers de Base";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 107);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 314);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Espace Utilisateur";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Btn_Produit);
            this.groupBox6.Controls.Add(this.Btn_CodeABarre);
            this.groupBox6.Controls.Add(this.Btn_Parametre);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(12, 35);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(379, 249);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Produit";
            // 
            // Btn_Produit
            // 
            this.Btn_Produit.BackColor = System.Drawing.Color.LightGray;
            this.Btn_Produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Produit.ForeColor = System.Drawing.Color.Black;
            this.Btn_Produit.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Produit.Image")));
            this.Btn_Produit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Produit.Location = new System.Drawing.Point(33, 38);
            this.Btn_Produit.Name = "Btn_Produit";
            this.Btn_Produit.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Btn_Produit.Size = new System.Drawing.Size(312, 52);
            this.Btn_Produit.TabIndex = 18;
            this.Btn_Produit.Text = "Produit";
            this.Btn_Produit.UseVisualStyleBackColor = false;
            this.Btn_Produit.Click += new System.EventHandler(this.Btn_Produit_Click);
            // 
            // Btn_CodeABarre
            // 
            this.Btn_CodeABarre.BackColor = System.Drawing.Color.LightGray;
            this.Btn_CodeABarre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CodeABarre.ForeColor = System.Drawing.Color.Black;
            this.Btn_CodeABarre.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CodeABarre.Image")));
            this.Btn_CodeABarre.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_CodeABarre.Location = new System.Drawing.Point(33, 108);
            this.Btn_CodeABarre.Name = "Btn_CodeABarre";
            this.Btn_CodeABarre.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Btn_CodeABarre.Size = new System.Drawing.Size(312, 52);
            this.Btn_CodeABarre.TabIndex = 17;
            this.Btn_CodeABarre.Text = "Code à barre    ";
            this.Btn_CodeABarre.UseVisualStyleBackColor = false;
            this.Btn_CodeABarre.Click += new System.EventHandler(this.Btn_CodeABarre_Click);
            // 
            // Btn_Parametre
            // 
            this.Btn_Parametre.BackColor = System.Drawing.Color.LightGray;
            this.Btn_Parametre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Parametre.ForeColor = System.Drawing.Color.Black;
            this.Btn_Parametre.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Parametre.Image")));
            this.Btn_Parametre.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Parametre.Location = new System.Drawing.Point(33, 175);
            this.Btn_Parametre.Name = "Btn_Parametre";
            this.Btn_Parametre.Size = new System.Drawing.Size(312, 52);
            this.Btn_Parametre.TabIndex = 18;
            this.Btn_Parametre.Text = "Modif prix /Stock/Préremp        ";
            this.Btn_Parametre.UseVisualStyleBackColor = false;
            this.Btn_Parametre.Click += new System.EventHandler(this.Btn_Parametre_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(441, 33);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("menuToolStripMenuItem.Image")));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(99, 29);
            this.toolStripMenuItem3.Text = "Quitter";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // F_FichierBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(441, 567);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_FichierBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fichier De Base";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button Btn_CodeABarre;
        private System.Windows.Forms.Button Btn_Parametre;
        private System.Windows.Forms.Button Btn_Produit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}