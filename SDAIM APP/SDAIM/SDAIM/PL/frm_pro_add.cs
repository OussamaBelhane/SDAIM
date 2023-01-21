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
    public partial class frm_pro_add : Form
    {
        //init 
        SDAIMEntities db = new SDAIMEntities();
        Project pro = new Project();
        Project_info proi = new Project_info();
        Purchase pur = new Purchase();
        stock sto = new stock();
        BL.Methods methods = new BL.Methods();
        toast toast = new toast();
        Dialog dialog = new Dialog();
        double qtp, qtn,qtr;

        public int id;
        
        public frm_pro_add()
        {
            InitializeComponent();
        }


        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            sto = db.stock.Where(x => x.Désignation == comboBox2.Text).FirstOrDefault();
            edt_Ttc.Text = sto.Total_T_C.ToString();
            edt_Tqte.Text = sto.Quantité.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            toast toast = new toast();
            Dialog dialog = new Dialog();
            //check if add or edit
            qtp = Convert.ToDouble(edt_Tqte.Text);
            qtn = Convert.ToDouble(edt_qte.Text);
            qtr = qtp - qtn;

            if (comboBox1.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt.Text = "Nom de projet requis";
                dialog.Show();
            }
            else
            {
                //check if add or edit
                if (id == 0)
                {
                    if(qtr >=0)
                    {
                        //Add
                        proi = db.Project_info.Where(x => x.pro_nom == comboBox1.Text).FirstOrDefault();
                        
                        pro.pro_nom = comboBox1.Text;
                        pro.pro_désignation = comboBox2.Text;
                        pro.pro_qte = Convert.ToDouble(edt_qte.Value);
                        pro.pro_ttc = Convert.ToDouble(edt_Ttc.Text);
                        pro.pro_date = proi.pro_date;
                        db.Project.Add(pro);
                        sto.Quantité = qtr;
                        db.Entry(sto).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        toast.txt.Text = "projet ajouté";
                        toast.Show();
                        this.Close();
                    }
                    else
                    {
                        label3.Visible = true;
                    }
                    
                }
                else
                {
                    //Edit

                    pro.id_pro = id;
                    pro.pro_nom = comboBox1.Text;
                    pro.pro_désignation = comboBox2.Text;
                    pro.pro_qte = Convert.ToDouble(edt_qte.Value);
                    pro.pro_ttc = Convert.ToDouble(edt_Ttc.Text);
                    db.Project.Add(pro);
                    db.Entry(pro).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt.Text = "le projet a été modifié";
                    toast.Show();
                    this.Close();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_pur_add_Activated(object sender, EventArgs e)
        {

            var rs1 = db.Project_info.Select(x => x.pro_nom).ToList();
            var rs2 = db.Purchase.Select(x => x.Désignation).ToList();
            comboBox1.DataSource = rs1;
            comboBox2.DataSource = rs2;

            AutoCompleteStringCollection acsc1 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection acsc2 = new AutoCompleteStringCollection();
            acsc1.AddRange(rs1.ToArray());
            acsc2.AddRange(rs2.ToArray());
            comboBox1.AutoCompleteCustomSource = acsc1;
            comboBox2.AutoCompleteCustomSource = acsc2;

            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_pro_add2 fca = new frm_pro_add2();
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

       
    }
}
