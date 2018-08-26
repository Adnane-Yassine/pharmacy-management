using Gestion_Pharmacie_V3.Presentations.Admin.Produit;
using Gestion_Pharmacie_V3.Presentations.Admin_User.Produit;
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
    public partial class F_ListeProduits : Form
    {
        public F_ListeProduits()
        {
            InitializeComponent();
            RemplireGrid();
        }

        public void RemplireGrid()
        {
            try
            {
                Grid_Produit.Rows.Clear();
                using (GestionPharmacieEntities Context = new GestionPharmacieEntities())
                {
                    var AllProduit = (from c in Context.TableProduits select c).ToList();
                    string PrActife = "";

                    for (int i = 0; i < AllProduit.Count; i++)
                    {
                        if (AllProduit[i].ProduitActif == 1)
                        {
                            PrActife = "Produit Actife";
                        }
                        else
                        {
                            PrActife = "Produit Pas Actife";
                        }

                        Grid_Produit.Rows.Add(AllProduit[i].ProduitID,
                                              AllProduit[i].CodeBarre,
                                              AllProduit[i].DesignationPro,
                                              AllProduit[i].Prixdachat,
                                              AllProduit[i].PrixVente,
                                              AllProduit[i].FormProduit,
                                              AllProduit[i].CategorieProduit,
                                              AllProduit[i].FamTarif,
                                              PrActife,
                                              AllProduit[i].QteStock,
                                              AllProduit[i].Laboratoire,
                                              AllProduit[i].Grossiste,
                                              false
                                              
                                              );
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

               
        }

        private void Btn_Rechercher_Click(object sender, EventArgs e)
        {
            try
            {
                Grid_Produit.Rows.Clear();

                string ProduitName = T_RechercherProduit.Text;
                string CodeBarreP = T_RechercherProduit.Text;

                //************************************************************************************************************
                if (Rd_Libelle.Checked)
                {

                    if (Rd_Actifs.Checked)
                    {

                        using (GestionPharmacieEntities Context = new GestionPharmacieEntities())
                        {
                            var ProduitsActive = from B in Context.TableProduits
                                                 where B.DesignationPro.StartsWith(ProduitName) && B.ProduitActif == 1
                                                 select B;


                            if (ProduitsActive.Count() == 0)
                            {
                                MessageBox.Show("Aucun Produit Active");
                            }
                            else
                            {
                                Grid_Produit.Rows.Clear();
                                string PrActife = "";

                                for (int i = 0; i < ProduitsActive.ToList().Count(); i++)
                                {
                                    if (ProduitsActive.ToList()[i].ProduitActif == 1)
                                    {
                                        PrActife = "Actife";
                                    }

                                    Grid_Produit.Rows.Add(ProduitsActive.ToList()[i].ProduitID,
                                                               ProduitsActive.ToList()[i].CodeBarre,
                                                               ProduitsActive.ToList()[i].DesignationPro,
                                                               ProduitsActive.ToList()[i].Prixdachat,
                                                               ProduitsActive.ToList()[i].PrixVente,
                                                               ProduitsActive.ToList()[i].FormProduit,
                                                               ProduitsActive.ToList()[i].CategorieProduit,
                                                               ProduitsActive.ToList()[i].FamTarif,
                                                               PrActife,
                                                               ProduitsActive.ToList()[i].QteStock,
                                                               ProduitsActive.ToList()[i].Laboratoire,
                                                               ProduitsActive.ToList()[i].Grossiste,
                                                               false
                                                               );
                                }

                            }

                        }
                    }
                    //*******************************************************************************************
                    else
                    {
                        if (rd_Desactives.Checked)
                        {
                            using (GestionPharmacieEntities Context = new GestionPharmacieEntities())
                            {
                                var ProduitsDesactive = from B in Context.TableProduits
                                                        where B.DesignationPro.StartsWith(ProduitName) && B.ProduitActif == 0
                                                        select B;


                                if (ProduitsDesactive.Count() == 0)
                                {
                                    MessageBox.Show("Aucun Produit Désactive");
                                }
                                else
                                {
                                    Grid_Produit.Rows.Clear();
                                    string Prdesactife = "";

                                    for (int i = 0; i < ProduitsDesactive.ToList().Count(); i++)
                                    {
                                        if (ProduitsDesactive.ToList()[i].ProduitActif == 0)
                                        {
                                            Prdesactife = "Produit Pas Actife";
                                        }

                                        Grid_Produit.Rows.Add(ProduitsDesactive.ToList()[i].ProduitID,
                                                                   ProduitsDesactive.ToList()[i].CodeBarre,
                                                                   ProduitsDesactive.ToList()[i].DesignationPro,
                                                                   ProduitsDesactive.ToList()[i].Prixdachat,
                                                                   ProduitsDesactive.ToList()[i].PrixVente,
                                                                   ProduitsDesactive.ToList()[i].FormProduit,
                                                                   ProduitsDesactive.ToList()[i].CategorieProduit,
                                                                   ProduitsDesactive.ToList()[i].FamTarif,
                                                                   Prdesactife,
                                                                   ProduitsDesactive.ToList()[i].QteStock,
                                                                   ProduitsDesactive.ToList()[i].Laboratoire,
                                                                   ProduitsDesactive.ToList()[i].Grossiste,
                                                                   false
                                                                   );
                                    }

                                }

                            }
                        }

                        //*******************************************************************************************
                        else
                        {
                            using (GestionPharmacieEntities Context = new GestionPharmacieEntities())
                            {

                                var ProduitsSearch = from B in Context.TableProduits
                                                     where B.DesignationPro.StartsWith(ProduitName)
                                                     select B;

                                if (ProduitsSearch.Count() == 0)
                                {
                                    MessageBox.Show("Produit Introuvable !!");

                                }

                                else
                                //if (ProduitsSearch != null)
                                {

                                    Grid_Produit.Rows.Clear();

                                    string PrActife = "";

                                    for (int i = 0; i < ProduitsSearch.ToList().Count; i++)
                                    {
                                        if (ProduitsSearch.ToList()[i].ProduitActif == 1)
                                        {
                                            PrActife = "Produit  Actife";
                                        }
                                        else
                                        {
                                            PrActife = "Produit Pas Actife";
                                        }

                                        Grid_Produit.Rows.Add(ProduitsSearch.ToList()[i].ProduitID,
                                                              ProduitsSearch.ToList()[i].CodeBarre,
                                                              ProduitsSearch.ToList()[i].DesignationPro,
                                                              ProduitsSearch.ToList()[i].Prixdachat,
                                                              ProduitsSearch.ToList()[i].PrixVente,
                                                              ProduitsSearch.ToList()[i].FormProduit,
                                                              ProduitsSearch.ToList()[i].CategorieProduit,
                                                              ProduitsSearch.ToList()[i].FamTarif,
                                                              PrActife,
                                                              ProduitsSearch.ToList()[i].QteStock,
                                                              ProduitsSearch.ToList()[i].Laboratoire,
                                                              ProduitsSearch.ToList()[i].Grossiste,
                                                              false
                                                              );
                                    }

                                }


                            }
                        }
                        //******************************************************************************************
                    }


                }
                // *******************************Fin de Test IF ***********************************************
                else
                {
                    MessageBox.Show("Rechercher Par Code ");
                    if (Rd_Actifs.Checked)
                    {
                        // MessageBox.Show("Produit Active");
                        using (GestionPharmacieEntities Context = new GestionPharmacieEntities())
                        {

                            var ProduitsActive = from B in Context.TableProduits
                                                 .Where(B => B.CodeBarre == CodeBarreP && B.ProduitActif == 1)
                                                 select B;


                            if (ProduitsActive.Count() == 0)
                            {
                                MessageBox.Show("Aucun Produit Active");
                            }
                            else
                            {
                                Grid_Produit.Rows.Clear();
                                string PrActife = "";

                                for (int i = 0; i < ProduitsActive.ToList().Count(); i++)
                                {
                                    if (ProduitsActive.ToList()[i].ProduitActif == 1)
                                    {
                                        PrActife = "Actife";
                                    }

                                    Grid_Produit.Rows.Add(ProduitsActive.ToList()[i].ProduitID,
                                                               ProduitsActive.ToList()[i].CodeBarre,
                                                               ProduitsActive.ToList()[i].DesignationPro,
                                                               ProduitsActive.ToList()[i].Prixdachat,
                                                               ProduitsActive.ToList()[i].PrixVente,
                                                               ProduitsActive.ToList()[i].FormProduit,
                                                               ProduitsActive.ToList()[i].CategorieProduit,
                                                               ProduitsActive.ToList()[i].FamTarif,
                                                               PrActife,
                                                               ProduitsActive.ToList()[i].QteStock,
                                                               ProduitsActive.ToList()[i].Laboratoire,
                                                               ProduitsActive.ToList()[i].Grossiste,
                                                               false
                                                               );
                                }

                            }

                        }
                    }
                    //*******************************************************************************************
                    else
                    {
                        if (rd_Desactives.Checked)
                        {
                            using (GestionPharmacieEntities Context = new GestionPharmacieEntities())
                            {
                                var ProduitsDesactive = from B in Context.TableProduits
                                                       .Where(B => B.CodeBarre == CodeBarreP && B.ProduitActif == 0)
                                                        select B;


                                if (ProduitsDesactive.Count() == 0)
                                {
                                    MessageBox.Show("Aucun Produit Désactive");
                                }
                                else
                                {
                                    Grid_Produit.Rows.Clear();
                                    string Prdesactife = "";

                                    for (int i = 0; i < ProduitsDesactive.ToList().Count(); i++)
                                    {
                                        if (ProduitsDesactive.ToList()[i].ProduitActif == 0)
                                        {
                                            Prdesactife = "Produit Pas Actife";
                                        }

                                        Grid_Produit.Rows.Add(ProduitsDesactive.ToList()[i].ProduitID,
                                                                   ProduitsDesactive.ToList()[i].CodeBarre,
                                                                   ProduitsDesactive.ToList()[i].DesignationPro,
                                                                   ProduitsDesactive.ToList()[i].Prixdachat,
                                                                   ProduitsDesactive.ToList()[i].PrixVente,
                                                                   ProduitsDesactive.ToList()[i].FormProduit,
                                                                   ProduitsDesactive.ToList()[i].CategorieProduit,
                                                                   ProduitsDesactive.ToList()[i].FamTarif,
                                                                   Prdesactife,
                                                                   ProduitsDesactive.ToList()[i].QteStock,
                                                                   ProduitsDesactive.ToList()[i].Laboratoire,
                                                                   ProduitsDesactive.ToList()[i].Grossiste,
                                                                   false
                                                                   );
                                    }

                                }

                            }
                        }

                        //*******************************************************************************************
                        else
                        {
                            using (GestionPharmacieEntities Context = new GestionPharmacieEntities())
                            {

                                var ProduitsSearch = from B in Context.TableProduits
                                                     .Where(B => B.CodeBarre == CodeBarreP)
                                                     select B;

                                if (ProduitsSearch.Count() == 0)
                                {
                                    MessageBox.Show("Produit Introuvable !!");

                                }

                                else
                                //if (ProduitsSearch != null)
                                {

                                    Grid_Produit.Rows.Clear();

                                    string PrActife = "";

                                    for (int i = 0; i < ProduitsSearch.ToList().Count; i++)
                                    {
                                        if (ProduitsSearch.ToList()[i].ProduitActif == 1)
                                        {
                                            PrActife = "Produit  Actife";
                                        }
                                        else
                                        {
                                            PrActife = "Produit Pas Actife";
                                        }

                                        Grid_Produit.Rows.Add(ProduitsSearch.ToList()[i].ProduitID,
                                                              ProduitsSearch.ToList()[i].CodeBarre,
                                                              ProduitsSearch.ToList()[i].DesignationPro,
                                                              ProduitsSearch.ToList()[i].Prixdachat,
                                                              ProduitsSearch.ToList()[i].PrixVente,
                                                              ProduitsSearch.ToList()[i].FormProduit,
                                                              ProduitsSearch.ToList()[i].CategorieProduit,
                                                              ProduitsSearch.ToList()[i].FamTarif,
                                                              PrActife,
                                                              ProduitsSearch.ToList()[i].QteStock,
                                                              ProduitsSearch.ToList()[i].Laboratoire,
                                                              ProduitsSearch.ToList()[i].Grossiste,
                                                              false
                                                              );
                                    }

                                }


                            }
                        }
                        //******************************************************************************************
                    }
                }
                //***********************************Fin de Else **********************************************
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
       
           
        }

        private void tousLesProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemplireGrid();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Utilisateur.F_AjouterProduit F = new F_Utilisateur.F_AjouterProduit();
            F.Show();
            Hide();
        }

        //****************************************************************************
        //Variables Globales 
        public static int    ProduitIDGlobale = 0;
        public static string ProduitDesGlobale = "";
        public static string ProduitCodeBGlobale = "";
        //****************************************************************************

        private void Grid_Produit_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //try
            //{
                for (int i = 0; i < Grid_Produit.RowCount; i++)
                {
                    if (bool.Parse(Grid_Produit.Rows[i].Cells[12].Value.ToString()) == true)
                    {
                        Grid_Produit.Rows[i].Cells[12].Value = false;
                    }
                }

                int index = e.RowIndex;
                DataGridViewRow MyRow = Grid_Produit.Rows[index];
                T_MAJ.Text = MyRow.Cells[0].Value.ToString();
                T_NamePro.Text = MyRow.Cells[2].Value.ToString();

                ProduitCodeBGlobale = MyRow.Cells[1].Value.ToString();
                ProduitDesGlobale = MyRow.Cells[2].Value.ToString();
            //}
            //catch (Exception Ex)
            //{
            //    MessageBox.Show(Ex.Message);
            //}

        }

        

        private void Btn_ValiderMAJ_Click(object sender, EventArgs e)
        {
            try
            {
                if (T_MAJ.Text != "")
                {
                    if (Rd_Modifier.Checked)
                    {
                        DialogResult Rep = MessageBox.Show("Voulez vous Vraiment Modifier "+ T_NamePro.Text + "?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Rep == DialogResult.Yes)
                        {
                            ProduitIDGlobale = int.Parse(T_MAJ.Text);
                            F_ModifierProduit F = new F_ModifierProduit();
                            F.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Vous avez Anuller la Modification");
                        }
                    }
                    else
                    {
                        if (Rd_Supprimer.Checked)
                        {
                            DialogResult Rep = MessageBox.Show("Voulez vous Vraiment Supprimer " + T_NamePro.Text + "?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (Rep == DialogResult.Yes)
                            {
                                int IdProduit = int.Parse(T_MAJ.Text);

                                using (GestionPharmacieEntities MyContext = new GestionPharmacieEntities())
                                {

                                    var ProduitSup = (from P in MyContext.TableProduits
                                                        .Where(P => P.ProduitID == IdProduit)
                                                      select P);


                                    if (ProduitSup.ToList()[0].QteStock != 0)
                                    {
                                        MessageBox.Show("Ne Peut Pas Supprime Le Produit , la Quantité en Stcok et > 0");
                                    }
                                    else
                                    {
                                        if (ProduitSup.ToList()[0].QteStock.Value == 0)
                                        {
                                            MyContext.TableProduits.Remove(ProduitSup.ToList()[0]);
                                            MyContext.SaveChanges();
                                            MessageBox.Show("La Suppression de Produit a Bien Fait !");
                                            RemplireGrid();
                                        }


                                    }


                                }
                                   

                            }
                            else
                            {
                                MessageBox.Show("Vous avez Anuller la Suppresion ");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vous Avez Oublier de Coché le Choix !!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vous Avez Oublier de selectionné le Produit ");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
