using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDAIM.PL;
using SDAIM.EPL;

namespace SDAIM
{
    public partial class Main : Form
    {
        frm_home frm_home = new frm_home();
        frmcat frmcat = new frmcat();
        frm_fou frmfou = new frm_fou();
        frm_pur frmpur = new frm_pur();
        frm_emp frmemp = new frm_emp();
        frm_sal frmsal = new frm_sal();
        frm_pro frmpro = new frm_pro();
        frm_sto frmsto = new frm_sto();
        frm_pro2 frmpro2 = new frm_pro2();
        SDAIMEntities db = new SDAIMEntities();
        
        
        public Main()
        {
            InitializeComponent();
        }
        
        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            pnl_cont.Controls.Clear();
            pnl_cont.Controls.Add(frm_home.panel1);
            int cat = db.Catégorie.Count();
            int fou = db.Fournisseurs.Count();
            int pur = db.Purchase.Count();
            int pro = db.Project_info.Count();
            int emp = db.Employés.Count();

            frm_home.label2.Text = cat.ToString();
            frm_home.label3.Text = fou.ToString();
            frm_home.label5.Text = pur.ToString();
            frm_home.label13.Text = pro.ToString();
            frm_home.label14.Text = emp.ToString();
            var stoqte = db.stock.Count();
            if (stoqte != 0)
            {
                var sto = db.stock.Sum(x => x.Quantité);
                frm_home.label15.Text = sto.ToString();
            }
            else
            {
                frm_home.label15.Text = "0";
            }
                            
        }
        

        private void guna2ImageButton2_Click_1(object sender, EventArgs e)
        {
            if (guna2Panel1.Width == 250)
            {
                guna2Panel1.Width = 45;
                panel10.Visible = false;
            }
            else
            {
                guna2Panel1.Width = 250;
                panel10.Visible = true;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            simpleButton1.ForeColor = Properties.Settings.Default.Formforecolor;
            simpleButton2.ForeColor = Properties.Settings.Default.Formforecolor;
            simpleButton3.ForeColor = Properties.Settings.Default.Formforecolor;
            simpleButton4.ForeColor = Properties.Settings.Default.Formforecolor;
            simpleButton5.ForeColor = Properties.Settings.Default.Formforecolor;
            simpleButton6.ForeColor = Properties.Settings.Default.Formforecolor;
            simpleButton7.ForeColor = Properties.Settings.Default.Formforecolor;
            simpleButton8.ForeColor = Properties.Settings.Default.Formforecolor;
            simpleButton10.ForeColor = Properties.Settings.Default.Formforecolor;
            simpleButton12.ForeColor = Properties.Settings.Default.Formforecolor;
            guna2Panel1.BackColor = Properties.Settings.Default.Formbackcolor;
            pnl_cont.Controls.Clear();
            pnl_cont.Controls.Add(frm_home.panel1);
            int cat = db.Catégorie.Count();
            int fou = db.Fournisseurs.Count();
            int pur = db.Purchase.Count();
            int pro = db.Project_info.Count();
            int emp = db.Employés.Count();
            
            frm_home.label2.Text = cat.ToString();
            frm_home.label3.Text = fou.ToString();
            frm_home.label5.Text = pur.ToString();
            frm_home.label13.Text = pro.ToString();
            frm_home.label14.Text = emp.ToString();
            var stoqte = db.stock.Count();
            if(stoqte!=0)
            {
                var sto = db.stock.Sum(x => x.Quantité);
                frm_home.label15.Text = sto.ToString();
            }
            else
            {
                frm_home.label15.Text = "0";
            }

            
            

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            pnl_cont.Controls.Clear();
            pnl_cont.Controls.Add(frmcat.panel1);
            db = new SDAIMEntities();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            pnl_cont.Controls.Clear();
            pnl_cont.Controls.Add(frmfou.panel1);
            db = new SDAIMEntities();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            pnl_cont.Controls.Clear();
            pnl_cont.Controls.Add(frmpur.panel1);
            db = new SDAIMEntities();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            pnl_cont.Controls.Clear();
            pnl_cont.Controls.Add(frmemp.panel1);
            db = new SDAIMEntities();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            pnl_cont.Controls.Clear();
            pnl_cont.Controls.Add(frmsal.panel1);
            db = new SDAIMEntities();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            pnl_cont.Controls.Clear();
            pnl_cont.Controls.Add(frmpro.panel1);
            db = new SDAIMEntities();
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            pnl_cont.Controls.Clear();
            pnl_cont.Controls.Add(frmsto.panel1);
            db = new SDAIMEntities();
        }

        

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            frm_settings frmset = new frm_settings();
            frmset.Show();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

      

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            pnl_cont.Controls.Clear();
            pnl_cont.Controls.Add(frmpro2.panel1);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            pnl_cont.Controls.Clear();
            pnl_cont.Controls.Add(frm_home.panel1);
            int cat = db.Catégorie.Count();
            int fou = db.Fournisseurs.Count();
            int pur = db.Purchase.Count();
            int pro = db.Project_info.Count();
            int emp = db.Employés.Count();

            frm_home.label2.Text = cat.ToString();
            frm_home.label3.Text = fou.ToString();
            frm_home.label5.Text = pur.ToString();
            frm_home.label13.Text = pro.ToString();
            frm_home.label14.Text = emp.ToString();
            var stoqte = db.stock.Count();
            if (stoqte != 0)
            {
                var sto = db.stock.Sum(x => x.Quantité);
                frm_home.label15.Text = sto.ToString();
            }
            else
            {
                frm_home.label15.Text = "0";
            }
        }
    }
}
