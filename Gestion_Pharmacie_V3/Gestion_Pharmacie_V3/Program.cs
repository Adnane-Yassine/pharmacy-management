using Gestion_Pharmacie_V3.Presentations.Admin;
using Gestion_Pharmacie_V3.Presentations.Admin.Produit;
using Gestion_Pharmacie_V3.Presentations.Admin_User.Produit;
using Gestion_Pharmacie_V3.Presentations.F_Utilisateur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Pharmacie_V3
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new F_ListeProduits());
        }
    }
}
