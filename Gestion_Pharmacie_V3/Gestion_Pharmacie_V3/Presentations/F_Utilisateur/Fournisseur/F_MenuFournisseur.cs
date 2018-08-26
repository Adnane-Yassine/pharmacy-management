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
    public partial class F_MenuFournisseur : Form
    {
        public F_MenuFournisseur()
        {
            InitializeComponent();
        }

        private void Btn_RetourneMenu_Click(object sender, EventArgs e)
        {
            F_UtilisateurMenu F = new F_UtilisateurMenu();
            F.Show();
            Hide();
        }

        private void Btn_AjouterFourn_Click(object sender, EventArgs e)
        {
            F_AjouterFournisseur F = new F_AjouterFournisseur();
            F.Show();
            Hide();
        }

        private void Btn_TousClients_Click(object sender, EventArgs e)
        {
            F_Fournisseur F = new F_Fournisseur();
            F.Show();
            Hide();
        }
    }
}
