using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Pharmacie_V3.Presentations.F_Utilisateur.Ventes
{
    public partial class F_Vente : Form
    {
        public F_Vente()
        {
            InitializeComponent();
        }

        private void Btn_RetourneMenu_Click(object sender, EventArgs e)
        {
            F_UtilisateurMenu F = new F_UtilisateurMenu();
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
