namespace Gestion_Pharmacie_V3.Presentations.F_Utilisateur
{
    partial class F_Paramétre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Paramétre));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Précedent = new System.Windows.Forms.Button();
            this.Btn_Quitter = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Location = new System.Drawing.Point(12, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 438);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label1);
            this.groupBox9.Location = new System.Drawing.Point(10, 19);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(419, 97);
            this.groupBox9.TabIndex = 15;
            this.groupBox9.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Motken daeira", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(240)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paramétre d\'application";
            // 
            // Btn_Précedent
            // 
            this.Btn_Précedent.BackColor = System.Drawing.Color.LightGray;
            this.Btn_Précedent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Précedent.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Précedent.Image")));
            this.Btn_Précedent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Précedent.Location = new System.Drawing.Point(387, 12);
            this.Btn_Précedent.Name = "Btn_Précedent";
            this.Btn_Précedent.Size = new System.Drawing.Size(40, 41);
            this.Btn_Précedent.TabIndex = 22;
            this.Btn_Précedent.UseVisualStyleBackColor = false;
            this.Btn_Précedent.Click += new System.EventHandler(this.Btn_Précedent_Click);
            // 
            // Btn_Quitter
            // 
            this.Btn_Quitter.BackColor = System.Drawing.Color.LightGray;
            this.Btn_Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Quitter.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Quitter.Image")));
            this.Btn_Quitter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Quitter.Location = new System.Drawing.Point(433, 12);
            this.Btn_Quitter.Name = "Btn_Quitter";
            this.Btn_Quitter.Size = new System.Drawing.Size(40, 41);
            this.Btn_Quitter.TabIndex = 21;
            this.Btn_Quitter.UseVisualStyleBackColor = false;
            this.Btn_Quitter.Click += new System.EventHandler(this.Btn_Quitter_Click);
            // 
            // F_Paramétre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(485, 501);
            this.Controls.Add(this.Btn_Précedent);
            this.Controls.Add(this.Btn_Quitter);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Paramétre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Paramétre";
            this.groupBox2.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Précedent;
        private System.Windows.Forms.Button Btn_Quitter;
    }
}