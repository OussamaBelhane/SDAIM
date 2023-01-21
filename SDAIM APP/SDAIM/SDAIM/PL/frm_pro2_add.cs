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
    public partial class frm_pro2_add : Form
    {
        //init 
        SDAIMEntities db = new SDAIMEntities();
        Project_m prom = new Project_m();
        project_p prop = new project_p();
        BL.Methods methods = new BL.Methods();
        toast toast = new toast();
        Dialog dialog = new Dialog();
        double g,pt;
        public int id;

        public frm_pro2_add()
        {
            InitializeComponent();
            SDAIM.SDAIMEntities dbContext = new SDAIM.SDAIMEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.Project_m.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.Project_m.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }


        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sto = db.stock.Where(x => x.Désignation == comboBox2.Text).FirstOrDefault();
            //edt_Ttc.Text = sto.Total_T_C.ToString();
            //edt_Tqte.Text = sto.Quantité.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            toast toast = new toast();
            Dialog dialog = new Dialog();
            //check if add or edit

            
            
                //check if add or edit
                if (id == 0)
                {
                //Add
                var promp = db.Project_m.Where(x => x.nomp_mpro == comboBox1.Text).ToList();
                var sum = promp.Sum(x => x.prix_mpro);
                double t = Convert.ToDouble(sum);
                g = t * (0.25);
                pt = g + t;
                prop.nom_ppro = comboBox1.Text;
                prop.p_ppro = Convert.ToDouble(sum.ToString());
                prop.g_ppro = Convert.ToDouble(g);
                prop.pt_ppro = Convert.ToDouble(pt);
                prop.date_ppro = dateTimePicker1.Value;
                db.project_p.Add(prop);
                db.SaveChanges();
                toast.txt.Text = "Succès";
                toast.Show();
                this.Close();
                }
                else
                {
                //Edit
                var promp = db.Project_m.Where(x => x.nomp_mpro == comboBox1.Text).ToList();
                var sum = promp.Sum(x => x.prix_mpro);
                double t = Convert.ToDouble(sum);
                g = t * (0.25);
                pt = g + t;
                prop.id_ppro = id;
                prop.nom_ppro = comboBox1.Text;
                prop.p_ppro = Convert.ToDouble(sum.ToString());
                prop.g_ppro = Convert.ToDouble(g);
                prop.pt_ppro = Convert.ToDouble(pt);
                prop.date_ppro = dateTimePicker1.Value;
                db.project_p.Add(prop);
                db.Entry(prop).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                toast.txt.Text = "Modifié";
                toast.Show();
                this.Close();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_pur_add_Activated(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "nom";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = db.Project_info.Select(x => new { nom = x.pro_nom, id = x.id_proi }).ToList();
            
            
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            toast toast = new toast();
            Dialog dialog = new Dialog();
            if (textBox1.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt.Text = "Nom  requis";
                dialog.Show();
            }
            else
            {
                //Add
                
                prom.nomp_mpro = comboBox1.Text;
                prom.nom_mpro = textBox1.Text;
                prom.prix_mpro = Convert.ToDouble(edt_qte.Value);
                prom.date_mpro = dateTimePicker1.Value;
                db.Project_m.Add(prom);
                db.SaveChanges();
                Update_data();
            }
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_pro_add2 fca = new frm_pro_add2();
            fca.id = 0;
            fca.simpleButton1.Text = "Ajouter";
            fca.Show();
        }

       

        
        private void Update_data()
        {
            db = new SDAIMEntities();
            gridControl1.DataSource = db.Project_m.ToList();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Dialog dialog = new Dialog();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id_mpro"));
            if (id > 0)
            {
                try
                {
                    prom = db.Project_m.Where(x => x.id_mpro == id).FirstOrDefault();
                    db.Entry(prom).State = EntityState.Deleted;
                    db.SaveChanges();
                    Update_data();
                }
                catch
                {

                }
            }
            else
            {
                dialog.txt.Text = "erreur !";
                dialog.Width = 600;
                dialog.Height = 100;
                dialog.BackColor = Color.White;
                dialog.Show();
            }
        }
    }
}
