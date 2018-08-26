using Gestion_Pharmacie_V3.Presentations.F_Utilisateur.Client;
using Gestion_Pharmacie_V3.Presentations.F_Utilisateur.Fournisseur;
using Gestion_Pharmacie_V3.Presentations.F_Utilisateur.Ventes;
using System;
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
    public partial class F_UtilisateurMenu : Form
    {
        public F_UtilisateurMenu()
        {
            InitializeComponent();
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_FichierBase F = new F_FichierBase();
            F.Show();
            Hide();
        }

        private void Btn_Quitter_Click(object sender, EventArgs e)
        {
        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            F_Login F = new F_Login();
            F.Show();
            Hide();
            
        }

        private void Btn_QuitterApp_Click(object sender, EventArgs e)
        {

            DialogResult Rep = MessageBox.Show("Vouler vous Vraiment Quitter ?", "Férméture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Rep == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void achatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestionAchats F = new F_GestionAchats();
            F.Show();
            Hide();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Client F = new F_Client();
            F.Show();
            Hide();
        }

        private void fournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MenuFournisseur F = new F_MenuFournisseur();
            F.Show();
            Hide();
        }

        private void ventesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Vente F = new F_Vente();
            F.Show();
            Hide();
        }

        private void tabDeBordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login F = new F_Login();
            F.Show();
            Hide();
        }
    }
}
