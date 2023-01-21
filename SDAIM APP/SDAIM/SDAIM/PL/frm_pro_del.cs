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
    public partial class frm_pro_del : Form
    {
        //init 
        SDAIMEntities db = new SDAIMEntities();
        Project_info proi = new Project_info();
        Project pro = new Project();
        BL.Methods methods = new BL.Methods();
        toast toast = new toast();
        Dialog dialog = new Dialog();
        double uht, tva, poids, qte, tht, ttva, ttc;

        public int id;
        public frm_pro_del()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DataSource = db.Project_info.ToList();
            comboBox1.DisplayMember = "pro_nom";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            toast toast = new toast();
            Dialog dialog = new Dialog();
                try
                {


                var rs = MessageBox.Show("Êtes-vous sûr de vouloir supprimer définitivement ce projet ?", "Supprimer le projet", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                    {
                        proi = db.Project_info.Where(x => x.pro_nom == comboBox1.Text).FirstOrDefault();
                        db.Entry(proi).State = EntityState.Deleted;
                        db.SaveChanges();
                    toast.txt.Text = "le projet a été supprimé";
                    toast.Show();
                    }


                }
                catch
                {
                dialog.txt.Text = "aucun projet!";
                dialog.Width = 600;
                dialog.Height = 100;
                dialog.BackColor = Color.White;


                dialog.Show();
                }
            
            
        }

        private void frm_fou_add_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = db.Project_info.ToList();
            comboBox1.DisplayMember = "pro_nom";

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

       

       

        

       

      

        
    }
}
