using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Threading;

namespace MMUSIS1.UserControls
{
    public partial class SendEmailUC : UserControl
    {
        public SendEmailUC()
        {
            InitializeComponent();
          
        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void SendEmailUC_Load(object sender, EventArgs e)
        {

        }
        public string MyProperty
        {
            get { return sysUser.Text; }
            set { sysUser.Text = value; }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage(txtFrom.Text, txtTo.Text, txtSubject.Text, txtBody.Text);
                mail.Attachments.Add(new Attachment(txtPath1.Text));
                mail.Attachments.Add(new Attachment(txtPath2.Text));
                SmtpClient client = new SmtpClient(txtSmtp.Text);
                client.Port = 587;
                //client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(txtUsername.Text, txtPassword.Text);
                client.EnableSsl = true;
                client.Send(mail);
                emailSent em = new emailSent();
                em.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                txtPath1.Text = picPath;
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                txtPath2.Text = picPath;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            lblDate.Text = date.ToLongDateString();
            lblTime.Text = date.ToLongTimeString();
        }

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "Sender's email address field modified";
        }

        private void txtSubject_TextChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "Email subject field modified";
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "User name textfield modified";
        }

        private void txtBody_TextChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "Body of the email modified";
        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "Receiver's address text field modified";
        }

        private void txtSmtp_Validated(object sender, EventArgs e)
        {

        }

        private void txtSmtp_TextChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "SMTP Server field modified";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "Password field modified";
        }

        private void txtPath1_OnValueChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "Object attached to the email";
        }

        private void txtPath2_OnValueChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "Object attached to the email";
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
