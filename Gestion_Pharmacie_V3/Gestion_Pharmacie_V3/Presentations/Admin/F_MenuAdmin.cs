using Gestion_Pharmacie_V3.Presentations.F_Utilisateur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Pharmacie_V3.Presentations.Admin
{
    public partial class F_MenuAdmin : Form
    {
        public F_MenuAdmin()
        {
            InitializeComponent();
        }

        private void tabDeBordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login F = new F_Login();
            F.Show();
            Hide();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_FichierBase F = new F_FichierBase();
            F.Show();
            Hide();
        }
    }
}
