using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Pharmacie_V3.Presentations.F_Utilisateur.Fournisseur
{
    public partial class F_Fournisseur : Form
    {
        public F_Fournisseur()
        {
            InitializeComponent();
        }

        private void Btn_Quitter_Click(object sender, EventArgs e)
        {
            DialogResult Rep = MessageBox.Show("Vouler vous Vraiment Quitter ?", "Férméture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Rep == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Btn_RetourneMenu_Click(object sender, EventArgs e)
        {
            F_UtilisateurMenu F = new F_UtilisateurMenu();
            F.Show();
            Hide();
        }

        private void Btn_AjouterFournisseur_Click(object sender, EventArgs e)
        {
            F_AjouterFournisseur F = new F_AjouterFournisseur();
            F.Show();
            Hide();
        }

        private void Btn_RetourneMenu_Click_1(object sender, EventArgs e)
        {
            F_UtilisateurMenu F = new F_UtilisateurMenu();
            F.Show();
            Hide();
        }
    }
}
