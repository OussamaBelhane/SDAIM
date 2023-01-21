using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDAIM.EPL;

namespace SDAIM.PL
{
    public partial class frm_pur_add : Form
    {
        //init 
        SDAIMEntities db = new SDAIMEntities();
        Purchase pur = new Purchase();
        stock sto = new stock();
        BL.Methods methods = new BL.Methods();
        toast toast = new toast();
        Dialog dialog = new Dialog();
        double uht, tva, poids, qte, tht, ttva, ttc;

        public int id;
        public frm_pur_add()
        {
            InitializeComponent();
        }

        private void frm_fou_add_Load(object sender, EventArgs e)
        {
            edt_cat.Height = 35;
            edt_fou.Height = 35;

        }

        private void edt_uht_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pro_cal();
            }
            catch { }
        }

        private void edt_tva_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pro_cal();
            }
            catch { }
        }

        private void edt_poid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pro_cal();
            }
            catch { }
        }

        private void edt_qte_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                pro_cal();
            }
            catch { }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            toast toast = new toast();
            Dialog dialog = new Dialog();
            try
            {
               
                //check if add or edit
                if (textBox1.Text == "")
                {
                    dialog.Width = this.Width;
                    dialog.txt.Text = "Nom de fournisseur requis";
                    dialog.Show();
                }
                else
                {
                    //check if add or edit
                    if (id == 0)
                    {
                        //Add 
                        //Pur
                        pur.Désignation = textBox1.Text;
                        pur.Catégorie = edt_cat.Text;
                        pur.Fournisseur = edt_fou.Text;
                        pur.Poids = Convert.ToDouble(edt_poid.Text);
                        pur.Prix_U_H_T = Convert.ToDouble(edt_uht.Text);
                        pur.T_V_A = Convert.ToDouble(edt_tva.Text);
                        pur.Quantité = Convert.ToDouble(edt_qte.Value);
                        pur.Total_H_T = Convert.ToDouble(edt_THT.Text);
                        pur.Total_T_C = Convert.ToDouble(edt_TTC.Text);
                        pur.Total_T_V_A = Convert.ToDouble(edt_TTVA.Text);
                        db.Purchase.Add(pur);
                        //Stock
                        sto.Désignation = textBox1.Text;
                        sto.Catégorie = edt_cat.Text;
                        sto.Fournisseur = edt_fou.Text;
                        sto.Poids = Convert.ToDouble(edt_poid.Text);
                        sto.Prix_U_H_T = Convert.ToDouble(edt_uht.Text);
                        sto.T_V_A = Convert.ToDouble(edt_tva.Text);
                        sto.Quantité = Convert.ToDouble(edt_qte.Value);
                        sto.Total_H_T = Convert.ToDouble(edt_THT.Text);
                        sto.Total_T_C = Convert.ToDouble(edt_TTC.Text);
                        sto.Total_T_V_A = Convert.ToDouble(edt_TTVA.Text);
                        db.stock.Add(sto);
                        db.SaveChanges();
                        toast.txt.Text = "Achat effectué";
                        toast.Show();
                        this.Close();
                    }
                    else
                    {
                        //Edit
                        pur.id_pur = id;
                        pur.Désignation = textBox1.Text;
                        pur.Catégorie = edt_cat.Text;
                        pur.Fournisseur = edt_fou.Text;
                        pur.Poids = Convert.ToDouble(edt_poid.Text);
                        pur.Prix_U_H_T = Convert.ToDouble(edt_uht.Text);
                        pur.T_V_A = Convert.ToDouble(edt_tva.Text);
                        pur.Quantité = Convert.ToDouble(edt_qte.Value);
                        pur.Total_H_T = Convert.ToDouble(edt_THT.Text);
                        pur.Total_T_C = Convert.ToDouble(edt_TTC.Text);
                        pur.Total_T_V_A = Convert.ToDouble(edt_TTVA.Text);
                        db.Entry(pur).State = System.Data.Entity.EntityState.Modified;


                        sto.id_sto = id;
                        sto.Désignation = textBox1.Text;
                        sto.Catégorie = edt_cat.Text;
                        sto.Fournisseur = edt_fou.Text;
                        sto.Poids = Convert.ToDouble(edt_poid.Text);
                        sto.Prix_U_H_T = Convert.ToDouble(edt_uht.Text);
                        sto.T_V_A = Convert.ToDouble(edt_tva.Text);
                        sto.Quantité = Convert.ToDouble(edt_qte.Value);
                        sto.Total_H_T = Convert.ToDouble(edt_THT.Text);
                        sto.Total_T_C = Convert.ToDouble(edt_TTC.Text);
                        sto.Total_T_V_A = Convert.ToDouble(edt_TTVA.Text);
                        db.Entry(sto).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        toast.txt.Text = "Achat a été Modifier";
                        toast.Show();
                        this.Close();
                    }
                }
            }
            catch
            {
                dialog.Width = this.Width;
                dialog.txt.Text = "erreur de la saisie";
                dialog.Show();
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_pur_add_Activated(object sender, EventArgs e)
        {
            edt_cat.DataSource = db.Catégorie.Select(x => x.nom_cat).ToList();
            edt_fou.DataSource = db.Fournisseurs.Select(x => x.nom_four).ToList();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_cat_add fca = new frm_cat_add();
            fca.id = 0;
            fca.simpleButton1.Text = "Ajouter";
            fca.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_fou_add ffa = new frm_fou_add();
            ffa.id = 0;
            ffa.simpleButton1.Text = "Ajouter";
            ffa.Show();
        }

        private void pro_cal()
        {
            
            uht = Convert.ToDouble(edt_uht.Text);
            tva = Convert.ToDouble(edt_tva.Text);
            poids = Convert.ToDouble(edt_poid.Text);
            qte = Convert.ToDouble(edt_qte.Value);
            tht = uht * qte * poids;
            ttva = tht * (tva/100);
            ttc = tht + ttva;
            edt_THT.Text = tht.ToString();
            edt_TTVA.Text = ttva.ToString();
            edt_TTC.Text = ttc.ToString();
        }
    }
}
