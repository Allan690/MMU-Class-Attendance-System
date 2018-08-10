using System;
using System.Drawing;
using Spire.Barcode;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace MMUSIS1
{
    public partial class QRCodeGenerator : MetroFramework.Forms.MetroForm
    {
        public QRCodeGenerator(string str)
        {
            InitializeComponent();
            richTextBox1.Text = str + System.Environment.NewLine; ;
        }

        private void QRCodeGenerator_Load(object sender, EventArgs e)
        {
            
            setFileName();
            setFileName1();
            txtAdm.Visible = false;
            metroTextBox1.Visible = false;
        }
        void filldatagridview()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@SearchText", metroTextBox1.Text.Trim());
                List<Students> list = db.Query<Students>
                    ("StudViewOrSearch", param, commandType: CommandType.StoredProcedure).ToList<Students>();
                metroGrid1.DataSource = list;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void setFileName()
        {
            int lineNoSelect = 1;
            int start = richTextBox1.GetFirstCharIndexFromLine(lineNoSelect);
            int length = richTextBox1.Lines[lineNoSelect].Length;
            richTextBox1.Select(start, length);
            txtAdm.Text = richTextBox1.SelectedText;
        }

        public void setFileName1()
        {
            int lineNoSelect = 0;
            int start = richTextBox1.GetFirstCharIndexFromLine(lineNoSelect);
            int length = richTextBox1.Lines[lineNoSelect].Length;
            richTextBox1.Select(start, length);
            metroTextBox1.Text = richTextBox1.SelectedText;
        }
        private void btnQRCode_Click(object sender, EventArgs e)
        {
            BarcodeSettings settings = new BarcodeSettings();
            settings.Type = BarCodeType.QRCode;
            settings.Unit = GraphicsUnit.Pixel;
            settings.ShowText = false;
            settings.ResolutionType = ResolutionType.UseDpi;
            //input data
            string data = "12345";
            settings.Data = data;
            if (this.richTextBox1.Text != null && this.richTextBox1.Text.Length > 0)
            {
                data = this.richTextBox1.Text;
                settings.Data = data;
            }
            //set fore color
            if (this.comboFore.SelectedItem != null)
            {
                string foreColor = this.comboFore.SelectedItem.ToString();
                settings.ForeColor = Color.FromName(foreColor);
            }
            //set back color
            if (this.comboBack.SelectedItem != null)
            {
                string backColor = this.comboBack.SelectedItem.ToString();
                settings.BackColor = Color.FromName(backColor);
            }
            //set x
            short barWidth;
            if (this.txtWidth.Text != null && this.txtWidth.Text.Length > 0 && Int16.TryParse(this.txtWidth.Text, out barWidth))
            {
                settings.X = barWidth;

            }
            //set left margin
            short leftMargin = 1;
            if (this.txtLeftMargin.Text != null && this.txtLeftMargin.Text.Length > 0 && Int16.TryParse(this.txtLeftMargin.Text, out leftMargin))
            {
                settings.LeftMargin = leftMargin;

            }
            //set right margin
            short rightMargin = 1;
            if (this.txtRightMargin.Text != null && this.txtRightMargin.Text.Length > 0 && Int16.TryParse(this.txtRightMargin.Text, out rightMargin))
            {
                settings.RightMargin = rightMargin;

            }
            //set top margin
            short topMargin = 1;
            if (this.txtTopMargin.Text != null && this.txtTopMargin.Text.Length > 0 && Int16.TryParse(this.txtTopMargin.Text, out topMargin))
            {
                settings.TopMargin = topMargin;

            }
            //set bottom margin
            short bottomMargin = 1;
            if (this.txtBottomMargin.Text != null && this.txtBottomMargin.Text.Length > 0 && Int16.TryParse(this.txtBottomMargin.Text, out bottomMargin))
            {
                settings.BottomMargin = bottomMargin;

            }
            //set correction level
            if (this.comboError.SelectedItem != null)
            {
                int correctionLevel = this.comboError.SelectedIndex;
                switch (correctionLevel)
                {
                    case 0:
                        settings.QRCodeECL = QRCodeECL.L;
                        break;
                    case 1:
                        settings.QRCodeECL = QRCodeECL.M;
                        break;
                    case 2:
                        settings.QRCodeECL = QRCodeECL.Q;
                        break;
                    case 3:
                        settings.QRCodeECL = QRCodeECL.H;
                        break;
                }

            }
            //generate QR code
            BarCodeGenerator generator = new BarCodeGenerator(settings);
            Image QRbarcode = generator.GenerateImage();
            //display QR code image in picture box
            pictureBox1.Image = QRbarcode;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Students obj = studentsBindingSource.Current as Students;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@SearchText", metroTextBox1.Text.Trim());
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_array = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_array, 0, photo_array.Length);
                param.Add("@qrcode", photo_array);
                db.Execute("UpdateQR", param, commandType: CommandType.StoredProcedure);                
                filldatagridview();
                UpdateSuccess up = new UpdateSuccess();
                up.ShowDialog();
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = txtAdm.Text + ".png";
            sfd.Filter = "png file(*.png)|*.png";
            if (DialogResult.OK == sfd.ShowDialog())
            {
                switch (sfd.Filter)
                {
                    case "png file(*.png)|*.png":
                        pictureBox1.Image.Save(sfd.FileName, ImageFormat.Png);
                        this.Hide();
                        break;
                    default:
                        pictureBox1.Image.Save(txtAdm.Text + ".png", ImageFormat.Png);
                        this.Hide();
                        break;
                }
            }
        }
    }
}
