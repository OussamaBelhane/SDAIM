using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using SDAIM.EPL;

namespace SDAIM.PL
{
    public partial class frmcat : Form
    {
        SDAIMEntities db = new SDAIMEntities();
        Catégorie catégorie = new Catégorie();
        toast toast = new toast();
        Dialog dialog = new Dialog();
        BL.Methods methods = new BL.Methods();
        int id;
        public frmcat()
        {
            InitializeComponent();
            SDAIM.SDAIMEntities dbContext = new SDAIM.SDAIMEntities();
            dbContext.Catégorie.LoadAsync().ContinueWith(loadTask =>
            {
    gridControl1.DataSource = dbContext.Catégorie.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_cat_add fca = new frm_cat_add();
            fca.id = 0;
            fca.simpleButton1.Text = "Ajouter";
            fca.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Update_data();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            toast toast = new toast();
            Dialog dialog = new Dialog();
            try
            {
                
                id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("id_cat"));
                var rs = MessageBox.Show("Êtes-vous sûr de vouloir supprimer définitivement cette catégorie ? ", "supprimer la catégorie", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    catégorie = db.Catégorie.Where(x => x.id_cat == id).FirstOrDefault();
                    db.Entry(catégorie).State = EntityState.Deleted;
                    db.SaveChanges();
                    Update_data();
                    toast.txt.Text = "Catégorie supprimée";
                    toast.Show();
                }
                
                
            }
            catch
            {
                dialog.txt.Text = "pas de catégorie !";
                dialog.Width = 600;
                dialog.Height = 100;
                dialog.BackColor = Color.White;


                dialog.Show();
            }

            
            
        }

        private void Update_data()
        {
            db = new SDAIMEntities();
            gridControl1.DataSource = db.Catégorie.ToList();
        }
        //edit
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frm_cat_add fca = new frm_cat_add();
            id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("id_cat"));
            catégorie = db.Catégorie.Where(x => x.id_cat == id).FirstOrDefault();
            fca.textBox1.Text = catégorie.nom_cat.ToString();
            methods.by = catégorie.image_cat;
            fca.pictureEdit1.Image = Image.FromStream(methods.convert_image());

            fca.id = id;
            fca.simpleButton1.Text = "Modifier";
            fca.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var _search = edt_search.Text;
            gridControl1.DataSource = db.Catégorie.Where(x => x.nom_cat.Contains(_search)).ToList();
        }

        private void edt_search_TextChanged(object sender, EventArgs e)
        {
            var _search = edt_search.Text;
            if (_search == "")
            {
                Update_data();
            }
        }
    }
}
