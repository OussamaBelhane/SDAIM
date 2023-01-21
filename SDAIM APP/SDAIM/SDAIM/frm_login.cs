using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDAIM;
using System.Threading;
using SDAIM.PL;

namespace SDAIM
{
    public partial class frm_login : Form
    {
        Thread th;
        SDAIMEntities db = new SDAIMEntities();
        public frm_login()
        {
            InitializeComponent();
        }
        public void openload(object obj)
        {
            Application.Run(new frm_loading());
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            if (Properties.Settings.Default.user!=string.Empty)
            {
                guna2TextBox1.Text = Properties.Settings.Default.user;
                guna2TextBox2.Text = Properties.Settings.Default.password;
            }
            
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (guna2CustomCheckBox1.Checked==true)
                {
                    Properties.Settings.Default.user = guna2TextBox1.Text;
                    Properties.Settings.Default.password = guna2TextBox2.Text;
                    Properties.Settings.Default.Save();
                    if (db.user.Where(x=>x.user1==guna2TextBox1.Text && x.pwd==guna2TextBox2.Text).Count()>0)
                    {
                        
                        this.Close();
                        th = new Thread(openload);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();

                    }
                    else
                    {
                        MessageBox.Show("invalid user");
                    }
                }
                if (guna2CustomCheckBox1.Checked == false)
                {
                    
                    if (db.user.Where(x => x.user1 == guna2TextBox1.Text && x.pwd == guna2TextBox2.Text).Count() > 0)
                    {
                        Properties.Settings.Default.user = "";
                        Properties.Settings.Default.password = "";
                        this.Close();
                        th = new Thread(openload);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }
                    else
                    {
                        MessageBox.Show("invalid user");
                    }
                }
                
                
            }
            catch
            {

            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_settings frmset = new frm_settings();
            frmset.Show();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                guna2Button1.PerformClick();
            }
        }

        private void frm_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button1.PerformClick();
            }
        }
    }
}
