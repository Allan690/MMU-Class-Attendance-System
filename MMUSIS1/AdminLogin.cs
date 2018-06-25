using Dapper;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MMUSIS1.UserControls;

namespace MMUSIS1
{
    public partial class AdminLogin : MetroFramework.Forms.MetroForm
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            //bunifuCircleProgressbar1.Hide();
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Default;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
            if (Properties.Settings.Default.RememberMe)
            {
                txtUserName.Text = Properties.Settings.Default.UserName;
                txtPassword.Text = Properties.Settings.Default.Password;
            }
        }
        void lgin()
        {
            for(int i = 0; i <= 100; i++)
            {
                Thread.Sleep(100);

                //save data
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter your username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return;

            }
            using (var waitingForm = new Waitfrm(lgin))
            {
                waitingForm.ShowDialog(this);
                try
                {
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        Admins obj = db.Query<Admins>($"Select * from Admins where UserName='{txtUserName.Text}'", commandType: CommandType.Text).SingleOrDefault();
                        if (obj != null)
                        {
                            if (obj.password == txtPassword.Text)
                            {
                                custom_dialog ct = new custom_dialog("Login Successful. Welcome to Multimedia University Class Attendance System");
                                ct.ShowDialog();
                                using (AdminDashboard form2 = new AdminDashboard())
                                {                                   
                                    this.Hide();
                                    form2.MyProperty = txtUserName.Text;
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
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
               
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

        private void txtUserName_Click(object sender, EventArgs e)
        {


        }

       
    }
}
