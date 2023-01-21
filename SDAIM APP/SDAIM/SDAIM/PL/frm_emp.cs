using SDAIM.EPL;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SDAIM.PL
{

    public partial class frm_emp : Form
    {
        SDAIMEntities db = new SDAIMEntities();
        Employés emp = new Employés();
        toast toast = new toast();
        Dialog dialog = new Dialog();
        BL.Methods methods = new BL.Methods();

        int id;
        public frm_emp()
        {
            InitializeComponent();

            SDAIM.SDAIMEntities dbContext = new SDAIM.SDAIMEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.Employés.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.Employés.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        private void Update_data()
        {
            db = new SDAIMEntities();
            gridControl1.DataSource = db.Employés.ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_emp_add ffa = new frm_emp_add();
            ffa.id = 0;
            ffa.simpleButton1.Text = "Ajouter";
            ffa.Show();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frm_emp_add ffa = new frm_emp_add();
            id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("id_employé"));
            emp = db.Employés.Where(x => x.id_employé == id).FirstOrDefault();
            ffa.textBox1.Text = emp.Nom.ToString();
            ffa.textBox2.Text = emp.Prénom.ToString();
            ffa.textBox3.Text = emp.num_tel.ToString();
            ffa.textBox4.Text = emp.CIN.ToString();
            ffa.edt_emp.Text = emp.Département.ToString();
            methods.by = emp.image_emp;
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

                id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("id_employé"));
                var rs = MessageBox.Show("Êtes-vous sûr de vouloir supprimer définitivement cet employé ?", "Supprimer l'employé", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    emp = db.Employés.Where(x => x.id_employé == id).FirstOrDefault();
                    db.Entry(emp).State = EntityState.Deleted;
                    db.SaveChanges();
                    Update_data();
                    toast.txt.Text = "l'employé a été supprimé";
                    toast.Show();
                }


            }
            catch
            {
                dialog.txt.Text = "pas d'employés !";
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
