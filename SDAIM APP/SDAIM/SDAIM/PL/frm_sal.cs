using SDAIM.EPL;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SDAIM.PL
{

    public partial class frm_sal : Form
    {
        SDAIMEntities db = new SDAIMEntities();
        Salaire sal = new Salaire();
        toast toast = new toast();
        Dialog dialog = new Dialog();
        BL.Methods methods = new BL.Methods();

        int id;
        public frm_sal()
        {
            InitializeComponent();
            SDAIM.SDAIMEntities dbContext = new SDAIM.SDAIMEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.Salaire.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.Salaire.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        private void Update_data()
        {
            db = new SDAIMEntities();
            gridControl1.DataSource = db.Salaire.ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_sal_add ffa = new frm_sal_add();
            ffa.id = 0;
            ffa.simpleButton1.Text = "Ajouter";
            ffa.Show();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frm_sal_add frm_add = new frm_sal_add();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id_salaire"));
            sal = db.Salaire.Where(x => x.id_salaire == id).FirstOrDefault();
            frm_add.edt_pre.Text = sal.Prénom;
            frm_add.textBox1.Text = sal.Nom;
            frm_add.Gender = sal.Type;
            frm_add.id = id;
            frm_add.simpleButton1.Text = "Modifier";
            frm_add.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            toast toast = new toast();
            Dialog dialog = new Dialog();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id_salaire"));
            if (id > 0)
            {
                try
                {


                    var rs = MessageBox.Show("Êtes-vous sûr de vouloir supprimer définitivement ce salaire ?", "Supprimer le salaire", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        sal = db.Salaire.Where(x => x.id_salaire == id).FirstOrDefault();
                        db.Entry(sal).State = EntityState.Deleted;
                        db.SaveChanges();
                        Update_data();
                        toast.txt.Text = "le salaire était Supprimer";
                        toast.Show();
                    }


                }
                catch
                {

                }
            }
            else
            {
                dialog.txt.Text = "pas de salaire !";
                dialog.Width = 600;
                dialog.Height = 100;
                dialog.BackColor = Color.White;


                dialog.Show();
            }
            
            
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            var _search = edt_search.Text;
            gridControl1.DataSource = db.Purchase.Where(x => x.Désignation.Contains(_search) || x.Unité.Contains(_search) || x.Catégorie.Contains(_search) || x.Fournisseur.Contains(_search)).ToList();
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
