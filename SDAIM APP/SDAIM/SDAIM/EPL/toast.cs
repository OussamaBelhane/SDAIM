using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDAIM.EPL
{
    public partial class toast : Form
    {
        public toast()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
