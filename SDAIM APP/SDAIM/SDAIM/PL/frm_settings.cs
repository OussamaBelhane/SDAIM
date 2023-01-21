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
using SDAIM.PL;

namespace SDAIM.PL
{
    public partial class frm_settings : Form
    {
        public frm_settings()
        {
            InitializeComponent();
        }
        frm_settings_user fsu = new frm_settings_user();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (colorPickEdit1.Enabled==false)
            {
                const string qu = "\"";
                var sv = textBox1.Text;
                var constr = @"metadata=res://*/SDAIMDM.csdl|res://*/SDAIMDM.ssdl|res://*/SDAIMDM.msl;provider=System.Data.SqlClient;provider connection string=" + qu + ";data source=" + sv + ";initial catalog=SDAIM;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework\";";

                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings["SDAIMEntities"].ConnectionString = constr;
                config.Save();
                ConfigurationManager.RefreshSection("connectionString");
                var strl = config.ConnectionStrings.ConnectionStrings["SDAIMEntities"].ConnectionString;
                MessageBox.Show(strl);
                Application.Restart();
            }
            else
            {
                Properties.Settings.Default.Formbackcolor = colorPickEdit1.Color;
                Properties.Settings.Default.Formforecolor = colorPickEdit2.Color;
                Properties.Settings.Default.Save();
                Application.Restart();
            }
            



        }

        private void colorPickEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_settings_Load(object sender, EventArgs e)
        {
            colorPickEdit1.Color = Properties.Settings.Default.Formbackcolor;
            colorPickEdit2.Color = Properties.Settings.Default.Formforecolor;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                colorPickEdit1.Enabled = true;
            }
            else
            {
                colorPickEdit1.Enabled = false;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Formbackcolor = Color.MidnightBlue;
            Properties.Settings.Default.Formforecolor = Color.Aqua;
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            
            fsu.Show();
            
        }
    }
}
