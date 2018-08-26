﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Pharmacie_V3.Presentations.F_Utilisateur
{
    public partial class F_SelectionProduit : Form
    {
        public F_SelectionProduit()
        {
            InitializeComponent();
        }

        private void Btn_RetourneMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Quitter_Click(object sender, EventArgs e)
        {
            DialogResult Rep = MessageBox.Show("Vouler vous Vraiment Quitter ?", "Férméture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Rep == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_UtilisateurMenu F = new F_UtilisateurMenu();
            F.Show();
            Hide();
        }

        private void fichierDeBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_FichierBase F = new F_FichierBase();
            F.Show();
            Hide();
        }
    }
}
