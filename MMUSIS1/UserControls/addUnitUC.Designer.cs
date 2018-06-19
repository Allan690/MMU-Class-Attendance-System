namespace MMUSIS1.UserControls
{
    partial class addUnitUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUnitCode = new System.Windows.Forms.Label();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.pContainer = new System.Windows.Forms.Panel();
            this.lblSearch1 = new System.Windows.Forms.Label();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.txtCourse = new MetroFramework.Controls.MetroTextBox();
            this.txtUnitName = new MetroFramework.Controls.MetroTextBox();
            this.txtUnitCode = new MetroFramework.Controls.MetroTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.FieldChecker = new System.Windows.Forms.ToolStripStatusLabel();
            this.sysUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picUnitName = new System.Windows.Forms.PictureBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.picUnitCode = new System.Windows.Forms.PictureBox();
            this.picCourse = new System.Windows.Forms.PictureBox();
            this.unitCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUnitName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnitCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(196, 365);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 31);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Turquoise;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(84, 365);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 31);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(318, 365);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 31);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(351, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Search:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Unit Code:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Course:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Unit Name:";
            // 
            // lblUnitCode
            // 
            this.lblUnitCode.AutoSize = true;
            this.lblUnitCode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitCode.Location = new System.Drawing.Point(282, 56);
            this.lblUnitCode.Name = "lblUnitCode";
            this.lblUnitCode.Size = new System.Drawing.Size(0, 17);
            this.lblUnitCode.TabIndex = 33;
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitName.Location = new System.Drawing.Point(282, 115);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(0, 17);
            this.lblUnitName.TabIndex = 34;
            this.lblUnitName.Click += new System.EventHandler(this.lblUnitName_Click);
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(590, 58);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(0, 17);
            this.lblCourse.TabIndex = 34;
            // 
            // pContainer
            // 
            this.pContainer.Controls.Add(this.lblSearch1);
            this.pContainer.Controls.Add(this.txtSearch);
            this.pContainer.Controls.Add(this.txtCourse);
            this.pContainer.Controls.Add(this.txtUnitName);
            this.pContainer.Controls.Add(this.txtUnitCode);
            this.pContainer.Controls.Add(this.lblCourse);
            this.pContainer.Controls.Add(this.lblUnitName);
            this.pContainer.Controls.Add(this.picUnitName);
            this.pContainer.Controls.Add(this.lblUnitCode);
            this.pContainer.Controls.Add(this.picSearch);
            this.pContainer.Controls.Add(this.picUnitCode);
            this.pContainer.Controls.Add(this.picCourse);
            this.pContainer.Controls.Add(this.label1);
            this.pContainer.Controls.Add(this.label3);
            this.pContainer.Controls.Add(this.label2);
            this.pContainer.Controls.Add(this.label4);
            this.pContainer.Location = new System.Drawing.Point(7, 3);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(792, 144);
            this.pContainer.TabIndex = 36;
            this.pContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pContainer_Paint);
            this.pContainer.Leave += new System.EventHandler(this.pContainer_Leave);
            this.pContainer.MouseLeave += new System.EventHandler(this.pContainer_MouseLeave);
            // 
            // lblSearch1
            // 
            this.lblSearch1.AutoSize = true;
            this.lblSearch1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch1.Location = new System.Drawing.Point(593, 120);
            this.lblSearch1.Name = "lblSearch1";
            this.lblSearch1.Size = new System.Drawing.Size(0, 17);
            this.lblSearch1.TabIndex = 41;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(422, 90);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(182, 23);
            this.txtSearch.TabIndex = 40;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // txtCourse
            // 
            // 
            // 
            // 
            this.txtCourse.CustomButton.Image = null;
            this.txtCourse.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txtCourse.CustomButton.Name = "";
            this.txtCourse.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCourse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCourse.CustomButton.TabIndex = 1;
            this.txtCourse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCourse.CustomButton.UseSelectable = true;
            this.txtCourse.CustomButton.Visible = false;
            this.txtCourse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitsBindingSource, "Course", true));
            this.txtCourse.Lines = new string[0];
            this.txtCourse.Location = new System.Drawing.Point(422, 32);
            this.txtCourse.MaxLength = 32767;
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.PasswordChar = '\0';
            this.txtCourse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCourse.SelectedText = "";
            this.txtCourse.SelectionLength = 0;
            this.txtCourse.SelectionStart = 0;
            this.txtCourse.ShortcutsEnabled = true;
            this.txtCourse.Size = new System.Drawing.Size(182, 23);
            this.txtCourse.TabIndex = 39;
            this.txtCourse.UseSelectable = true;
            this.txtCourse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCourse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCourse.Leave += new System.EventHandler(this.txtCourse_Leave);
            // 
            // txtUnitName
            // 
            // 
            // 
            // 
            this.txtUnitName.CustomButton.Image = null;
            this.txtUnitName.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtUnitName.CustomButton.Name = "";
            this.txtUnitName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUnitName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUnitName.CustomButton.TabIndex = 1;
            this.txtUnitName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUnitName.CustomButton.UseSelectable = true;
            this.txtUnitName.CustomButton.Visible = false;
            this.txtUnitName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitsBindingSource, "UnitName", true));
            this.txtUnitName.Lines = new string[0];
            this.txtUnitName.Location = new System.Drawing.Point(106, 89);
            this.txtUnitName.MaxLength = 32767;
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.PasswordChar = '\0';
            this.txtUnitName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUnitName.SelectedText = "";
            this.txtUnitName.SelectionLength = 0;
            this.txtUnitName.SelectionStart = 0;
            this.txtUnitName.ShortcutsEnabled = true;
            this.txtUnitName.Size = new System.Drawing.Size(171, 23);
            this.txtUnitName.TabIndex = 36;
            this.txtUnitName.UseSelectable = true;
            this.txtUnitName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUnitName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUnitName.Leave += new System.EventHandler(this.txtUnitName_Leave);
            // 
            // txtUnitCode
            // 
            // 
            // 
            // 
            this.txtUnitCode.CustomButton.Image = null;
            this.txtUnitCode.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtUnitCode.CustomButton.Name = "";
            this.txtUnitCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUnitCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUnitCode.CustomButton.TabIndex = 1;
            this.txtUnitCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUnitCode.CustomButton.UseSelectable = true;
            this.txtUnitCode.CustomButton.Visible = false;
            this.txtUnitCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitsBindingSource, "UnitCode", true));
            this.txtUnitCode.Lines = new string[0];
            this.txtUnitCode.Location = new System.Drawing.Point(106, 30);
            this.txtUnitCode.MaxLength = 32767;
            this.txtUnitCode.Name = "txtUnitCode";
            this.txtUnitCode.PasswordChar = '\0';
            this.txtUnitCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUnitCode.SelectedText = "";
            this.txtUnitCode.SelectionLength = 0;
            this.txtUnitCode.SelectionStart = 0;
            this.txtUnitCode.ShortcutsEnabled = true;
            this.txtUnitCode.Size = new System.Drawing.Size(171, 23);
            this.txtUnitCode.TabIndex = 35;
            this.txtUnitCode.UseSelectable = true;
            this.txtUnitCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUnitCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUnitCode.Leave += new System.EventHandler(this.txtUnitCode_Leave);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Turquoise;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(526, 365);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 31);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(425, 365);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 31);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.unitCodeDataGridViewTextBoxColumn,
            this.unitNameDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.unitsBindingSource;
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
            this.metroGrid1.Location = new System.Drawing.Point(7, 161);
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
            this.metroGrid1.Size = new System.Drawing.Size(792, 160);
            this.metroGrid1.TabIndex = 39;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            this.metroGrid1.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_RowLeave);
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
            this.statusStrip1.TabIndex = 46;
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
            // FieldChecker
            // 
            this.FieldChecker.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FieldChecker.Name = "FieldChecker";
            this.FieldChecker.Size = new System.Drawing.Size(129, 17);
            this.FieldChecker.Text = "No changes made";
            // 
            // sysUser
            // 
            this.sysUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sysUser.Name = "sysUser";
            this.sysUser.Size = new System.Drawing.Size(178, 17);
            this.sysUser.Text = "The Current System User is: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = global::MMUSIS1.Properties.Resources.studentlogo;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.Image = global::MMUSIS1.Properties.Resources.Student_321;
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.toolStripSplitButton3.Image = global::MMUSIS1.Properties.Resources.user;
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton3.Text = "toolStripSplitButton3";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // picUnitName
            // 
            this.picUnitName.Location = new System.Drawing.Point(300, 87);
            this.picUnitName.Name = "picUnitName";
            this.picUnitName.Size = new System.Drawing.Size(29, 25);
            this.picUnitName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUnitName.TabIndex = 32;
            this.picUnitName.TabStop = false;
            // 
            // picSearch
            // 
            this.picSearch.Location = new System.Drawing.Point(611, 92);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(29, 25);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 32;
            this.picSearch.TabStop = false;
            // 
            // picUnitCode
            // 
            this.picUnitCode.Location = new System.Drawing.Point(300, 28);
            this.picUnitCode.Name = "picUnitCode";
            this.picUnitCode.Size = new System.Drawing.Size(29, 25);
            this.picUnitCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUnitCode.TabIndex = 32;
            this.picUnitCode.TabStop = false;
            // 
            // picCourse
            // 
            this.picCourse.Location = new System.Drawing.Point(611, 32);
            this.picCourse.Name = "picCourse";
            this.picCourse.Size = new System.Drawing.Size(29, 25);
            this.picCourse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCourse.TabIndex = 32;
            this.picCourse.TabStop = false;
            this.picCourse.Click += new System.EventHandler(this.picCourse_Click);
            // 
            // unitCodeDataGridViewTextBoxColumn
            // 
            this.unitCodeDataGridViewTextBoxColumn.DataPropertyName = "UnitCode";
            this.unitCodeDataGridViewTextBoxColumn.HeaderText = "UnitCode";
            this.unitCodeDataGridViewTextBoxColumn.Name = "unitCodeDataGridViewTextBoxColumn";
            // 
            // unitNameDataGridViewTextBoxColumn
            // 
            this.unitNameDataGridViewTextBoxColumn.DataPropertyName = "UnitName";
            this.unitNameDataGridViewTextBoxColumn.HeaderText = "UnitName";
            this.unitNameDataGridViewTextBoxColumn.Name = "unitNameDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // unitsBindingSource
            // 
            this.unitsBindingSource.DataSource = typeof(MMUSIS1.Units);
            this.unitsBindingSource.CurrentChanged += new System.EventHandler(this.unitsBindingSource_CurrentChanged);
            // 
            // addUnitUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Name = "addUnitUC";
            this.Size = new System.Drawing.Size(812, 486);
            this.Load += new System.EventHandler(this.addUnitUC_Load);
            this.pContainer.ResumeLayout(false);
            this.pContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUnitName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUnitCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.BindingSource unitsBindingSource;
     
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picCourse;
        private System.Windows.Forms.PictureBox picUnitCode;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Label lblUnitCode;
        private System.Windows.Forms.PictureBox picUnitName;
        private System.Windows.Forms.Label lblUnitName;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTextBox txtUnitName;
        private MetroFramework.Controls.MetroTextBox txtUnitCode;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripStatusLabel FieldChecker;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripStatusLabel sysUser;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroTextBox txtCourse;
        private System.Windows.Forms.Label lblSearch1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
    }
}
