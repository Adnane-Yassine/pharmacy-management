using Gestion_Pharmacie_V3.Presentations.Admin;
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

namespace Gestion_Pharmacie_V3
{
    public partial class F_Login : Form
    {
        public F_Login()
        {
            InitializeComponent();
        }

        //BtnQuitter
        private void Btn_Facture_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Quitter_Click(object sender, EventArgs e)
        {
            DialogResult Rep = MessageBox.Show("Voulez vous vraiment Quitter", "Férmeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == Rep)
            {
                this.Close();
            }
        }

      

        private void Btn_Quitter_Click_1(object sender, EventArgs e)
        {
            DialogResult Rep = MessageBox.Show("Vouler vous Vraiment Quitter ?","Férméture",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (Rep == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Btn_ConnecterAdmin_Click_1(object sender, EventArgs e)
        {
            var LoginU = T_LoginAdmin.Text;
            var PassU = T_PsswrdAdmin.Text;

            using (GestionPharmacieEntities Context = new GestionPharmacieEntities())
            {
                var user = Context.LoginApps.FirstOrDefault(L => L.LoginUser == LoginU && L.PassUser == PassU);
                if (user != null)
                {
                    if (user.TypeUser == "admin")
                    {
                        F_MenuAdmin F  = new F_MenuAdmin();
                        F.Show();
                        this.Hide();
                    }
                    else
                    {
                        if (user.TypeUser == "user")
                        {
                            F_UtilisateurMenu F = new F_UtilisateurMenu();
                            F.Show();
                            this.Hide();
                        }
                    }


                }
                else
                {
                    MessageBox.Show("Login Ou Mot de Pass Incorrect !");
                }

            }
        }

        private void Btn_AnnulerAdmin_Click_1(object sender, EventArgs e)
        {
            T_LoginAdmin.Text = "";
            T_PsswrdAdmin.Text = "";
        }

        private void Btn_Developpeur_Click(object sender, EventArgs e)
        {
            F_Developpeur F = new F_Developpeur();
            F.Show();
            Hide();
        }

        private void développeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Developpeur F = new F_Developpeur();
            F.Show();
            Hide();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Rep = MessageBox.Show("Vouler vous Vraiment Quitter ?", "Férméture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Rep == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void paramétreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Paramétre F = new F_Paramétre();
            F.Show();
            Hide();
        }
    }
}
