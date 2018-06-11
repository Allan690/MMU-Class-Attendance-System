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
    public partial class SplashScreen : Form
    {
        List<Color> colors = new List<Color>();
        int currentColor = 0;
        int a = 0;
        public SplashScreen()
        {
            InitializeComponent();
            colors.Add(Color.FromArgb(3, 169, 244));
            colors.Add(Color.FromArgb(0, 150, 136));
            colors.Add(Color.FromArgb(103, 58, 183));
            colors.Add(Color.FromArgb(156, 39, 176));
            colors.Add(Color.FromArgb(255, 87, 34));
            colors.Add(Color.FromArgb(255, 193, 7));
            colors.Add(Color.FromArgb(205, 220, 57));
        }
        public void CloseSplash()
        {
            Invoke((MethodInvoker)delegate
                {
                this.Close();
            });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (currentColor < colors.Count-1)
            {
                this.BackColor = Bunifu.Framework.UI.BunifuColorTransition.getColorScale(a, colors[currentColor], colors[currentColor + 1]);
                if (a < 100)
                {
                    a++;
                }
                else
                {
                    a = 0;
                    currentColor++;
                }
            timer1.Enabled = true;
            }
        }
    }
}
