using Gestion_Pharmacie_V3.Presentations.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Pharmacie_V3.Presentations.Admin_User.Produit
{
    public partial class F_ModifierProduit : Form
    {
        public F_ModifierProduit()
        {
            InitializeComponent();

            //RemplireGridChamps(F_ListeProduits.ProduitIDGlobale);
            RemplireGridChamps(F_ListeProduits.ProduitIDGlobale);

            //***************************************
            RemplireCb_Form();
            //Cb_Form.SelectedValue =-1;

            RemplireCb_Categorie();
            //Cb_Categorie.SelectedValue = -1;

            RemplireCb_Grossiste();
            //Cb_Grossiste.SelectedValue = -1;

            RemplireCb_FarmTarif();
            //Cb_FarmTarif.SelectedValue = -1;

            RemplireCb_Labo();
            //Cb_Labo.SelectedValue = -1;
            //*************************************

        }

        GestionPharmacieEntities Context = new GestionPharmacieEntities();

        public void RemplireCb_Form()
        {
            Cb_Form.DataSource = Context.TableFormes.Select(p => new { IdForm = p.FormeID, FormName = p.Forme }).ToList();
            Cb_Form.DisplayMember = "FormName";
            Cb_Form.ValueMember = "FormName";
        }

        public void RemplireCb_Categorie()
        {
            Cb_Categorie.DataSource = Context.TableCategories.Select(p => new { Idcateg = p.CategorieID, CategorieName = p.Categorie }).ToList();
            Cb_Categorie.DisplayMember = "CategorieName";
            Cb_Categorie.ValueMember = "CategorieName";
        }

        public void RemplireCb_Grossiste()
        {
            Cb_Grossiste.DataSource = Context.TableGrossistes.Select(p => new { IdGrossiste = p.GrossisteID, GrossisteName = p.Grossiste }).ToList();
            Cb_Grossiste.DisplayMember = "GrossisteName";
            Cb_Grossiste.ValueMember = "GrossisteName";
        }

        public void RemplireCb_FarmTarif()
        {
            Cb_FarmTarif.DataSource = Context.TableFarmTarifs.Select(p => new { IdFarmTarif = p.FarmTarifID, FarmTarifName = p.FarmTarif }).ToList();
            Cb_FarmTarif.DisplayMember = "FarmTarifName";
            Cb_FarmTarif.ValueMember = "FarmTarifName";
        }

        public void RemplireCb_Labo()
        {
            Cb_Labo.DataSource = Context.TableLaboes.Select(p => new { IdLabo = p.LaboID, LaboName = p.Labo }).ToList();
            Cb_Labo.DisplayMember = "LaboName";
            Cb_Labo.ValueMember = "LaboName";
        }

       

        public void RemplireGridChamps(int ProduitId)
        {
            
            try
            {
                using (GestionPharmacieEntities Context = new GestionPharmacieEntities())
                {
                    var AllProduit = from c in Context.TableProduits
                                     where (c.ProduitID == ProduitId)
                                     select c;

                   
                    for (int i = 0; i < AllProduit.ToList().Count(); i++)
                    {
                        GridUpdate.Rows.Add(AllProduit.ToList()[i].ProduitID,
                                              AllProduit.ToList()[i].CodeBarre,
                                              AllProduit.ToList()[i].DesignationPro,
                                              AllProduit.ToList()[i].Prixdachat,
                                              AllProduit.ToList()[i].PrixVente,
                                              AllProduit.ToList()[i].FormProduit,
                                              AllProduit.ToList()[i].CategorieProduit,
                                              AllProduit.ToList()[i].Grossiste,
                                              AllProduit.ToList()[i].FamTarif,
                                              AllProduit.ToList()[i].Laboratoire
                                              );     
                    }

                    T_CodeBarre.Text    = AllProduit.ToList()[0].CodeBarre;
                    T_Designation.Text  = AllProduit.ToList()[0].DesignationPro;
                    T_PrixV.Text        = AllProduit.ToList()[0].PrixVente.ToString();
                    T_PrixAchat.Text    = AllProduit.ToList()[0].Prixdachat.ToString();
                    Cb_Form.SelectedItem = AllProduit.ToList()[0].FormProduit.ToString();


                }
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }



        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Confirmer_Click(object sender, EventArgs e)
        {
            try
            {
                if ((T_Designation.Text == "") || (T_CodeBarre.Text == "") || (T_PrixAchat.Text == "") || (T_PrixV.Text == ""))
                {
                    MessageBox.Show("vous avez oublié un Champ");
                }
                else
                {
                    using (GestionPharmacieEntities MyContext = new GestionPharmacieEntities())
                    {
                        string ValueFormProduit = "";

                        if (Cb_Form.Text.ToString() == "")
                        {
                            ValueFormProduit = null;
                        }
                        else
                        {
                            ValueFormProduit = Cb_Form.SelectedValue.ToString();
                        }

                        //*************************************************

                        string ValueCategorie = "";

                        if (Cb_Categorie.Text.ToString() == "")
                        {
                            ValueCategorie = null;
                        }
                        else
                        {
                            ValueCategorie = Cb_Categorie.SelectedValue.ToString();
                        }

                        //*************************************************

                        double ValueFamTarif = 0;

                        if (Cb_FarmTarif.Text.ToString() == "")
                        {
                            ValueFamTarif = 0;
                        }
                        else
                        {
                            ValueFamTarif = double.Parse(Cb_FarmTarif.SelectedValue.ToString());
                        }

                        //*************************************************

                        string ValueGrossiste = "";

                        if (Cb_Grossiste.Text.ToString() == "")
                        {
                            ValueGrossiste = null;
                        }
                        else
                        {
                            ValueGrossiste = Cb_Grossiste.SelectedValue.ToString();
                        }

                        //*************************************************

                        string ValueLaboratoire = "";

                        if (Cb_FarmTarif.Text.ToString() == "")
                        {
                            ValueLaboratoire = null;
                        }
                        else
                        {
                            ValueLaboratoire = Cb_Labo.SelectedValue.ToString();
                        }

                        //*************************************************

                        var MonProduit = (from P in MyContext.TableProduits
                                         where P.ProduitID == F_ListeProduits.ProduitIDGlobale
                                          select P).First();

                        int Rep = -1;

                        if (MonProduit != null)
                        {
                            MonProduit.CodeBarre        = T_CodeBarre.Text;
                            MonProduit.DesignationPro   = T_Designation.Text;
                            MonProduit.Prixdachat       = decimal.Parse(T_PrixAchat.Text);
                            MonProduit.PrixVente        = decimal.Parse(T_PrixV.Text);

                            MonProduit.FormProduit      = ValueFormProduit;
                            MonProduit.CategorieProduit = ValueCategorie;
                            MonProduit.FamTarif         = ValueFamTarif;
                            MonProduit.Grossiste        = ValueGrossiste;
                            MonProduit.Laboratoire      = ValueLaboratoire;

                           Rep = MyContext.SaveChanges();
                        }
                       
                       
                        if (Rep > 0)
                        {
                            MessageBox.Show("Produit a Bien Modifier");
                        }
                        else
                        {
                            MessageBox.Show("Erreur de Modification !! ");
                        }

                    }

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
