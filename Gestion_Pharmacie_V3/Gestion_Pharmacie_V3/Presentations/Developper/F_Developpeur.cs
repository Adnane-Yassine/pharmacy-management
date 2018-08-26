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
    public partial class F_Developpeur : Form
    {
        public F_Developpeur()
        {
            InitializeComponent();
        }

        private void Btn_Précedent_Click(object sender, EventArgs e)
        {
            F_Login F = new F_Login();
            F.Show();
            Hide();
        }

        private void Btn_Quitter_Click(object sender, EventArgs e)
        {
            DialogResult Rep = MessageBox.Show("Vouler vous Vraiment Quitter ?", "Férméture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Rep == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
