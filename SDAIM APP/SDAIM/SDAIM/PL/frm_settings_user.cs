using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Windows.Forms;
using SDAIM.EPL;

namespace SDAIM.PL
{
    public partial class frm_settings_user : Form
    {
        public frm_settings_user()
        {
            InitializeComponent();
        }
        SDAIMEntities db = new SDAIMEntities();
        user u = new user();
        int id;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                toast toast = new toast();
                Dialog dialog = new Dialog();
                var a = db.user.Where(x => x.user1 == textBox1.Text && x.pwd == textBox2.Text);
                id = a.Select(x => x.id_user).FirstOrDefault();
                if (a.Count() > 0)
                {
                    if (textBox3.Text == textBox4.Text)
                    {
                        u.id_user = id;
                        u.user1 = textBox1.Text;
                        u.pwd = textBox3.Text;
                        db.user.Add(u);
                        db.Entry(u).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        toast.txt.Text = "password update";
                        toast.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("the password does not match!");
                    }
                }
                else
                {
                    MessageBox.Show("invalid user");
                }
            }
            catch
            {

            }




        }

        private void colorPickEdit1_EditValueChanged(object sender, EventArgs e)
        {


        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void frm_settings_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            toast toast = new toast();
            Dialog dialog = new Dialog();
            var a = db.user.Where(x => x.user1 == "admin" && x.pwd == "admin");
            if (a.Count() > 0)
            {
                if (textBox3.Text == textBox4.Text)
                {

                    toast.txt.Text = "done";
                    toast.Show();
                }
                else
                {
                    u.user1 = "admin";
                    u.pwd = "admin";
                    db.user.Add(u);
                    db.SaveChanges();
                    toast.txt.Text = "done";
                    toast.Show();
                }
            }
        }
    }
}
