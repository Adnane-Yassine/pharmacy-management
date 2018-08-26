namespace Gestion_Pharmacie_V3.Presentations.F_Utilisateur.Client
{
    partial class F_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Client));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Btn_ModifierClient = new System.Windows.Forms.Button();
            this.Btn_TousClients = new System.Windows.Forms.Button();
            this.Btn_AjouterClient = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Client";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(21, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 249);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Btn_ModifierClient);
            this.groupBox4.Controls.Add(this.Btn_TousClients);
            this.groupBox4.Controls.Add(this.Btn_AjouterClient);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(425, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 249);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // Btn_ModifierClient
            // 
            this.Btn_ModifierClient.BackColor = System.Drawing.Color.LightGray;
            this.Btn_ModifierClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ModifierClient.ForeColor = System.Drawing.Color.Black;
            this.Btn_ModifierClient.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ModifierClient.Image")));
            this.Btn_ModifierClient.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Btn_ModifierClient.Location = new System.Drawing.Point(20, 109);
            this.Btn_ModifierClient.Name = "Btn_ModifierClient";
            this.Btn_ModifierClient.Size = new System.Drawing.Size(239, 47);
            this.Btn_ModifierClient.TabIndex = 46;
            this.Btn_ModifierClient.Text = "Modifier Client      ";
            this.Btn_ModifierClient.UseVisualStyleBackColor = false;
            this.Btn_ModifierClient.Click += new System.EventHandler(this.Btn_ModifierClient_Click_1);
            // 
            // Btn_TousClients
            // 
            this.Btn_TousClients.BackColor = System.Drawing.Color.LightGray;
            this.Btn_TousClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TousClients.ForeColor = System.Drawing.Color.Black;
            this.Btn_TousClients.Image = ((System.Drawing.Image)(resources.GetObject("Btn_TousClients.Image")));
            this.Btn_TousClients.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Btn_TousClients.Location = new System.Drawing.Point(20, 179);
            this.Btn_TousClients.Name = "Btn_TousClients";
            this.Btn_TousClients.Padding = new System.Windows.Forms.Padding(0, 3, 5, 0);
            this.Btn_TousClients.Size = new System.Drawing.Size(241, 48);
            this.Btn_TousClients.TabIndex = 45;
            this.Btn_TousClients.Text = "Tous les Clients    ";
            this.Btn_TousClients.UseVisualStyleBackColor = false;
            this.Btn_TousClients.Click += new System.EventHandler(this.Btn_TousClients_Click_1);
            // 
            // Btn_AjouterClient
            // 
            this.Btn_AjouterClient.BackColor = System.Drawing.Color.LightGray;
            this.Btn_AjouterClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AjouterClient.ForeColor = System.Drawing.Color.Black;
            this.Btn_AjouterClient.Image = ((System.Drawing.Image)(resources.GetObject("Btn_AjouterClient.Image")));
            this.Btn_AjouterClient.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Btn_AjouterClient.Location = new System.Drawing.Point(20, 40);
            this.Btn_AjouterClient.Name = "Btn_AjouterClient";
            this.Btn_AjouterClient.Size = new System.Drawing.Size(239, 50);
            this.Btn_AjouterClient.TabIndex = 44;
            this.Btn_AjouterClient.Text = "Ajouter Client      ";
            this.Btn_AjouterClient.UseVisualStyleBackColor = false;
            this.Btn_AjouterClient.Click += new System.EventHandler(this.Btn_AjouterClient_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 33);
            this.menuStrip1.TabIndex = 34;
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
            // F_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(770, 407);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Btn_ModifierClient;
        private System.Windows.Forms.Button Btn_TousClients;
        private System.Windows.Forms.Button Btn_AjouterClient;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}