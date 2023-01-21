using SDAIM.EPL;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SDAIM.PL
{

    public partial class frm_sto : Form
    {
        SDAIMEntities db = new SDAIMEntities();
        Purchase pur = new Purchase();
        stock sto = new stock();
        toast toast = new toast();
        Dialog dialog = new Dialog();
        BL.Methods methods = new BL.Methods();

        int id;
        public frm_sto()
        {
            InitializeComponent();
            SDAIM.SDAIMEntities dbContext = new SDAIM.SDAIMEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.stock.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.stock.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        private void Update_data()
        {
            db = new SDAIMEntities();
            gridControl1.DataSource = db.stock.ToList();
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

       


       

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Update_data();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            frm_pur_add ffa = new frm_pur_add();
            ffa.id = 0;
            ffa.simpleButton1.Text = "Ajouter";
            ffa.Show();
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            frm_pur_add frm_add = new frm_pur_add();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id_sto"));
            sto = db.stock.Where(x => x.id_sto == id).FirstOrDefault();
            frm_add.textBox1.Text = sto.Désignation;
            frm_add.edt_cat.Text = sto.Catégorie;
            frm_add.edt_fou.Text = sto.Fournisseur;
            frm_add.edt_poid.Text = sto.Poids.ToString();
            frm_add.edt_uht.Text = sto.Prix_U_H_T.ToString();
            frm_add.edt_tva.Text = sto.T_V_A.ToString();
            frm_add.edt_qte.Text = sto.Quantité.ToString();
            frm_add.edt_TTC.Text = sto.Total_T_C.ToString();
            frm_add.edt_THT.Text = sto.Total_H_T.ToString();
            frm_add.edt_TTVA.Text = sto.Total_T_V_A.ToString();
            frm_add.id = id;
            frm_add.simpleButton1.Text = "Modifier";
            frm_add.Show();
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            toast toast = new toast();
            Dialog dialog = new Dialog();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id_sto"));
            if (id > 0)
            {
                try
                {


                    var rs = MessageBox.Show("Voulez-vous vraiment supprimer cette achat de façon permanente ? ", "Supprimer l'achat", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        sto = db.stock.Where(x => x.id_sto == id).FirstOrDefault();
                        db.Entry(sto).State = EntityState.Deleted;
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

       
        private void btn_search_Click(object sender, EventArgs e)
        {
            var _search = edt_search.Text;
            gridControl1.DataSource = db.stock.Where(x => x.Désignation.Contains(_search) || x.Unité.Contains(_search) || x.Catégorie.Contains(_search) || x.Fournisseur.Contains(_search)).ToList();
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
