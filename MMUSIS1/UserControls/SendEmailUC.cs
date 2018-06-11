using System;
using System.Windows.Forms;
using System.Net.Mail;

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
    }
}
