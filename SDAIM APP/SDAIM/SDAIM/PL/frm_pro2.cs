using SDAIM.EPL;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SDAIM.PL
{

    public partial class frm_pro2 : Form
    {
        SDAIMEntities db = new SDAIMEntities();
        project_p prop = new project_p();
        toast toast = new toast();
        Dialog dialog = new Dialog();
        BL.Methods methods = new BL.Methods();

        int id;
        public frm_pro2()
        {
            InitializeComponent();
            SDAIM.SDAIMEntities dbContext = new SDAIM.SDAIMEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.project_p.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.project_p.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        private void Update_data()
        {
            db = new SDAIMEntities();
            gridControl1.DataSource = db.project_p.ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_pro2_add ffa = new frm_pro2_add();
            ffa.id = 0;
            ffa.simpleButton1.Text = "Ajouter";
            ffa.Show();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frm_pro2_add frm_add = new frm_pro2_add();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id_ppro"));
            prop = db.project_p.Where(x => x.id_ppro == id).FirstOrDefault();
            frm_add.id = id;
            frm_add.simpleButton1.Text = "Modifier";
            frm_add.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            toast toast = new toast();
            Dialog dialog = new Dialog();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id_ppro"));
            if (id > 0)
            {
                try
                {


                    var rs = MessageBox.Show("Êtes-vous sûr de vouloir supprimer définitivement ce projet ?", "Supprimer le projet", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        prop = db.project_p.Where(x => x.id_ppro == id).FirstOrDefault();
                        db.Entry(prop).State = EntityState.Deleted;
                        db.SaveChanges();
                        Update_data();
                        toast.txt.Text = "le projet a été supprimé";
                        toast.Show();
                    }


                }
                catch
                {

                }
            }
            else
            {
                dialog.txt.Text = "aucun projet!";
                dialog.Width = 600;
                dialog.Height = 100;
                dialog.BackColor = Color.White;


                dialog.Show();
            }
            
            
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            var _search = edt_search.Text;
            gridControl1.DataSource = db.project_p.Where(x => x.nom_ppro.Contains(_search)).ToList();
        }

        private void edt_search_TextChanged(object sender, EventArgs e)
        {
            var _search = edt_search.Text;
            if (_search == "")
            {
                Update_data();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Update_data();
        }
    }
}
