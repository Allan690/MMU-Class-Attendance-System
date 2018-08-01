using Dapper;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMUSIS1
{
    public partial class ExamCard_Report : MetroFramework.Forms.MetroForm
    {
        public ExamCard_Report()
        {
            InitializeComponent();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExamCard_Report_Load(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "select distinct b.AdmNo, b.Unit, c.UnitCode from ExamCardtbl b inner join Units c on b.Unit = c.UnitName order by b.AdmNo";
                 examCardrptBindingSource.DataSource = db.Query<ExamCardrpt>(query, commandType: CommandType.Text);
               
            }
        }

        private void btnPrintOne_Click(object sender, EventArgs e)
        {
            metroGrid1.Columns[0].Visible = false;
            metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "SELECT DISTINCT b.Unit, c.UnitCode from StudAttendance b inner join Units c on b.Unit = c.UnitName where b.AdmNo ='"+txtAdmNo.Text+"'";
                examCardrptBindingSource.DataSource = db.Query<ExamCardrpt>(query, commandType: CommandType.Text);
            }
            printRpt();
        }
        public void regexp(string re, MetroFramework.Controls.MetroTextBox tb, PictureBox pc, Label lbl, string s)
        {
            Regex regex = new Regex(re);
            if (regex.IsMatch(tb.Text))
            {
                pc.Image = Properties.Resources.correctbtn;
                lbl.ForeColor = System.Drawing.Color.Green;
                lbl.Text = s + "valid";
            }
            else
            {
                pc.Image = Properties.Resources.errorbtn;
                lbl.ForeColor = System.Drawing.Color.Red;
                lbl.Text = s + "Invalid";
            }
        }
        void printRpt()
        {
            try
            {
                SaveFileDialog SavePdfDialog = new SaveFileDialog();
                Stream stream;
                SavePdfDialog.Filter = "PDF File (*.pdf)|*.pdf|All files(*.*)|*.*";
                SavePdfDialog.FilterIndex = 1;
                SavePdfDialog.RestoreDirectory = true;
               

                SavePdfDialog.FileName = string.Format("{0}({1})", txtName.Text, DateTime.Now.Ticks);
                if (SavePdfDialog.ShowDialog() == DialogResult.OK)
                {
                    if ((stream = SavePdfDialog.OpenFile()) != null)

                    {
                        Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                        PdfWriter wri = PdfWriter.GetInstance(doc, stream);
                        DateTime dt = DateTime.Now;

                        doc.Open(); //Open document to write

                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(@"C:\Users\FRED\Documents\Visual Studio 2015\WebSites\Testing\Image\mmu1.jpeg");
                        img.ScalePercent(50f);
                        img.IndentationLeft = 150f;

                        img.SetAbsolutePosition(doc.PageSize.Width - 500f - 72f, doc.PageSize.Height - -80f - 216.6f);

                        //Write some content                      
                        Paragraph par = new Paragraph("MULTIMEDIA UNIVERSITY OF KENYA.", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 18f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLUE));
                        Paragraph par5 = new Paragraph("P.O. Box 15653 - 00503, Mbagathi, Nairobi Tel: +254 020 2071391, +254 020 724257083, + 254 020 735900008", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLUE));
                        Paragraph par6 = new Paragraph("Fax: +254 020 2071243 Email: info@mmu.ac.ke Leader in Innovative Technology", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLUE));
                        Paragraph par7 = new Paragraph("\n MMU HOSTEL BOOKING INVOICE\n\n", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14f, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.BLACK));
                        Paragraph par1 = new Paragraph("Name:" + txtName.Text + "\n Admission Number:" + txtAdmNo.Text);
                        Paragraph par3 = new Paragraph("\n\n\n");
                        Paragraph par4 = new Paragraph("\n\n");


                        PdfPTable table = new PdfPTable(2);
                        PdfPCell cell = new PdfPCell(new Phrase("EXAM CARD REPORT FOR:" + txtAdmNo.Text));
                        cell.Colspan = 2;
                        cell.HorizontalAlignment = 1;
                        table.AddCell(cell);
                        //Add headers from the DGV to the table
                        for (int j = 0; j < metroGrid1.Columns.Count; j++)
                        {
                            table.AddCell(new Phrase(metroGrid1.Columns[j].HeaderText));
                        }
                        //Flag the first row as the header

                        //add actual rows to the table
                        for (int i = 0; i < metroGrid1.Rows.Count; i++)
                        {
                            for (int k = 0; k < metroGrid1.Columns.Count; k++)
                            {
                                if (metroGrid1[k, i].Value != null)
                                {
                                    table.AddCell(new Phrase(metroGrid1[k, i].Value.ToString()));
                                }
                            }
                        }
                        Paragraph par2 = new Paragraph("\n\n\nSignature .....................");
                        string imgloc = string.Empty;

                        //imgloc = txtName.Text + ".png";
                        //Image img1 = Image.GetInstance(imgloc);
                        //img1.ScalePercent(40f);
                        //img1.SetAbsolutePosition(doc.PageSize.Width - 50f - 72f, doc.PageSize.Height - 36f - 216.6f);

                        par.IndentationLeft = 200f;
                        par1.IndentationLeft = 150f;
                        par2.IndentationLeft = 450f;
                        par5.IndentationLeft = 150f;
                        par6.IndentationLeft = 150f;
                        par7.IndentationLeft = 150f;


                        // Now add the above created text using different class object to our pdf document
                        doc.Add(img);
                       // doc.Add(img1);
                        doc.Add(par);

                        doc.Add(par5);
                        doc.Add(par6);
                        doc.Add(par4);
                        doc.Add(par7);
                        doc.Add(par1);
                        doc.Add(par3);

                        doc.Add(table);
                        doc.Add(par2);
                        Paragraph ph = new Paragraph(doc.BottomMargin, "\n\n\nMultimedia University Class Attendance System \u00a9 2018 " + dt);
                       
                        ph.IndentationLeft = 130f;

                        doc.Add(ph);
                        
                        doc.Close();//close the document

                        wri.Close();


                    }

                    stream.Close();

                }



                System.Diagnostics.Process.Start(SavePdfDialog.FileName);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtAdmNo_TextChanged(object sender, EventArgs e)
        {
            //regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtLesson, picLesson, lblLessons, "");
        }

        private void txtAdmNo_Leave(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtAdmNo, picAdmNo, lblAdmNo, "");
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtName, picName, lblName, "");
        }

        private void txtCourseCode_Leave(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtCourseCode, picCourseCode, lblCourseCode, "");
        }

        private void txtCourseName_Leave(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtCourseName, picCourseName, lblCourseName, "");
        }
        void AutoFillName()
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select b.FullName, b.Course, c.CourseCode, b.[Year] from Students b inner join Courses c on b.Course = c.CourseName  where b.AdmNo ='"+txtAdmNo.Text+"'", db);
                db.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string sName = reader.GetString(0);
                    string coursename = reader.GetString(1);
                    string CourseCode = reader.GetString(3);
                    string year = reader.GetInt32(4).ToString();

                    txtName.Text = sName;
                    txtCourseName.Text = coursename;
                    txtCourseCode.Text = CourseCode;
                }
            }
        }
    }
}
