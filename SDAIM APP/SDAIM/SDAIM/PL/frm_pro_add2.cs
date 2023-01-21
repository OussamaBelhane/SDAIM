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
    public partial class frm_pro_add2 : Form
    {
        //init 
        SDAIMEntities db = new SDAIMEntities();
        Project_info proi = new Project_info();
        BL.Methods methods = new BL.Methods();
        toast toast = new toast();
        Dialog dialog = new Dialog();
        double uht, tva, poids, qte, tht, ttva, ttc;

        public int id;
        public frm_pro_add2()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frm_pro_del fpd = new frm_pro_del();
            fpd.Show();
        }

        private void frm_fou_add_Load(object sender, EventArgs e)
        {
            

        }

        private void edt_uht_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void edt_tva_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void edt_poid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void edt_qte_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            toast toast = new toast();
            Dialog dialog = new Dialog();

            proi.pro_nom = textBox1.Text;
            proi.pro_date = dateTimePicker1.Value;
            db.Project_info.Add(proi);
            db.SaveChanges();
            toast.txt.Text = "projet ajouté";
            toast.Show();
            this.Close();

        }
        

       

        

       

      

        
    }
}
