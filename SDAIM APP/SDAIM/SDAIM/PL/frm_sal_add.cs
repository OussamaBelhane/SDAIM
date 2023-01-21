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
    public partial class frm_sal_add : Form
    {
        //init 
        SDAIMEntities db = new SDAIMEntities();
        Salaire sal = new Salaire();
        BL.Methods methods = new BL.Methods();
        toast toast = new toast();
        Dialog dialog = new Dialog();
        double ph, nh, th,nj,dj;

        public int id;
        public string Gender;
        public frm_sal_add()
        {
            InitializeComponent();
        }

        private void frm_fou_add_Load(object sender, EventArgs e)
        {
            edt_pre.DataSource = db.Employés.Select(x => x.Prénom).ToList();
            edt_pre.Height = 35;
            var a = db.Employés.Where(x => x.Prénom == edt_pre.Text).FirstOrDefault();
            textBox1.Text = a.Nom;

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender =  "Par heure";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Fixe";
            if (radioButton2.Checked)
            {
                label7.Text = "Prix"; 
                textBox2.Enabled = true;
                textBox3.Visible = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                edt_nbr.Enabled = false;
            }
            else
            {
                label7.Text = "Prix Heure";
                textBox2.Enabled = false;
                textBox3.Visible = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                edt_nbr.Enabled = true;
            }
        }

        private void edt_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = db.Employés.Where(x => x.Prénom == edt_pre.Text).FirstOrDefault();
            textBox1.Text = a.Nom;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            toast toast = new toast();
            Dialog dialog = new Dialog();
            try
            {
                
                //check if add or edit

                //check if add or edit
                if (id == 0)
                {
                    //Add
                    if (radioButton2.Checked)
                    {
                        var a = db.Employés.Where(x => x.Prénom == edt_pre.Text).FirstOrDefault();
                        sal.Prénom = edt_pre.Text;
                        sal.Nom = textBox1.Text;
                        sal.Département = a.Département;
                        sal.Type = "Fixe";
                        sal.Salaire1 = Convert.ToDouble(textBox2.Text);
                        db.Salaire.Add(sal);
                        db.SaveChanges();
                        toast.txt.Text = "Succès";
                        toast.Show();
                        this.Close();
                    }
                    else
                    {
                        sal.Prénom = edt_pre.Text;
                        sal.Nom = textBox1.Text;
                        sal.Type = "Par heure";
                        sal.Prix_h = Convert.ToDouble(textBox3.Text);
                        sal.nbr_h = Convert.ToDouble(edt_nbr.Value);
                        sal.Salaire1 = th;
                        db.Salaire.Add(sal);
                        db.SaveChanges();
                        toast.txt.Text = "Succès";
                        toast.Show();
                        this.Close();
                    }


                }
                else
                {
                    //Edit
                    if (radioButton2.Checked)
                    {
                        sal.id_salaire = id;
                        sal.Prénom = edt_pre.Text;
                        sal.Nom = textBox1.Text;
                        sal.Type = "Fixe";
                        sal.Salaire1 = th;
                        db.Entry(sal).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        toast.txt.Text = "modifié";
                        toast.Show();
                        this.Close();
                    }
                    else
                    {
                        sal.id_salaire = id;
                        sal.Prénom = edt_pre.Text;
                        sal.Nom = textBox1.Text;
                        sal.Type = "Par heure";
                        sal.Prix_h = ph;
                        sal.nbr_h = nh;
                        sal.Salaire1 = th;
                        db.Entry(sal).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        toast.txt.Text = "modifié";
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
            edt_pre.DataSource = db.Employés.Select(x => x.Nom).ToList();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_emp_add fca = new frm_emp_add();
            fca.id = 0;
            fca.simpleButton1.Text = "Ajouter";
            fca.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pro_cal();
            }
            catch { }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pro_cal();
            }
            catch { }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pro_cal();
            }
            catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pro_cal();
            }
            catch { }
        }

        private void edt_TH_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
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

            if (radioButton2.Checked)
            {
                th = Convert.ToDouble(textBox2.Text);
                edt_TH.Text = th.ToString();
            }
            else
            {
                ph = Convert.ToDouble(textBox3.Text);
                nh = Convert.ToDouble(edt_nbr.Value);
                nj = Convert.ToDouble(textBox4.Text);
                dj = Convert.ToDouble(textBox5.Text);
                th = (ph * nh)+(nj*dj);
                edt_TH.Text = th.ToString();
            }
            
    }
    }
}
