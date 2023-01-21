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
    public partial class frm_cat_add : Form
    {
        //init 
        SDAIMEntities db = new SDAIMEntities();
        Catégorie cat = new Catégorie();
        BL.Methods methods = new BL.Methods();
        toast toast = new toast();
        Dialog dialog = new Dialog();
        PL.frmcat frm_cat = new frmcat();

        public int id;

        public frm_cat_add()
        {
            InitializeComponent();
        }
        //add or edit
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            toast toast = new toast();
            Dialog dialog = new Dialog();
            //check if add or edit
            if (textBox1.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt.Text = "Nom de catégorie requis";
                dialog.Show();
            }
            else
            {
                //check if add or edit
                if (id==0)
                {
                    // Add
                    pictureEdit1.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    cat.nom_cat = textBox1.Text;
                    cat.image_cat = methods.convert_byte();
                    db.Catégorie.Add(cat);
                    db.SaveChanges();
                    toast.txt.Text = "catégorie ajouté";
                    toast.Show();
                    db = new SDAIMEntities();
                    frm_cat.gridControl1.DataSource = db.Catégorie.ToList();
                    this.Close();
                }
                else
                {
                    // Edit
                    pictureEdit1.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    cat.nom_cat = textBox1.Text;
                    cat.id_cat = id;
                    cat.image_cat = methods.convert_byte();
                    db.Entry(cat).State = EntityState.Modified;
                    db.SaveChanges();
                    toast.txt.Text = "catégorie modifiée";
                    toast.Show();
                    db = new SDAIMEntities();
                    frm_cat.gridControl1.DataSource = db.Catégorie.ToList();
                    this.Close();
                }
                
            }
        }

        private void frm_cat_add_Load(object sender, EventArgs e)
        {

        }
    }
}
