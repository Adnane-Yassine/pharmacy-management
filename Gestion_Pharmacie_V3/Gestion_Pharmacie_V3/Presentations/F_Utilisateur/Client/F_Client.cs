using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Pharmacie_V3.Presentations.F_Utilisateur.Client
{
    public partial class F_Client : Form
    {
        public F_Client()
        {
            InitializeComponent();
        }

        private void Btn_AjouterClient_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_TousClients_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_RetourneMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Quitter_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_ModifierClient_Click(object sender, EventArgs e)
        {
            
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_UtilisateurMenu F = new F_UtilisateurMenu();
            F.Show();
            Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DialogResult Rep = MessageBox.Show("Vouler vous Vraiment Quitter ?", "Férméture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Rep == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Btn_AjouterClient_Click_1(object sender, EventArgs e)
        {
            F_AjouterClient F = new F_AjouterClient();
            F.Show();
            Hide();
        }

        private void Btn_ModifierClient_Click_1(object sender, EventArgs e)
        {
            F_ModifierClient F = new F_ModifierClient();
            F.Show();
            Hide();
        }

        private void Btn_TousClients_Click_1(object sender, EventArgs e)
        {
            F_TousLesClients F = new F_TousLesClients();
            F.Show();
            Hide();
        }
    }
}
