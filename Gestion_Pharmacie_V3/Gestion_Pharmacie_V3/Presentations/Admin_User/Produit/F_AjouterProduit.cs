using Gestion_Pharmacie_V3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Pharmacie_V3.Presentations.Admin.Produit
{
    public partial class F_AjouterProduit : Form
    {
        public F_AjouterProduit()
        {
            InitializeComponent();

            RemplireCb_Form();
            Cb_Form.SelectedValue = -1;

            RemplireCb_Categorie();
            Cb_Categorie.SelectedValue = -1;

            RemplireCb_Grossiste();
            Cb_Grossiste.SelectedValue = -1;

            RemplireCb_FarmTarif();
            Cb_FarmTarif.SelectedValue = -1;

            RemplireCb_Labo();
            Cb_Labo.SelectedValue = -1;



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

        private void F_AjouterProduitAdmin_Load(object sender, EventArgs e)
        {
            
        }

        //Ajouter Produit
        private void Btn_Confirmer_Click(object sender, EventArgs e)
        {
            try
            {
                if ( (T_Designation.Text == "") || (T_CodeBarre.Text == "") || (T_PrixAchat.Text =="") || (T_PrixV.Text == "") )
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


                        var MonProduit = new TableProduit
                        {

                            CodeBarre = T_CodeBarre.Text,
                            DesignationPro = T_Designation.Text,
                            Prixdachat = decimal.Parse(T_PrixAchat.Text),
                            PrixVente = decimal.Parse(T_PrixV.Text),

                            FormProduit       = ValueFormProduit,
                            CategorieProduit  = ValueCategorie,
                            FamTarif          = ValueFamTarif,
                            Grossiste         = ValueGrossiste,
                            Laboratoire       = ValueLaboratoire,
                            QteStock          =0,
                            ProduitActif      =0
                        };

                        MyContext.TableProduits.Add(MonProduit);
                        int Rep = MyContext.SaveChanges();
                        if (Rep>0)
                        {
                            MessageBox.Show("Produit a Bien Ajouter");
                        }
                        else
                        {
                            MessageBox.Show("Erreur d'ajoute !! ");
                        }
                        
                    }
                        
                }
        }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
}

        private void Btn_AnullerProduit_Click(object sender, EventArgs e)
        {
            //decimal Prixdachat = decimal.Parse(T_PrixAchat.Text);
            //decimal PrixVente = decimal.Parse(T_PrixV.Text);

            MessageBox.Show(Cb_Form.SelectedValue.ToString() + "Test" );
            MessageBox.Show(Cb_Form.SelectedItem.ToString() + "Test2");

        }
    }
}


