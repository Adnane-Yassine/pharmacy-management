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
    public partial class ParametreProduitAdmin : Form
    {
        public ParametreProduitAdmin()
        {
            InitializeComponent();
        }

        

        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {
            using (GestionPharmacieEntities Context = new GestionPharmacieEntities())
            {
                var MyForm = new TableForme
                {
                    Forme = T_Form.Text
                };
                Context.TableFormes.Add(MyForm);
                int Rep = Context.SaveChanges();
                if (Rep > 0)
                {
                    MessageBox.Show("Form Bien Ajouter");
                    T_Form.Text = "";

                }

            }


        }

        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
            string Formname = T_Form.Text;
            using (GestionPharmacieEntities Context = new GestionPharmacieEntities())
            {
                var ProduitsActive = (from B in Context.TableFormes
                                     where B.Forme == Formname
                                     select B).ToList();

                if (ProduitsActive.Count() == 0)
                {
                    MessageBox.Show("Form Incorrect");
                }
                else
                {
                    MessageBox.Show("Taper Nv Form ");
                    Btn_Save.Enabled = true;
                    T_FormModifier.Enabled = true;
                }
                

            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            string Formname = T_Form.Text;
            string NvForm = T_FormModifier.Text;

            using (GestionPharmacieEntities Context = new GestionPharmacieEntities())
            {
                var MyValue = Context.TableFormes.SingleOrDefault(B => B.Forme == Formname);
                MyValue.Forme = NvForm;
                Context.SaveChanges();
                MessageBox.Show("La Form a Bien Modifier");
                Btn_Save.Enabled = false;
                T_FormModifier.Enabled = false;
                T_FormModifier.Text = "";
                T_Form.Text = "";
            }
          }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
            string Formname = T_Form.Text;
            using (GestionPharmacieEntities Context = new GestionPharmacieEntities())
            {
                var FormObject = Context.TableFormes.SingleOrDefault(x => x.Forme == Formname);
                if (FormObject != null)
                {
                    Context.TableFormes.Remove(FormObject);
                    Context.SaveChanges();
                    MessageBox.Show("Suppression a Bien Fait");
                    T_Form.Text = "";
                }
                else
                {
                    MessageBox.Show("Suppression n'a pas Fait");
                }
            }
        }

        //****************************************************************************************************************
        //Code Catégorie

        private void Btn_AjouterCategorie_Click(object sender, EventArgs e)
        {
            using (GestionPharmacieEntities Context = new GestionPharmacieEntities())
            {
                var MyCate = new TableCategorie
                {
                    Categorie = T_Categorie.Text
                };
                Context.TableCategories.Add(MyCate);
                int Rep = Context.SaveChanges();
                if (Rep > 0)
                {
                    MessageBox.Show("Catégorie Bien Ajouter");
                    T_Categorie.Text = "";

                }

            }
        }

        private void Btn_ModifierCategorie_Click(object sender, EventArgs e)
        {
            string CategorieName = T_Categorie.Text;
            using (GestionPharmacieEntities Context = new GestionPharmacieEntities())
            {
                var ProduitsExiste = (from B in Context.TableCategories
                                      where B.Categorie == CategorieName
                                      select B).ToList();

                if (ProduitsExiste.Count() == 0)
                {
                    MessageBox.Show("Catégorie Incorrect");
                }
                else
                {
                    MessageBox.Show("Taper Nv Catégorie ");
                    Btn_EnregCategorie.Enabled = true;
                    T_NvCategorie.Enabled = true;
                }


            }
        }

        private void Btn_SupprimerCateg_Click(object sender, EventArgs e)
        {
            string CategorieName = T_Categorie.Text;

            using (GestionPharmacieEntities Context = new GestionPharmacieEntities())
            {
                var CategorieObject = Context.TableCategories.SingleOrDefault(x => x.Categorie == CategorieName);
                if (CategorieObject != null)
                {
                    Context.TableCategories.Remove(CategorieObject);
                    Context.SaveChanges();
                    MessageBox.Show("Suppression a Bien Fait");
                    T_Categorie.Text = "";
                }
                else
                {
                    MessageBox.Show("Suppression n'a pas Fait");
                }
            }
        }

        private void Btn_EnregCategorie_Click(object sender, EventArgs e)
        {
            string Categoriename = T_Categorie.Text;
            string NvCategorie   = T_NvCategorie.Text;

            using (GestionPharmacieEntities Context = new GestionPharmacieEntities())
            {
                var ValueSearch = Context.TableCategories.SingleOrDefault(B => B.Categorie == Categoriename);
                ValueSearch.Categorie = NvCategorie;
                Context.SaveChanges();
                MessageBox.Show("La Catégorie a Bien Modifier");
                Btn_EnregCategorie.Enabled = false;
                T_NvCategorie.Enabled = false;
                T_NvCategorie.Text = "";
                T_Categorie.Text = "";
            }
        }


        //****************************************************************************************************************
        //Code Catégorie


    }
}
