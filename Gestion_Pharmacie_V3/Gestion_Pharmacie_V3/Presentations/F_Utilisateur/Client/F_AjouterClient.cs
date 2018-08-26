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
    public partial class F_AjouterClient : Form
    {
        public F_AjouterClient()
        {
            InitializeComponent();
            Cb_Couverture.SelectedIndex = 0;
            Cb_List15Produit.SelectedIndex = 0;
        }

        private void Btn_Valider_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Validation a bien Fait !");
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

        private void Btn_Quitter_Click_1(object sender, EventArgs e)
        {
            DialogResult Rep = MessageBox.Show("Vouler vous Vraiment Quitter ?", "Férméture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Rep == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Btn_RetourneMenu_Click_1(object sender, EventArgs e)
        {
            F_UtilisateurMenu F = new F_UtilisateurMenu();
            F.Show();
            Hide();
        }

        private void Btn_Sauvgarder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("le Client a bien Ajouter ");
        }
    }
}
