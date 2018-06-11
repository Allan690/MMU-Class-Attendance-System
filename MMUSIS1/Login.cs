using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMUSIS1
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Purple;
            if (Properties.Settings.Default.RememberMe)
            {
                txtUserName.Text = Properties.Settings.Default.UserName;
                txtPassword.Text = Properties.Settings.Default.Password;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter your username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return;
                
            }
            try
            {
                using(IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    db.Open();
                    User obj = db.Query<User>($"Select * from Users where UserName='{txtUserName.Text}'", commandType: CommandType.Text).SingleOrDefault();
                    if (obj != null)
                    {
                        if (obj.password == txtPassword.Text)
                        {
                            using(Dashboard form2 = new Dashboard())
                            {
                                this.Hide();
                                form2.ShowDialog();
                            }
                        }
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Your username and Password don't match.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Your username and Password don't match.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void chkRememberme_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRememberme.Checked == true)
            {
                Properties.Settings.Default.UserName = txtUserName.Text;
                Properties.Settings.Default.Password = txtPassword.Text;

            }
            else
            {
                Properties.Settings.Default.UserName = null;
                Properties.Settings.Default.Password = null;
            }
            Properties.Settings.Default.RememberMe = chkRememberme.Checked;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
