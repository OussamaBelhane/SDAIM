using SDAIM.EPL;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SDAIM.PL
{

    public partial class frm_fou : Form
    {
        SDAIMEntities db = new SDAIMEntities();
        Fournisseurs fou = new Fournisseurs();
        toast toast = new toast();
        Dialog dialog = new Dialog();
        BL.Methods methods = new BL.Methods();

        int id;
        public frm_fou()
        {
            InitializeComponent();

            SDAIM.SDAIMEntities dbContext = new SDAIM.SDAIMEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.Fournisseurs.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.Fournisseurs.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        private void Update_data()
        {
            db = new SDAIMEntities();
            gridControl1.DataSource = db.Fournisseurs.ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_fou_add ffa = new frm_fou_add();
            ffa.id = 0;
            ffa.simpleButton1.Text = "Ajouter";
            ffa.Show();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frm_fou_add ffa = new frm_fou_add();
            id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("id_four"));
            fou = db.Fournisseurs.Where(x => x.id_four == id).FirstOrDefault();
            ffa.textBox1.Text = fou.nom_four.ToString();
            ffa.textBox2.Text = fou.phone_four.ToString();
            ffa.textBox3.Text = fou.email_four.ToString();
            methods.by = fou.image_four;
            ffa.pictureEdit1.Image = Image.FromStream(methods.convert_image());
            ffa.id = id;
            ffa.simpleButton1.Text = "Modifier";
            ffa.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            toast toast = new toast();
            Dialog dialog = new Dialog();
            try
            {

                id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("id_four"));
                var rs = MessageBox.Show("Êtes-vous sûr de vouloir supprimer définitivement ce fournisseur ?", "Supprimer le fournisseur", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    fou = db.Fournisseurs.Where(x => x.id_four == id).FirstOrDefault();
                    db.Entry(fou).State = EntityState.Deleted;
                    db.SaveChanges();
                    Update_data();
                    toast.txt.Text = "fournisseur a été supprimé";
                    toast.Show();
                }


            }
            catch
            {
                dialog.txt.Text = "pas de fournisseur !";
                dialog.Width = 600;
                dialog.Height = 100;
                dialog.BackColor = Color.White;


                dialog.Show();
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            var _search = edt_search.Text;
            gridControl1.DataSource = db.Fournisseurs.Where(x => x.nom_four.Contains(_search) || x.phone_four.Contains(_search) || x.email_four.Contains(_search)).ToList();
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
