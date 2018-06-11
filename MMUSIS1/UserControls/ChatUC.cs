using System;
using System.Windows.Forms;
using System.Web;
using System.Diagnostics;

namespace MMUSIS1.UserControls
{
    public partial class ChatUC : UserControl
    {
        public ChatUC()
        {
            InitializeComponent();
        }

        private void ChatUC_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
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
    }
}
