using Gestion_Pharmacie_V3.Presentations.Admin;
using Gestion_Pharmacie_V3.Presentations.F_Utilisateur.Fournisseur;
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
    public partial class F_FichierBase : Form
    {
        public F_FichierBase()
        {
            InitializeComponent();
        }

       

        private void Btn_Quitter_Click(object sender, EventArgs e)
        {
            DialogResult Rep = MessageBox.Show("Voulez vous vraiment Quitter", "Férmeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == Rep)
            {
                Application.Exit();
            }
        }

        //Btn Return To Menu
        private void button4_Click(object sender, EventArgs e)
        {
            F_UtilisateurMenu F = new F_UtilisateurMenu();
            F.Show();
            this.Hide();
        }

        private void Btn_Produit_Click(object sender, EventArgs e)
        {
            F_ListeProduits F = new F_ListeProduits();
            F.Show();
            Hide();
        }

        private void Btn_Quitter_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Btn_RetourneMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Client_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_CodeABarre_Click(object sender, EventArgs e)
        {
            F_SelectionProduit F = new F_SelectionProduit();
            F.Show();
            Hide();
        }

        private void Btn_Parametre_Click(object sender, EventArgs e)
        {
            MAJ_Produit F = new MAJ_Produit();
            F.Show();
            Hide();
        }

        private void Btn_Fournisseurs_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_QuitterApp_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            F_UtilisateurMenu F = new F_UtilisateurMenu();
            F.Show();
            Hide();
        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_UtilisateurMenu F = new F_UtilisateurMenu();
            F.Show();
            Hide();
        }

        private void Btn_QuitterApp_Click_1(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DialogResult Rep = MessageBox.Show("Vouler vous Vraiment Quitter ?", "Férméture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Rep == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
