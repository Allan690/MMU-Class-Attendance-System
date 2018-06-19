using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMUSIS1
{
    public partial class formError : Form
    {
        public formError()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox1.Enabled = true;
        }

        private void formError_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
           timer1.Stop();
           metroButton1.Visible = true;
         //   metroButton2.Visible = true;
        }
    }
}
