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
    public partial class frm_fou_add : Form
    {
        //init 
        SDAIMEntities db = new SDAIMEntities();
        Fournisseurs fou = new Fournisseurs();
        BL.Methods methods = new BL.Methods();
        toast toast = new toast();
        Dialog dialog = new Dialog();

        public int id;
        public frm_fou_add()
        {
            InitializeComponent();
        }

        private void frm_fou_add_Load(object sender, EventArgs e)
        {
            
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            toast toast = new toast();
            Dialog dialog = new Dialog();
            //check if add or edit
            if (textBox1.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt.Text = "Nom de fournisseur requis";
                dialog.Show();
            }
            else
            {
                //check if add or edit
                if (id == 0)
                {
                    // Add
                    pictureEdit1.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    fou.nom_four = textBox1.Text;
                    fou.phone_four = textBox2.Text;
                    fou.email_four = textBox3.Text;
                    fou.image_four = methods.convert_byte();
                    db.Fournisseurs.Add(fou);
                    db.SaveChanges();
                    toast.txt.Text = "add fournisseur ";
                    toast.Show();
                    this.Close();
                }
                else
                {
                    // Edit
                    pictureEdit1.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    fou.id_four = id;
                    fou.nom_four = textBox1.Text;
                    fou.phone_four = textBox2.Text;
                    fou.email_four = textBox3.Text;
                    fou.image_four = methods.convert_byte();
                    db.Entry(fou).State = EntityState.Modified;
                    db.SaveChanges();
                    toast.txt.Text = "edit";
                    toast.Show();
                    this.Close();
                }
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
