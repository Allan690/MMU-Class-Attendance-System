using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMUSIS1
{
    public partial class AdmUserFrm : Form
    {
        public AdmUserFrm()
        {
            Thread trd = new Thread(new ThreadStart(delegate
            {
                _splash = new SplashScreen();
                _splash.ShowDialog();
            }));
            trd.Start();
            Thread.Sleep(13000);
            InitializeComponent();
            AdmUserFrm.CloseSplash();
        }

        private void formRun()
        {
            SplashScreen frm = new SplashScreen();
            Application.Run(frm);
        }
        private static SplashScreen _splash = null;
        public static void CloseSplash()
        {
            if (_splash != null)
            {
                _splash.CloseSplash();
            }
        }             

           
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminLogin obj = new AdminLogin();
            this.Hide();
            obj.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          

        }
    }
}
