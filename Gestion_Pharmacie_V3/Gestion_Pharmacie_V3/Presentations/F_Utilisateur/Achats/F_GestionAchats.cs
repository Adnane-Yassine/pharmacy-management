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
    public partial class F_GestionAchats : Form
    {
        public F_GestionAchats()
        {
            InitializeComponent();
        }

        private void Btn_QuitterApp_Click(object sender, EventArgs e)
        {
            DialogResult Rep = MessageBox.Show("Vouler vous Vraiment Quitter ?", "Férméture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Rep == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            F_UtilisateurMenu F = new F_UtilisateurMenu();
            F.Show();
            Hide();
        }
    }
}
