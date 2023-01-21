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
    public partial class frm_emp_add : Form
    {
        //init 
        SDAIMEntities db = new SDAIMEntities();
        Employés emp = new Employés();
        BL.Methods methods = new BL.Methods();
        toast toast = new toast();
        Dialog dialog = new Dialog();

        public int id;
        public frm_emp_add()
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
                    emp.Nom = textBox1.Text;
                    emp.Prénom = textBox2.Text;
                    emp.num_tel = textBox3.Text;
                    emp.CIN = textBox4.Text;
                    emp.Département = edt_emp.Text;
                    emp.image_emp = methods.convert_byte();
                    db.Employés.Add(emp);
                    db.SaveChanges();
                    toast.txt.Text = "Le fournisseur a été ajouté";
                    toast.Show();
                    this.Close();
                }
                else
                {
                    // Edit
                    pictureEdit1.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    emp.id_employé = id;
                    emp.Nom = textBox1.Text;
                    emp.Prénom = textBox2.Text;
                    emp.num_tel = textBox3.Text;
                    emp.CIN = textBox4.Text;
                    emp.Département = edt_emp.Text;
                    emp.image_emp = methods.convert_byte();
                    db.Entry(emp).State = EntityState.Modified;
                    db.SaveChanges();
                    toast.txt.Text = "Le fournisseur a été changé";
                    toast.Show();
                    this.Close();
                }
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void edt_fou_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
    }
}
