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
    public partial class UpdateSuccess : Form
    {
        public UpdateSuccess()
        {
           // bunifuCustomLabel1.Text = _message;
            InitializeComponent();
        }

        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
            icon_delay.Start();
            pictureBox1.Enabled = true;
        }
      
        private void icon_delay_Tick(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            icon_delay.Stop();
            metroButton1.Visible = true;
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateSuccess_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }
    }
}
