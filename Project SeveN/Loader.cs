using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SeveN
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMInimize_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            flowLayoutPanel1.Width += 3;

            if (flowLayoutPanel1.Width >= 719 ) 
            {
                timer1.Stop();
                MAIN main = new MAIN();
                this.Hide();
                main.Show();
            }
        }
    }
}
