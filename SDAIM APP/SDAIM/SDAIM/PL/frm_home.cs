using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDAIM.PL
{
    public partial class frm_home : Form
    {
        SDAIMEntities db = new SDAIMEntities();
        public frm_home()
        {
            InitializeComponent();
        }

      

        

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            frm_cat_add fca = new frm_cat_add();
            fca.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frm_fou_add ffa = new frm_fou_add();
            ffa.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frm_pur_add ffa = new frm_pur_add();
            ffa.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            frm_pro_add ffa = new frm_pro_add();
            ffa.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            frm_emp_add ffa = new frm_emp_add();
            ffa.Show();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            frm_sal_add ffa = new frm_sal_add();
            ffa.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        
        private void frm_home_Load(object sender, EventArgs e)
        {
            int cat = db.Catégorie.Count();
            label2.Text = cat.ToString();
        }
       
    }
}
