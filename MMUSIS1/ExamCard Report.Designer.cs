namespace MMUSIS1
{
    partial class ExamCard_Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamCard_Report));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtAdmNo = new MetroFramework.Controls.MetroTextBox();
            this.txtCourseCode = new MetroFramework.Controls.MetroTextBox();
            this.txtCourseName = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picAdmNo = new System.Windows.Forms.PictureBox();
            this.picName = new System.Windows.Forms.PictureBox();
            this.picCourseCode = new System.Windows.Forms.PictureBox();
            this.picCourseName = new System.Windows.Forms.PictureBox();
            this.lblAdmNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrintNonReceivers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPrintOne = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGenerateAll = new Bunifu.Framework.UI.BunifuFlatButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.examCardrptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCourseCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCourseName)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examCardrptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(215, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(126, 112);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Enter the name of the student";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(237, 23);
            this.txtName.TabIndex = 0;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Enter the name of the student";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtAdmNo
            // 
            // 
            // 
            // 
            this.txtAdmNo.CustomButton.Image = null;
            this.txtAdmNo.CustomButton.Location = new System.Drawing.Point(215, 1);
            this.txtAdmNo.CustomButton.Name = "";
            this.txtAdmNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdmNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdmNo.CustomButton.TabIndex = 1;
            this.txtAdmNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdmNo.CustomButton.UseSelectable = true;
            this.txtAdmNo.CustomButton.Visible = false;
            this.txtAdmNo.Lines = new string[0];
            this.txtAdmNo.Location = new System.Drawing.Point(126, 64);
            this.txtAdmNo.MaxLength = 32767;
            this.txtAdmNo.Name = "txtAdmNo";
            this.txtAdmNo.PasswordChar = '\0';
            this.txtAdmNo.PromptText = "Enter the admission number of the student";
            this.txtAdmNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdmNo.SelectedText = "";
            this.txtAdmNo.SelectionLength = 0;
            this.txtAdmNo.SelectionStart = 0;
            this.txtAdmNo.ShortcutsEnabled = true;
            this.txtAdmNo.Size = new System.Drawing.Size(237, 23);
            this.txtAdmNo.TabIndex = 1;
            this.txtAdmNo.UseSelectable = true;
            this.txtAdmNo.WaterMark = "Enter the admission number of the student";
            this.txtAdmNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdmNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAdmNo.TextChanged += new System.EventHandler(this.txtAdmNo_TextChanged);
            this.txtAdmNo.Leave += new System.EventHandler(this.txtAdmNo_Leave);
            // 
            // txtCourseCode
            // 
            // 
            // 
            // 
            this.txtCourseCode.CustomButton.Image = null;
            this.txtCourseCode.CustomButton.Location = new System.Drawing.Point(215, 1);
            this.txtCourseCode.CustomButton.Name = "";
            this.txtCourseCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCourseCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCourseCode.CustomButton.TabIndex = 1;
            this.txtCourseCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCourseCode.CustomButton.UseSelectable = true;
            this.txtCourseCode.CustomButton.Visible = false;
            this.txtCourseCode.Lines = new string[0];
            this.txtCourseCode.Location = new System.Drawing.Point(126, 160);
            this.txtCourseCode.MaxLength = 32767;
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.PasswordChar = '\0';
            this.txtCourseCode.PromptText = "Enter the course code";
            this.txtCourseCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCourseCode.SelectedText = "";
            this.txtCourseCode.SelectionLength = 0;
            this.txtCourseCode.SelectionStart = 0;
            this.txtCourseCode.ShortcutsEnabled = true;
            this.txtCourseCode.Size = new System.Drawing.Size(237, 23);
            this.txtCourseCode.TabIndex = 2;
            this.txtCourseCode.UseSelectable = true;
            this.txtCourseCode.WaterMark = "Enter the course code";
            this.txtCourseCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCourseCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCourseCode.Leave += new System.EventHandler(this.txtCourseCode_Leave);
            // 
            // txtCourseName
            // 
            // 
            // 
            // 
            this.txtCourseName.CustomButton.Image = null;
            this.txtCourseName.CustomButton.Location = new System.Drawing.Point(215, 1);
            this.txtCourseName.CustomButton.Name = "";
            this.txtCourseName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCourseName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCourseName.CustomButton.TabIndex = 1;
            this.txtCourseName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCourseName.CustomButton.UseSelectable = true;
            this.txtCourseName.CustomButton.Visible = false;
            this.txtCourseName.Lines = new string[0];
            this.txtCourseName.Location = new System.Drawing.Point(126, 215);
            this.txtCourseName.MaxLength = 32767;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.PasswordChar = '\0';
            this.txtCourseName.PromptText = "Enter the course name";
            this.txtCourseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCourseName.SelectedText = "";
            this.txtCourseName.SelectionLength = 0;
            this.txtCourseName.SelectionStart = 0;
            this.txtCourseName.ShortcutsEnabled = true;
            this.txtCourseName.Size = new System.Drawing.Size(237, 23);
            this.txtCourseName.TabIndex = 3;
            this.txtCourseName.UseSelectable = true;
            this.txtCourseName.WaterMark = "Enter the course name";
            this.txtCourseName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCourseName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCourseName.Leave += new System.EventHandler(this.txtCourseName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "AdmNo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Course Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Course Name:";
            // 
            // picAdmNo
            // 
            this.picAdmNo.Location = new System.Drawing.Point(379, 64);
            this.picAdmNo.Name = "picAdmNo";
            this.picAdmNo.Size = new System.Drawing.Size(34, 24);
            this.picAdmNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdmNo.TabIndex = 8;
            this.picAdmNo.TabStop = false;
            // 
            // picName
            // 
            this.picName.Location = new System.Drawing.Point(379, 111);
            this.picName.Name = "picName";
            this.picName.Size = new System.Drawing.Size(34, 24);
            this.picName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picName.TabIndex = 8;
            this.picName.TabStop = false;
            // 
            // picCourseCode
            // 
            this.picCourseCode.Location = new System.Drawing.Point(379, 159);
            this.picCourseCode.Name = "picCourseCode";
            this.picCourseCode.Size = new System.Drawing.Size(34, 24);
            this.picCourseCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCourseCode.TabIndex = 8;
            this.picCourseCode.TabStop = false;
            // 
            // picCourseName
            // 
            this.picCourseName.Location = new System.Drawing.Point(379, 214);
            this.picCourseName.Name = "picCourseName";
            this.picCourseName.Size = new System.Drawing.Size(34, 24);
            this.picCourseName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCourseName.TabIndex = 8;
            this.picCourseName.TabStop = false;
            // 
            // lblAdmNo
            // 
            this.lblAdmNo.AutoSize = true;
            this.lblAdmNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmNo.Location = new System.Drawing.Point(376, 91);
            this.lblAdmNo.Name = "lblAdmNo";
            this.lblAdmNo.Size = new System.Drawing.Size(0, 17);
            this.lblAdmNo.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(378, 138);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 17);
            this.lblName.TabIndex = 10;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(376, 241);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(0, 17);
            this.lblCourseName.TabIndex = 12;
            // 
            // lblCourseCode
            // 
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseCode.Location = new System.Drawing.Point(376, 186);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(0, 17);
            this.lblCourseCode.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrintNonReceivers);
            this.groupBox1.Controls.Add(this.btnPrintOne);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnGenerateAll);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(435, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 174);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Print report";
            // 
            // btnPrintNonReceivers
            // 
            this.btnPrintNonReceivers.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrintNonReceivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPrintNonReceivers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintNonReceivers.BorderRadius = 0;
            this.btnPrintNonReceivers.ButtonText = "Print Non-Receivers";
            this.btnPrintNonReceivers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintNonReceivers.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrintNonReceivers.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrintNonReceivers.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrintNonReceivers.Iconimage")));
            this.btnPrintNonReceivers.Iconimage_right = null;
            this.btnPrintNonReceivers.Iconimage_right_Selected = null;
            this.btnPrintNonReceivers.Iconimage_Selected = null;
            this.btnPrintNonReceivers.IconMarginLeft = 0;
            this.btnPrintNonReceivers.IconMarginRight = 0;
            this.btnPrintNonReceivers.IconRightVisible = true;
            this.btnPrintNonReceivers.IconRightZoom = 0D;
            this.btnPrintNonReceivers.IconVisible = true;
            this.btnPrintNonReceivers.IconZoom = 90D;
            this.btnPrintNonReceivers.IsTab = false;
            this.btnPrintNonReceivers.Location = new System.Drawing.Point(16, 107);
            this.btnPrintNonReceivers.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnPrintNonReceivers.Name = "btnPrintNonReceivers";
            this.btnPrintNonReceivers.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPrintNonReceivers.OnHovercolor = System.Drawing.Color.Olive;
            this.btnPrintNonReceivers.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrintNonReceivers.selected = false;
            this.btnPrintNonReceivers.Size = new System.Drawing.Size(202, 54);
            this.btnPrintNonReceivers.TabIndex = 28;
            this.btnPrintNonReceivers.Text = "Print Non-Receivers";
            this.btnPrintNonReceivers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintNonReceivers.Textcolor = System.Drawing.Color.White;
            this.btnPrintNonReceivers.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnPrintOne
            // 
            this.btnPrintOne.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrintOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrintOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintOne.BorderRadius = 0;
            this.btnPrintOne.ButtonText = "Print One";
            this.btnPrintOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintOne.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrintOne.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrintOne.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrintOne.Iconimage")));
            this.btnPrintOne.Iconimage_right = null;
            this.btnPrintOne.Iconimage_right_Selected = null;
            this.btnPrintOne.Iconimage_Selected = null;
            this.btnPrintOne.IconMarginLeft = 0;
            this.btnPrintOne.IconMarginRight = 0;
            this.btnPrintOne.IconRightVisible = true;
            this.btnPrintOne.IconRightZoom = 0D;
            this.btnPrintOne.IconVisible = true;
            this.btnPrintOne.IconZoom = 90D;
            this.btnPrintOne.IsTab = false;
            this.btnPrintOne.Location = new System.Drawing.Point(19, 39);
            this.btnPrintOne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrintOne.Name = "btnPrintOne";
            this.btnPrintOne.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrintOne.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPrintOne.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrintOne.selected = false;
            this.btnPrintOne.Size = new System.Drawing.Size(199, 51);
            this.btnPrintOne.TabIndex = 27;
            this.btnPrintOne.Text = "Print One";
            this.btnPrintOne.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintOne.Textcolor = System.Drawing.Color.White;
            this.btnPrintOne.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintOne.Click += new System.EventHandler(this.btnPrintOne_Click);
            // 
            // btnClear
            // 
            this.btnClear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.BorderRadius = 0;
            this.btnClear.ButtonText = "Clear Form";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledColor = System.Drawing.Color.Gray;
            this.btnClear.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClear.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClear.Iconimage")));
            this.btnClear.Iconimage_right = null;
            this.btnClear.Iconimage_right_Selected = null;
            this.btnClear.Iconimage_Selected = null;
            this.btnClear.IconMarginLeft = 0;
            this.btnClear.IconMarginRight = 0;
            this.btnClear.IconRightVisible = true;
            this.btnClear.IconRightZoom = 0D;
            this.btnClear.IconVisible = true;
            this.btnClear.IconZoom = 90D;
            this.btnClear.IsTab = false;
            this.btnClear.Location = new System.Drawing.Point(226, 107);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClear.OnHovercolor = System.Drawing.Color.Olive;
            this.btnClear.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClear.selected = false;
            this.btnClear.Size = new System.Drawing.Size(199, 50);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear Form";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Textcolor = System.Drawing.Color.White;
            this.btnClear.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnGenerateAll
            // 
            this.btnGenerateAll.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGenerateAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGenerateAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerateAll.BorderRadius = 0;
            this.btnGenerateAll.ButtonText = "Generate All";
            this.btnGenerateAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateAll.DisabledColor = System.Drawing.Color.Gray;
            this.btnGenerateAll.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGenerateAll.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGenerateAll.Iconimage")));
            this.btnGenerateAll.Iconimage_right = null;
            this.btnGenerateAll.Iconimage_right_Selected = null;
            this.btnGenerateAll.Iconimage_Selected = null;
            this.btnGenerateAll.IconMarginLeft = 0;
            this.btnGenerateAll.IconMarginRight = 0;
            this.btnGenerateAll.IconRightVisible = true;
            this.btnGenerateAll.IconRightZoom = 0D;
            this.btnGenerateAll.IconVisible = true;
            this.btnGenerateAll.IconZoom = 90D;
            this.btnGenerateAll.IsTab = false;
            this.btnGenerateAll.Location = new System.Drawing.Point(224, 39);
            this.btnGenerateAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerateAll.Name = "btnGenerateAll";
            this.btnGenerateAll.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGenerateAll.OnHovercolor = System.Drawing.Color.Olive;
            this.btnGenerateAll.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGenerateAll.selected = false;
            this.btnGenerateAll.Size = new System.Drawing.Size(201, 51);
            this.btnGenerateAll.TabIndex = 25;
            this.btnGenerateAll.Text = "Generate All";
            this.btnGenerateAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateAll.Textcolor = System.Drawing.Color.White;
            this.btnGenerateAll.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.admNoDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.unitCodeDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.examCardrptBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle11;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(37, 273);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(798, 189);
            this.metroGrid1.TabIndex = 27;
            // 
            // examCardrptBindingSource
            // 
            this.examCardrptBindingSource.DataSource = typeof(MMUSIS1.ExamCardrpt);
            // 
            // admNoDataGridViewTextBoxColumn
            // 
            this.admNoDataGridViewTextBoxColumn.DataPropertyName = "AdmNo";
            this.admNoDataGridViewTextBoxColumn.HeaderText = "AdmNo";
            this.admNoDataGridViewTextBoxColumn.Name = "admNoDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // unitCodeDataGridViewTextBoxColumn
            // 
            this.unitCodeDataGridViewTextBoxColumn.DataPropertyName = "UnitCode";
            this.unitCodeDataGridViewTextBoxColumn.HeaderText = "UnitCode";
            this.unitCodeDataGridViewTextBoxColumn.Name = "unitCodeDataGridViewTextBoxColumn";
            // 
            // ExamCard_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 545);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblCourseCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAdmNo);
            this.Controls.Add(this.picCourseName);
            this.Controls.Add(this.picCourseCode);
            this.Controls.Add(this.picName);
            this.Controls.Add(this.picAdmNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtCourseCode);
            this.Controls.Add(this.txtAdmNo);
            this.Controls.Add(this.txtName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExamCard_Report";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Exam Card Report";
            this.Load += new System.EventHandler(this.ExamCard_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAdmNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCourseCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCourseName)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examCardrptBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtAdmNo;
        private MetroFramework.Controls.MetroTextBox txtCourseCode;
        private MetroFramework.Controls.MetroTextBox txtCourseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picAdmNo;
        private System.Windows.Forms.PictureBox picName;
        private System.Windows.Forms.PictureBox picCourseCode;
        private System.Windows.Forms.PictureBox picCourseName;
        private System.Windows.Forms.Label lblAdmNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrintNonReceivers;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrintOne;
        private Bunifu.Framework.UI.BunifuFlatButton btnClear;
        private Bunifu.Framework.UI.BunifuFlatButton btnGenerateAll;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn admNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource examCardrptBindingSource;
    }
}