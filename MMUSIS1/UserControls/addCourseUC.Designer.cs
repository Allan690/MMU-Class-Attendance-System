namespace MMUSIS1.UserControls
{
    partial class addCourseUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addCourseUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCoursename = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCoursecode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFaculty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDepartment = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCoursecode = new System.Windows.Forms.Label();
            this.lblCoursename = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.picDepartment = new System.Windows.Forms.PictureBox();
            this.picFaculty = new System.Windows.Forms.PictureBox();
            this.picCourseName = new System.Windows.Forms.PictureBox();
            this.picCourseCode = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.FieldChecker = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.sysUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFaculty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCourseName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCourseCode)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(548, 198);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 31);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Turquoise;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(441, 198);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 31);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCoursename
            // 
            this.txtCoursename.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCoursename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCoursename.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCoursename.ForeColor = System.Drawing.Color.Black;
            this.txtCoursename.HintForeColor = System.Drawing.Color.Empty;
            this.txtCoursename.HintText = "";
            this.txtCoursename.isPassword = false;
            this.txtCoursename.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCoursename.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCoursename.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCoursename.LineThickness = 3;
            this.txtCoursename.Location = new System.Drawing.Point(149, 75);
            this.txtCoursename.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoursename.Name = "txtCoursename";
            this.txtCoursename.Size = new System.Drawing.Size(183, 33);
            this.txtCoursename.TabIndex = 30;
            this.txtCoursename.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCoursename.OnValueChanged += new System.EventHandler(this.txtCoursename_OnValueChanged);
            this.txtCoursename.Leave += new System.EventHandler(this.txtCoursename_Leave);
            // 
            // txtCoursecode
            // 
            this.txtCoursecode.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCoursecode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCoursecode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCoursecode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCoursecode.HintForeColor = System.Drawing.Color.Empty;
            this.txtCoursecode.HintText = "";
            this.txtCoursecode.isPassword = false;
            this.txtCoursecode.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCoursecode.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCoursecode.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCoursecode.LineThickness = 3;
            this.txtCoursecode.Location = new System.Drawing.Point(149, 14);
            this.txtCoursecode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoursecode.Name = "txtCoursecode";
            this.txtCoursecode.Size = new System.Drawing.Size(181, 33);
            this.txtCoursecode.TabIndex = 31;
            this.txtCoursecode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCoursecode.OnValueChanged += new System.EventHandler(this.txtCoursecode_OnValueChanged);
            this.txtCoursecode.Leave += new System.EventHandler(this.txtCoursecode_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Course Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Course Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Faculty:";
            // 
            // txtFaculty
            // 
            this.txtFaculty.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtFaculty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFaculty.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFaculty.ForeColor = System.Drawing.Color.Black;
            this.txtFaculty.HintForeColor = System.Drawing.Color.Empty;
            this.txtFaculty.HintText = "";
            this.txtFaculty.isPassword = false;
            this.txtFaculty.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtFaculty.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFaculty.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtFaculty.LineThickness = 3;
            this.txtFaculty.Location = new System.Drawing.Point(147, 131);
            this.txtFaculty.Margin = new System.Windows.Forms.Padding(4);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(183, 33);
            this.txtFaculty.TabIndex = 30;
            this.txtFaculty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFaculty.OnValueChanged += new System.EventHandler(this.txtFaculty_OnValueChanged);
            this.txtFaculty.Leave += new System.EventHandler(this.txtFaculty_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Department:";
            // 
            // txtDepartment
            // 
            this.txtDepartment.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDepartment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDepartment.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDepartment.ForeColor = System.Drawing.Color.Black;
            this.txtDepartment.HintForeColor = System.Drawing.Color.Empty;
            this.txtDepartment.HintText = "";
            this.txtDepartment.isPassword = false;
            this.txtDepartment.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDepartment.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDepartment.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDepartment.LineThickness = 3;
            this.txtDepartment.Location = new System.Drawing.Point(147, 190);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(183, 33);
            this.txtDepartment.TabIndex = 30;
            this.txtDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDepartment.OnValueChanged += new System.EventHandler(this.txtDepartment_OnValueChanged);
            this.txtDepartment.Leave += new System.EventHandler(this.txtDepartment_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(396, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearch.HintText = "";
            this.txtSearch.isPassword = false;
            this.txtSearch.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSearch.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSearch.LineThickness = 3;
            this.txtSearch.Location = new System.Drawing.Point(467, 19);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(160, 33);
            this.txtSearch.TabIndex = 31;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.OnValueChanged += new System.EventHandler(this.txtSearch_OnValueChanged);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(656, 198);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 31);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblCoursecode
            // 
            this.lblCoursecode.AutoSize = true;
            this.lblCoursecode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoursecode.Location = new System.Drawing.Point(339, 61);
            this.lblCoursecode.Name = "lblCoursecode";
            this.lblCoursecode.Size = new System.Drawing.Size(0, 17);
            this.lblCoursecode.TabIndex = 40;
            // 
            // lblCoursename
            // 
            this.lblCoursename.AutoSize = true;
            this.lblCoursename.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoursename.Location = new System.Drawing.Point(339, 122);
            this.lblCoursename.Name = "lblCoursename";
            this.lblCoursename.Size = new System.Drawing.Size(0, 17);
            this.lblCoursename.TabIndex = 41;
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaculty.Location = new System.Drawing.Point(339, 180);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(0, 17);
            this.lblFaculty.TabIndex = 42;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(339, 237);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(0, 17);
            this.lblDepartment.TabIndex = 43;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(636, 55);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(0, 17);
            this.lblSearch.TabIndex = 44;
            // 
            // picSearch
            // 
            this.picSearch.Location = new System.Drawing.Point(639, 21);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(43, 31);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 39;
            this.picSearch.TabStop = false;
            // 
            // picDepartment
            // 
            this.picDepartment.Location = new System.Drawing.Point(337, 203);
            this.picDepartment.Name = "picDepartment";
            this.picDepartment.Size = new System.Drawing.Size(43, 31);
            this.picDepartment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDepartment.TabIndex = 37;
            this.picDepartment.TabStop = false;
            // 
            // picFaculty
            // 
            this.picFaculty.Location = new System.Drawing.Point(337, 146);
            this.picFaculty.Name = "picFaculty";
            this.picFaculty.Size = new System.Drawing.Size(43, 31);
            this.picFaculty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFaculty.TabIndex = 37;
            this.picFaculty.TabStop = false;
            // 
            // picCourseName
            // 
            this.picCourseName.Location = new System.Drawing.Point(337, 88);
            this.picCourseName.Name = "picCourseName";
            this.picCourseName.Size = new System.Drawing.Size(43, 31);
            this.picCourseName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCourseName.TabIndex = 37;
            this.picCourseName.TabStop = false;
            // 
            // picCourseCode
            // 
            this.picCourseCode.Location = new System.Drawing.Point(337, 27);
            this.picCourseCode.Name = "picCourseCode";
            this.picCourseCode.Size = new System.Drawing.Size(43, 31);
            this.picCourseCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCourseCode.TabIndex = 37;
            this.picCourseCode.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDate,
            this.lblTime,
            this.toolStripSplitButton1,
            this.FieldChecker,
            this.toolStripSplitButton2,
            this.sysUser,
            this.toolStripSplitButton3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(812, 22);
            this.statusStrip1.TabIndex = 45;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(141, 17);
            this.lblDate.Text = "toolStripStatusLabel1";
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(141, 17);
            this.lblTime.Text = "toolStripStatusLabel1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // FieldChecker
            // 
            this.FieldChecker.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FieldChecker.Name = "FieldChecker";
            this.FieldChecker.Size = new System.Drawing.Size(129, 17);
            this.FieldChecker.Text = "No changes made";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            // 
            // sysUser
            // 
            this.sysUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sysUser.Name = "sysUser";
            this.sysUser.Size = new System.Drawing.Size(178, 17);
            this.sysUser.Text = "The Current System User is: ";
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton3.Text = "toolStripSplitButton3";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
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
            this.metroGrid1.Location = new System.Drawing.Point(3, 257);
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
            this.metroGrid1.Size = new System.Drawing.Size(754, 154);
            this.metroGrid1.TabIndex = 46;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // addCourseUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.lblCoursename);
            this.Controls.Add(this.lblCoursecode);
            this.Controls.Add(this.picSearch);
            this.Controls.Add(this.picDepartment);
            this.Controls.Add(this.picFaculty);
            this.Controls.Add(this.picCourseName);
            this.Controls.Add(this.picCourseCode);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtFaculty);
            this.Controls.Add(this.txtCoursename);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtCoursecode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "addCourseUC";
            this.Size = new System.Drawing.Size(812, 486);
            this.Load += new System.EventHandler(this.addCourseUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFaculty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCourseName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCourseCode)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCoursename;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCoursecode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFaculty;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDepartment;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox picCourseCode;
        private System.Windows.Forms.PictureBox picCourseName;
        private System.Windows.Forms.PictureBox picFaculty;
        private System.Windows.Forms.PictureBox picDepartment;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Label lblCoursecode;
        private System.Windows.Forms.Label lblCoursename;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripStatusLabel FieldChecker;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripStatusLabel sysUser;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private MetroFramework.Controls.MetroGrid metroGrid1;
    }
}
