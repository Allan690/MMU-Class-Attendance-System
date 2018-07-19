using System;
using System.Windows.Forms;
using System.Web;
using System.Diagnostics;
using MetroFramework.Controls;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;

namespace MMUSIS1.UserControls
{
    public partial class ChatUC : UserControl
    {
        public ChatUC()
        {
            InitializeComponent();
        }

        private Image errobtn;
        private Image correct;


        private void ChatUC_Load(object sender, EventArgs e)
        {

        }
        public string MyProperty
        {
            get { return sysUser.Text; }
            set { sysUser.Text = value; }
        }

        public void regexp(string re, MetroTextBox tb, PictureBox pc, Label lbl, string s)
        {
            errobtn = Properties.Resources.errorbtn;
            correct = Properties.Resources.correctbtn;
            Regex regex = new Regex(re);
            if (regex.IsMatch(tb.Text))
            {
                
                pc.Image = correct;
                lbl.ForeColor = System.Drawing.Color.Green;
                lbl.Text = s + "valid";
            }
            else
            {
                pc.Image = errobtn;
                lbl.ForeColor = System.Drawing.Color.Red;
                lbl.Text = s + "Invalid";
            }
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            verify();
            //Set parameters
            string username = txtName.Text;
            string password = txtPassword.Text;
            string msgsender = txtReceiverNo.Text;
            string destinationaddr = txtReceiverNo.Text;
            string message = txtMessage.Text;

            // Create ViaNettSMS object with username and password
            ViaNettSMS s = new ViaNettSMS(username, password);
            // Declare Result object returned by the SendSMS function
            ViaNettSMS.Result result;
            try
            {
                // Send SMS through HTTP API
                result = s.sendSMS(msgsender, destinationaddr, message);
                // Show Send SMS response
                if (result.Success)
                {
                    txtSentSuccess txt = new txtSentSuccess();
                    txt.ShowDialog();
                   // MessageBox.Show("Message successfully sent!");
                }
                else
                {
                    Debug.WriteLine("Received error: " + result.ErrorCode + " " + result.ErrorMessage);
                }
            }
            catch (System.Net.WebException ex)
            {
                //Catch error occurred while connecting to server.
                Debug.WriteLine(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            lblDate.Text = date.ToLongDateString();
            lblTime.Text = date.ToLongTimeString();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "User name text field modified";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "Password field modified";
        }
        void verify()
        {
            if (lblPassword.Text == "Invalid" || lblReceiverNo.Text == "Invalid" || lblText.Text == "Invalid" || lblUserName.Text == "Invalid")
            {
                formError fm = new formError();
                fm.ShowDialog();
                return;
            }
           if(txtMessage.Text== "" || txtPassword.Text == "" || txtName.Text == "" || txtReceiverNo.Text == "")
            {
                formError fm = new formError();
                fm.ShowDialog();
                return;
            }
        }

        private void txtReceiverNo_TextChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "Receiver Number field modified.";
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "Text message body field modified.";
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtName, picUserName, lblUserName, "");
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtPassword, picPassword, lblPassword, "");
        }

        private void txtReceiverNo_LocationChanged(object sender, EventArgs e)
        {

        }

        private void txtReceiverNo_Leave(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtReceiverNo, picReceiver, lblReceiverNo, "");
        }

        private void txtMessage_Leave(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtMessage, pictureBox1, lblText, "");
        }

        private void bunifuFlatButton1_MouseEnter(object sender, EventArgs e)
        {
        }
        void logout()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(100);

                //save data
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                using (var waitingForm = new Waitfrm(logout))
                {
                    waitingForm.ShowDialog(this);
                    Form tmp = this.FindForm();
                    tmp.Close();
                    tmp.Dispose();
                    AdminLogin adm = new AdminLogin();
                    adm.Show();
                }

            }
            else if (dialog == DialogResult.No)
            {
                this.Show();

            }
        }
    }
}
