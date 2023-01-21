using SDAIM.EPL;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SDAIM.PL
{

    public partial class frm_pur : Form
    {
        SDAIMEntities db = new SDAIMEntities();
        Purchase pur = new Purchase();
        stock sto = new stock();
        toast toast = new toast();
        Dialog dialog = new Dialog();
        BL.Methods methods = new BL.Methods();

        int id;
        public frm_pur()
        {
            InitializeComponent();




            
            SDAIM.SDAIMEntities dbContext = new SDAIM.SDAIMEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.Purchase.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.Purchase.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        private void Update_data()
        {
            db = new SDAIMEntities();
            gridControl1.DataSource = db.Purchase.ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_pur_add ffa = new frm_pur_add();
            ffa.id = 0;
            ffa.simpleButton1.Text = "Ajouter";
            ffa.Show();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frm_pur_add frm_add = new frm_pur_add();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id_pur"));
            pur = db.Purchase.Where(x => x.id_pur == id).FirstOrDefault();
            frm_add.textBox1.Text = pur.Désignation;
            frm_add.edt_cat.Text = pur.Catégorie;
            frm_add.edt_fou.Text = pur.Fournisseur;
            frm_add.edt_poid.Text = pur.Poids.ToString();
            frm_add.edt_uht.Text = pur.Prix_U_H_T.ToString();
            frm_add.edt_tva.Text = pur.T_V_A.ToString();
            frm_add.edt_qte.Text = pur.Quantité.ToString();
            frm_add.edt_TTC.Text = pur.Total_T_C.ToString();
            frm_add.edt_THT.Text = pur.Total_H_T.ToString();
            frm_add.edt_TTVA.Text = pur.Total_T_V_A.ToString();
            frm_add.id = id;
            frm_add.simpleButton1.Text = "Modifier";
            frm_add.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            toast toast = new toast();
            Dialog dialog = new Dialog();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id_pur"));
            if (id > 0)
            {
                try
                {


                    var rs = MessageBox.Show("Êtes-vous sûr de vouloir supprimer définitivement cet achat ?", "Supprimer l'achat", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        pur = db.Purchase.Where(x => x.id_pur == id).FirstOrDefault();
                        db.Entry(pur).State = EntityState.Deleted;
                        db.SaveChanges();
                        Update_data();
                        toast.txt.Text = "Achat a été Supprimer";
                        toast.Show();
                    }


                }
                catch
                {

                }
            }
            else
            {
                dialog.txt.Text = "pas d'achat !";
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
