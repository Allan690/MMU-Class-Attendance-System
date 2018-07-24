namespace MMUSIS1
{
    partial class studAttendancerpt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dtFrom = new MetroFramework.Controls.MetroDateTime();
            this.dtTo = new MetroFramework.Controls.MetroDateTime();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtFaculty = new MetroFramework.Controls.MetroTextBox();
            this.txtTotal = new MetroFramework.Controls.MetroTextBox();
            this.txtUnit = new MetroFramework.Controls.MetroTextBox();
            this.txtCourse = new MetroFramework.Controls.MetroTextBox();
            this.txtGender = new MetroFramework.Controls.MetroTextBox();
            this.txtDOB = new MetroFramework.Controls.MetroTextBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtUnitCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtUnitName = new MetroFramework.Controls.MetroTextBox();
            this.picAdm = new System.Windows.Forms.PictureBox();
            this.picName = new System.Windows.Forms.PictureBox();
            this.picUnitCode = new System.Windows.Forms.PictureBox();
            this.picUnitName = new System.Windows.Forms.PictureBox();
            this.lblAdmNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUnitCode = new System.Windows.Forms.Label();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.txtAdm = new MetroFramework.Controls.MetroTextBox();
            this.admNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAttendanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnitCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnitName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Adm No:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(438, 37);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "From Date:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(457, 77);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "To Date:";
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(540, 27);
            this.dtFrom.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(159, 29);
            this.dtFrom.TabIndex = 4;
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(539, 77);
            this.dtTo.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(159, 29);
            this.dtTo.TabIndex = 4;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(602, 124);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(96, 23);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Load";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(616, 417);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(96, 23);
            this.metroButton2.TabIndex = 6;
            this.metroButton2.Text = "Print";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 96);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(48, 19);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Name:";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(103, 96);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Student name appears here";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(212, 23);
            this.txtName.TabIndex = 2;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Student name appears here";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.Click += new System.EventHandler(this.metroTextBox1_Click);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtFaculty
            // 
            // 
            // 
            // 
            this.txtFaculty.CustomButton.Image = null;
            this.txtFaculty.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtFaculty.CustomButton.Name = "";
            this.txtFaculty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFaculty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFaculty.CustomButton.TabIndex = 1;
            this.txtFaculty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFaculty.CustomButton.UseSelectable = true;
            this.txtFaculty.CustomButton.Visible = false;
            this.txtFaculty.Lines = new string[0];
            this.txtFaculty.Location = new System.Drawing.Point(540, 176);
            this.txtFaculty.MaxLength = 32767;
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.PasswordChar = '\0';
            this.txtFaculty.PromptText = "Faculty";
            this.txtFaculty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFaculty.SelectedText = "";
            this.txtFaculty.SelectionLength = 0;
            this.txtFaculty.SelectionStart = 0;
            this.txtFaculty.ShortcutsEnabled = true;
            this.txtFaculty.Size = new System.Drawing.Size(212, 23);
            this.txtFaculty.TabIndex = 16;
            this.txtFaculty.UseSelectable = true;
            this.txtFaculty.WaterMark = "Faculty";
            this.txtFaculty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFaculty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFaculty.Click += new System.EventHandler(this.txtFaculty_Click);
            // 
            // txtTotal
            // 
            // 
            // 
            // 
            this.txtTotal.CustomButton.Image = null;
            this.txtTotal.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtTotal.CustomButton.Name = "";
            this.txtTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotal.CustomButton.TabIndex = 1;
            this.txtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotal.CustomButton.UseSelectable = true;
            this.txtTotal.CustomButton.Visible = false;
            this.txtTotal.Lines = new string[0];
            this.txtTotal.Location = new System.Drawing.Point(539, 176);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PromptText = "Total attendance";
            this.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(212, 23);
            this.txtTotal.TabIndex = 17;
            this.txtTotal.UseSelectable = true;
            this.txtTotal.WaterMark = "Total attendance";
            this.txtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUnit
            // 
            // 
            // 
            // 
            this.txtUnit.CustomButton.Image = null;
            this.txtUnit.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtUnit.CustomButton.Name = "";
            this.txtUnit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUnit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUnit.CustomButton.TabIndex = 1;
            this.txtUnit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUnit.CustomButton.UseSelectable = true;
            this.txtUnit.CustomButton.Visible = false;
            this.txtUnit.Lines = new string[0];
            this.txtUnit.Location = new System.Drawing.Point(539, 176);
            this.txtUnit.MaxLength = 32767;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.PasswordChar = '\0';
            this.txtUnit.PromptText = "Unit";
            this.txtUnit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUnit.SelectedText = "";
            this.txtUnit.SelectionLength = 0;
            this.txtUnit.SelectionStart = 0;
            this.txtUnit.ShortcutsEnabled = true;
            this.txtUnit.Size = new System.Drawing.Size(212, 23);
            this.txtUnit.TabIndex = 18;
            this.txtUnit.UseSelectable = true;
            this.txtUnit.WaterMark = "Unit";
            this.txtUnit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUnit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCourse
            // 
            // 
            // 
            // 
            this.txtCourse.CustomButton.Image = null;
            this.txtCourse.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtCourse.CustomButton.Name = "";
            this.txtCourse.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCourse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCourse.CustomButton.TabIndex = 1;
            this.txtCourse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCourse.CustomButton.UseSelectable = true;
            this.txtCourse.CustomButton.Visible = false;
            this.txtCourse.Lines = new string[0];
            this.txtCourse.Location = new System.Drawing.Point(539, 176);
            this.txtCourse.MaxLength = 32767;
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.PasswordChar = '\0';
            this.txtCourse.PromptText = "Course";
            this.txtCourse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCourse.SelectedText = "";
            this.txtCourse.SelectionLength = 0;
            this.txtCourse.SelectionStart = 0;
            this.txtCourse.ShortcutsEnabled = true;
            this.txtCourse.Size = new System.Drawing.Size(212, 23);
            this.txtCourse.TabIndex = 20;
            this.txtCourse.UseSelectable = true;
            this.txtCourse.WaterMark = "Course";
            this.txtCourse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCourse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtGender
            // 
            // 
            // 
            // 
            this.txtGender.CustomButton.Image = null;
            this.txtGender.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtGender.CustomButton.Name = "";
            this.txtGender.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGender.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGender.CustomButton.TabIndex = 1;
            this.txtGender.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGender.CustomButton.UseSelectable = true;
            this.txtGender.CustomButton.Visible = false;
            this.txtGender.Lines = new string[0];
            this.txtGender.Location = new System.Drawing.Point(539, 176);
            this.txtGender.MaxLength = 32767;
            this.txtGender.Name = "txtGender";
            this.txtGender.PasswordChar = '\0';
            this.txtGender.PromptText = "Gender";
            this.txtGender.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGender.SelectedText = "";
            this.txtGender.SelectionLength = 0;
            this.txtGender.SelectionStart = 0;
            this.txtGender.ShortcutsEnabled = true;
            this.txtGender.Size = new System.Drawing.Size(212, 23);
            this.txtGender.TabIndex = 21;
            this.txtGender.UseSelectable = true;
            this.txtGender.WaterMark = "Gender";
            this.txtGender.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGender.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtGender.Click += new System.EventHandler(this.txtGender_Click);
            // 
            // txtDOB
            // 
            // 
            // 
            // 
            this.txtDOB.CustomButton.Image = null;
            this.txtDOB.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtDOB.CustomButton.Name = "";
            this.txtDOB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDOB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDOB.CustomButton.TabIndex = 1;
            this.txtDOB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDOB.CustomButton.UseSelectable = true;
            this.txtDOB.CustomButton.Visible = false;
            this.txtDOB.Lines = new string[0];
            this.txtDOB.Location = new System.Drawing.Point(539, 176);
            this.txtDOB.MaxLength = 32767;
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.PasswordChar = '\0';
            this.txtDOB.PromptText = "DOB";
            this.txtDOB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDOB.SelectedText = "";
            this.txtDOB.SelectionLength = 0;
            this.txtDOB.SelectionStart = 0;
            this.txtDOB.ShortcutsEnabled = true;
            this.txtDOB.Size = new System.Drawing.Size(212, 23);
            this.txtDOB.TabIndex = 19;
            this.txtDOB.UseSelectable = true;
            this.txtDOB.WaterMark = "DOB";
            this.txtDOB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDOB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.admNoDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.genderDataGridViewCheckBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.facultyDataGridViewTextBoxColumn,
            this.totalAttendanceDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.attendanceReportBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(34, 218);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(691, 193);
            this.metroGrid1.TabIndex = 22;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick_2);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(26, 133);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(71, 19);
            this.metroLabel5.TabIndex = 23;
            this.metroLabel5.Text = "Unit Code:";
            // 
            // txtUnitCode
            // 
            this.txtUnitCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUnitCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtUnitCode.CustomButton.Image = null;
            this.txtUnitCode.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtUnitCode.CustomButton.Name = "";
            this.txtUnitCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUnitCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUnitCode.CustomButton.TabIndex = 1;
            this.txtUnitCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUnitCode.CustomButton.UseSelectable = true;
            this.txtUnitCode.CustomButton.Visible = false;
            this.txtUnitCode.Lines = new string[0];
            this.txtUnitCode.Location = new System.Drawing.Point(103, 133);
            this.txtUnitCode.MaxLength = 32767;
            this.txtUnitCode.Name = "txtUnitCode";
            this.txtUnitCode.PasswordChar = '\0';
            this.txtUnitCode.PromptText = "Enter the unit code";
            this.txtUnitCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUnitCode.SelectedText = "";
            this.txtUnitCode.SelectionLength = 0;
            this.txtUnitCode.SelectionStart = 0;
            this.txtUnitCode.ShortcutsEnabled = true;
            this.txtUnitCode.Size = new System.Drawing.Size(212, 23);
            this.txtUnitCode.TabIndex = 24;
            this.txtUnitCode.UseSelectable = true;
            this.txtUnitCode.WaterMark = "Enter the unit code";
            this.txtUnitCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUnitCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUnitCode.TextChanged += new System.EventHandler(this.txtUnitCode_TextChanged);
            this.txtUnitCode.Leave += new System.EventHandler(this.txtUnitCode_Leave);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(26, 176);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(75, 19);
            this.metroLabel6.TabIndex = 25;
            this.metroLabel6.Text = "Unit Name:";
            // 
            // txtUnitName
            // 
            // 
            // 
            // 
            this.txtUnitName.CustomButton.Image = null;
            this.txtUnitName.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtUnitName.CustomButton.Name = "";
            this.txtUnitName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUnitName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUnitName.CustomButton.TabIndex = 1;
            this.txtUnitName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUnitName.CustomButton.UseSelectable = true;
            this.txtUnitName.CustomButton.Visible = false;
            this.txtUnitName.Lines = new string[0];
            this.txtUnitName.Location = new System.Drawing.Point(103, 176);
            this.txtUnitName.MaxLength = 32767;
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.PasswordChar = '\0';
            this.txtUnitName.PromptText = "The unit name appears here";
            this.txtUnitName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUnitName.SelectedText = "";
            this.txtUnitName.SelectionLength = 0;
            this.txtUnitName.SelectionStart = 0;
            this.txtUnitName.ShortcutsEnabled = true;
            this.txtUnitName.Size = new System.Drawing.Size(212, 23);
            this.txtUnitName.TabIndex = 26;
            this.txtUnitName.UseSelectable = true;
            this.txtUnitName.WaterMark = "The unit name appears here";
            this.txtUnitName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUnitName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUnitName.Leave += new System.EventHandler(this.txtUnitName_Leave);
            // 
            // picAdm
            // 
            this.picAdm.Location = new System.Drawing.Point(334, 58);
            this.picAdm.Name = "picAdm";
            this.picAdm.Size = new System.Drawing.Size(29, 19);
            this.picAdm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdm.TabIndex = 27;
            this.picAdm.TabStop = false;
            // 
            // picName
            // 
            this.picName.Location = new System.Drawing.Point(334, 96);
            this.picName.Name = "picName";
            this.picName.Size = new System.Drawing.Size(29, 19);
            this.picName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picName.TabIndex = 28;
            this.picName.TabStop = false;
            // 
            // picUnitCode
            // 
            this.picUnitCode.Location = new System.Drawing.Point(334, 133);
            this.picUnitCode.Name = "picUnitCode";
            this.picUnitCode.Size = new System.Drawing.Size(29, 19);
            this.picUnitCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUnitCode.TabIndex = 28;
            this.picUnitCode.TabStop = false;
            // 
            // picUnitName
            // 
            this.picUnitName.AccessibleDescription = "d";
            this.picUnitName.Location = new System.Drawing.Point(334, 176);
            this.picUnitName.Name = "picUnitName";
            this.picUnitName.Size = new System.Drawing.Size(29, 19);
            this.picUnitName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUnitName.TabIndex = 28;
            this.picUnitName.TabStop = false;
            // 
            // lblAdmNo
            // 
            this.lblAdmNo.AutoSize = true;
            this.lblAdmNo.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmNo.Location = new System.Drawing.Point(334, 82);
            this.lblAdmNo.Name = "lblAdmNo";
            this.lblAdmNo.Size = new System.Drawing.Size(0, 13);
            this.lblAdmNo.TabIndex = 29;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(331, 118);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 29;
            // 
            // lblUnitCode
            // 
            this.lblUnitCode.AutoSize = true;
            this.lblUnitCode.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitCode.Location = new System.Drawing.Point(334, 155);
            this.lblUnitCode.Name = "lblUnitCode";
            this.lblUnitCode.Size = new System.Drawing.Size(0, 13);
            this.lblUnitCode.TabIndex = 29;
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitName.Location = new System.Drawing.Point(334, 198);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(0, 13);
            this.lblUnitName.TabIndex = 29;
            // 
            // txtAdm
            // 
            this.txtAdm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAdm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtAdm.CustomButton.Image = null;
            this.txtAdm.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtAdm.CustomButton.Name = "";
            this.txtAdm.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdm.CustomButton.TabIndex = 1;
            this.txtAdm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdm.CustomButton.UseSelectable = true;
            this.txtAdm.CustomButton.Visible = false;
            this.txtAdm.Lines = new string[0];
            this.txtAdm.Location = new System.Drawing.Point(103, 58);
            this.txtAdm.MaxLength = 32767;
            this.txtAdm.Name = "txtAdm";
            this.txtAdm.PasswordChar = '\0';
            this.txtAdm.PromptText = "Enter the admission number";
            this.txtAdm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdm.SelectedText = "";
            this.txtAdm.SelectionLength = 0;
            this.txtAdm.SelectionStart = 0;
            this.txtAdm.ShortcutsEnabled = true;
            this.txtAdm.Size = new System.Drawing.Size(212, 23);
            this.txtAdm.TabIndex = 30;
            this.txtAdm.UseSelectable = true;
            this.txtAdm.WaterMark = "Enter the admission number";
            this.txtAdm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAdm.TextChanged += new System.EventHandler(this.txtAdm_TextChanged_1);
            // 
            // admNoDataGridViewTextBoxColumn
            // 
            this.admNoDataGridViewTextBoxColumn.DataPropertyName = "AdmNo";
            this.admNoDataGridViewTextBoxColumn.HeaderText = "AdmNo";
            this.admNoDataGridViewTextBoxColumn.Name = "admNoDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewCheckBoxColumn
            // 
            this.genderDataGridViewCheckBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewCheckBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewCheckBoxColumn.Name = "genderDataGridViewCheckBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // facultyDataGridViewTextBoxColumn
            // 
            this.facultyDataGridViewTextBoxColumn.DataPropertyName = "Faculty";
            this.facultyDataGridViewTextBoxColumn.HeaderText = "Faculty";
            this.facultyDataGridViewTextBoxColumn.Name = "facultyDataGridViewTextBoxColumn";
            // 
            // totalAttendanceDataGridViewTextBoxColumn
            // 
            this.totalAttendanceDataGridViewTextBoxColumn.DataPropertyName = "Total_Attendance";
            this.totalAttendanceDataGridViewTextBoxColumn.HeaderText = "Total_Attendance";
            this.totalAttendanceDataGridViewTextBoxColumn.Name = "totalAttendanceDataGridViewTextBoxColumn";
            // 
            // attendanceReportBindingSource
            // 
            this.attendanceReportBindingSource.DataSource = typeof(MMUSIS1.AttendanceReport);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(457, 417);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save DG Values";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // studAttendancerpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 461);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAdm);
            this.Controls.Add(this.lblUnitName);
            this.Controls.Add(this.lblUnitCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAdmNo);
            this.Controls.Add(this.picUnitName);
            this.Controls.Add(this.picUnitCode);
            this.Controls.Add(this.picName);
            this.Controls.Add(this.picAdm);
            this.Controls.Add(this.txtUnitName);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtUnitCode);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtFaculty);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "studAttendancerpt";
            this.Text = "Student Attendance Report";
            this.Load += new System.EventHandler(this.studAttendancerpt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnitCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnitName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceReportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime dtFrom;
        private MetroFramework.Controls.MetroDateTime dtTo;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtFaculty;
        private MetroFramework.Controls.MetroTextBox txtTotal;
        private MetroFramework.Controls.MetroTextBox txtUnit;
        private MetroFramework.Controls.MetroTextBox txtCourse;
        private MetroFramework.Controls.MetroTextBox txtGender;
        private MetroFramework.Controls.MetroTextBox txtDOB;
        private System.Windows.Forms.BindingSource attendanceReportBindingSource;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn admNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn genderDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAttendanceDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtUnitCode;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtUnitName;
        private System.Windows.Forms.PictureBox picAdm;
        private System.Windows.Forms.PictureBox picName;
        private System.Windows.Forms.PictureBox picUnitCode;
        private System.Windows.Forms.PictureBox picUnitName;
        private System.Windows.Forms.Label lblAdmNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUnitCode;
        private System.Windows.Forms.Label lblUnitName;
        private MetroFramework.Controls.MetroTextBox txtAdm;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}