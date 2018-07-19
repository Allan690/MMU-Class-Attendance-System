namespace MMUSIS1
{
    partial class QRCodeGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRCodeGenerator));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtWidth = new MetroFramework.Controls.MetroTextBox();
            this.comboFore = new System.Windows.Forms.ComboBox();
            this.comboBack = new System.Windows.Forms.ComboBox();
            this.txtLeftMargin = new MetroFramework.Controls.MetroTextBox();
            this.txtRightMargin = new MetroFramework.Controls.MetroTextBox();
            this.txtTopMargin = new MetroFramework.Controls.MetroTextBox();
            this.txtBottomMargin = new MetroFramework.Controls.MetroTextBox();
            this.comboError = new System.Windows.Forms.ComboBox();
            this.btnQRCode = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAdm = new MetroFramework.Controls.MetroTextBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(10, 333);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(324, 158);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // txtWidth
            // 
            // 
            // 
            // 
            this.txtWidth.CustomButton.Image = null;
            this.txtWidth.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtWidth.CustomButton.Name = "";
            this.txtWidth.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtWidth.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWidth.CustomButton.TabIndex = 1;
            this.txtWidth.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWidth.CustomButton.UseSelectable = true;
            this.txtWidth.CustomButton.Visible = false;
            this.txtWidth.Lines = new string[0];
            this.txtWidth.Location = new System.Drawing.Point(561, 151);
            this.txtWidth.MaxLength = 32767;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.PasswordChar = '\0';
            this.txtWidth.PromptText = "Width of the QR Code";
            this.txtWidth.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWidth.SelectedText = "";
            this.txtWidth.SelectionLength = 0;
            this.txtWidth.SelectionStart = 0;
            this.txtWidth.ShortcutsEnabled = true;
            this.txtWidth.Size = new System.Drawing.Size(157, 23);
            this.txtWidth.TabIndex = 2;
            this.txtWidth.UseSelectable = true;
            this.txtWidth.WaterMark = "Width of the QR Code";
            this.txtWidth.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWidth.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboFore
            // 
            this.comboFore.FormattingEnabled = true;
            this.comboFore.Items.AddRange(new object[] {
            "Black",
            "White",
            "Blue",
            "Purple",
            "Grey",
            "Indigo",
            "Violet"});
            this.comboFore.Location = new System.Drawing.Point(561, 84);
            this.comboFore.Name = "comboFore";
            this.comboFore.Size = new System.Drawing.Size(157, 21);
            this.comboFore.TabIndex = 0;
            // 
            // comboBack
            // 
            this.comboBack.FormattingEnabled = true;
            this.comboBack.Items.AddRange(new object[] {
            "White",
            "Black",
            "Blue",
            "Purple",
            "Grey",
            "Indigo",
            "Violet"});
            this.comboBack.Location = new System.Drawing.Point(561, 117);
            this.comboBack.Name = "comboBack";
            this.comboBack.Size = new System.Drawing.Size(157, 21);
            this.comboBack.TabIndex = 1;
            // 
            // txtLeftMargin
            // 
            // 
            // 
            // 
            this.txtLeftMargin.CustomButton.Image = null;
            this.txtLeftMargin.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtLeftMargin.CustomButton.Name = "";
            this.txtLeftMargin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLeftMargin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLeftMargin.CustomButton.TabIndex = 1;
            this.txtLeftMargin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLeftMargin.CustomButton.UseSelectable = true;
            this.txtLeftMargin.CustomButton.Visible = false;
            this.txtLeftMargin.Lines = new string[0];
            this.txtLeftMargin.Location = new System.Drawing.Point(561, 185);
            this.txtLeftMargin.MaxLength = 32767;
            this.txtLeftMargin.Name = "txtLeftMargin";
            this.txtLeftMargin.PasswordChar = '\0';
            this.txtLeftMargin.PromptText = "Distance from the left margin";
            this.txtLeftMargin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLeftMargin.SelectedText = "";
            this.txtLeftMargin.SelectionLength = 0;
            this.txtLeftMargin.SelectionStart = 0;
            this.txtLeftMargin.ShortcutsEnabled = true;
            this.txtLeftMargin.Size = new System.Drawing.Size(157, 23);
            this.txtLeftMargin.TabIndex = 3;
            this.txtLeftMargin.UseSelectable = true;
            this.txtLeftMargin.WaterMark = "Distance from the left margin";
            this.txtLeftMargin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLeftMargin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRightMargin
            // 
            // 
            // 
            // 
            this.txtRightMargin.CustomButton.Image = null;
            this.txtRightMargin.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtRightMargin.CustomButton.Name = "";
            this.txtRightMargin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRightMargin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRightMargin.CustomButton.TabIndex = 1;
            this.txtRightMargin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRightMargin.CustomButton.UseSelectable = true;
            this.txtRightMargin.CustomButton.Visible = false;
            this.txtRightMargin.Lines = new string[0];
            this.txtRightMargin.Location = new System.Drawing.Point(561, 221);
            this.txtRightMargin.MaxLength = 32767;
            this.txtRightMargin.Name = "txtRightMargin";
            this.txtRightMargin.PasswordChar = '\0';
            this.txtRightMargin.PromptText = "Distance from the right margin";
            this.txtRightMargin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRightMargin.SelectedText = "";
            this.txtRightMargin.SelectionLength = 0;
            this.txtRightMargin.SelectionStart = 0;
            this.txtRightMargin.ShortcutsEnabled = true;
            this.txtRightMargin.Size = new System.Drawing.Size(157, 23);
            this.txtRightMargin.TabIndex = 4;
            this.txtRightMargin.UseSelectable = true;
            this.txtRightMargin.WaterMark = "Distance from the right margin";
            this.txtRightMargin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRightMargin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTopMargin
            // 
            // 
            // 
            // 
            this.txtTopMargin.CustomButton.Image = null;
            this.txtTopMargin.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtTopMargin.CustomButton.Name = "";
            this.txtTopMargin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTopMargin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTopMargin.CustomButton.TabIndex = 1;
            this.txtTopMargin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTopMargin.CustomButton.UseSelectable = true;
            this.txtTopMargin.CustomButton.Visible = false;
            this.txtTopMargin.Lines = new string[0];
            this.txtTopMargin.Location = new System.Drawing.Point(561, 257);
            this.txtTopMargin.MaxLength = 32767;
            this.txtTopMargin.Name = "txtTopMargin";
            this.txtTopMargin.PasswordChar = '\0';
            this.txtTopMargin.PromptText = "Distance from the top margin";
            this.txtTopMargin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTopMargin.SelectedText = "";
            this.txtTopMargin.SelectionLength = 0;
            this.txtTopMargin.SelectionStart = 0;
            this.txtTopMargin.ShortcutsEnabled = true;
            this.txtTopMargin.Size = new System.Drawing.Size(157, 23);
            this.txtTopMargin.TabIndex = 5;
            this.txtTopMargin.UseSelectable = true;
            this.txtTopMargin.WaterMark = "Distance from the top margin";
            this.txtTopMargin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTopMargin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBottomMargin
            // 
            // 
            // 
            // 
            this.txtBottomMargin.CustomButton.Image = null;
            this.txtBottomMargin.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtBottomMargin.CustomButton.Name = "";
            this.txtBottomMargin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBottomMargin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBottomMargin.CustomButton.TabIndex = 1;
            this.txtBottomMargin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBottomMargin.CustomButton.UseSelectable = true;
            this.txtBottomMargin.CustomButton.Visible = false;
            this.txtBottomMargin.Lines = new string[0];
            this.txtBottomMargin.Location = new System.Drawing.Point(561, 296);
            this.txtBottomMargin.MaxLength = 32767;
            this.txtBottomMargin.Name = "txtBottomMargin";
            this.txtBottomMargin.PasswordChar = '\0';
            this.txtBottomMargin.PromptText = "Distance from the bottom margin";
            this.txtBottomMargin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBottomMargin.SelectedText = "";
            this.txtBottomMargin.SelectionLength = 0;
            this.txtBottomMargin.SelectionStart = 0;
            this.txtBottomMargin.ShortcutsEnabled = true;
            this.txtBottomMargin.Size = new System.Drawing.Size(157, 23);
            this.txtBottomMargin.TabIndex = 6;
            this.txtBottomMargin.UseSelectable = true;
            this.txtBottomMargin.WaterMark = "Distance from the bottom margin";
            this.txtBottomMargin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBottomMargin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboError
            // 
            this.comboError.FormattingEnabled = true;
            this.comboError.Items.AddRange(new object[] {
            "L",
            "M",
            "Q",
            "H"});
            this.comboError.Location = new System.Drawing.Point(649, 344);
            this.comboError.Name = "comboError";
            this.comboError.Size = new System.Drawing.Size(69, 21);
            this.comboError.TabIndex = 7;
            // 
            // btnQRCode
            // 
            this.btnQRCode.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQRCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQRCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQRCode.BorderRadius = 0;
            this.btnQRCode.ButtonText = "Create QR Code";
            this.btnQRCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQRCode.DisabledColor = System.Drawing.Color.Gray;
            this.btnQRCode.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQRCode.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQRCode.Iconimage")));
            this.btnQRCode.Iconimage_right = null;
            this.btnQRCode.Iconimage_right_Selected = null;
            this.btnQRCode.Iconimage_Selected = null;
            this.btnQRCode.IconMarginLeft = 0;
            this.btnQRCode.IconMarginRight = 0;
            this.btnQRCode.IconRightVisible = true;
            this.btnQRCode.IconRightZoom = 0D;
            this.btnQRCode.IconVisible = true;
            this.btnQRCode.IconZoom = 90D;
            this.btnQRCode.IsTab = false;
            this.btnQRCode.Location = new System.Drawing.Point(344, 442);
            this.btnQRCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQRCode.Name = "btnQRCode";
            this.btnQRCode.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQRCode.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnQRCode.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQRCode.selected = false;
            this.btnQRCode.Size = new System.Drawing.Size(188, 50);
            this.btnQRCode.TabIndex = 8;
            this.btnQRCode.Text = "Create QR Code";
            this.btnQRCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQRCode.Textcolor = System.Drawing.Color.White;
            this.btnQRCode.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQRCode.Click += new System.EventHandler(this.btnQRCode_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.ButtonText = "Save QR Code";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdd.Iconimage")));
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = true;
            this.btnAdd.IconZoom = 90D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(561, 442);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.OnHovercolor = System.Drawing.Color.Olive;
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(176, 49);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Save QR Code";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Fore Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Back Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "X(width):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(449, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Left Margin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(449, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Right Margin:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(448, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Top Margin:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(448, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Bottom Margin:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(448, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Error Correction Level:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "QR Code Data:";
            // 
            // txtAdm
            // 
            // 
            // 
            // 
            this.txtAdm.CustomButton.Image = null;
            this.txtAdm.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtAdm.CustomButton.Name = "";
            this.txtAdm.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdm.CustomButton.TabIndex = 1;
            this.txtAdm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdm.CustomButton.UseSelectable = true;
            this.txtAdm.CustomButton.Visible = false;
            this.txtAdm.Lines = new string[0];
            this.txtAdm.Location = new System.Drawing.Point(580, 403);
            this.txtAdm.MaxLength = 32767;
            this.txtAdm.Name = "txtAdm";
            this.txtAdm.PasswordChar = '\0';
            this.txtAdm.PromptText = "Student name";
            this.txtAdm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdm.SelectedText = "";
            this.txtAdm.SelectionLength = 0;
            this.txtAdm.SelectionStart = 0;
            this.txtAdm.ShortcutsEnabled = true;
            this.txtAdm.Size = new System.Drawing.Size(184, 23);
            this.txtAdm.TabIndex = 25;
            this.txtAdm.UseSelectable = true;
            this.txtAdm.WaterMark = "Student name";
            this.txtAdm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.metroGrid1.DataSource = this.studentsBindingSource;
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
            this.metroGrid1.Location = new System.Drawing.Point(340, 7);
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
            this.metroGrid1.Size = new System.Drawing.Size(424, 68);
            this.metroGrid1.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(358, 403);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Admission number";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(184, 23);
            this.metroTextBox1.TabIndex = 28;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Admission number";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // QRCodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 506);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.txtAdm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnQRCode);
            this.Controls.Add(this.comboError);
            this.Controls.Add(this.comboBack);
            this.Controls.Add(this.comboFore);
            this.Controls.Add(this.txtBottomMargin);
            this.Controls.Add(this.txtTopMargin);
            this.Controls.Add(this.txtRightMargin);
            this.Controls.Add(this.txtLeftMargin);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "QRCodeGenerator";
            this.Text = "QR Code Generator";
            this.Load += new System.EventHandler(this.QRCodeGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private MetroFramework.Controls.MetroTextBox txtWidth;
        private System.Windows.Forms.ComboBox comboFore;
        private System.Windows.Forms.ComboBox comboBack;
        private MetroFramework.Controls.MetroTextBox txtLeftMargin;
        private MetroFramework.Controls.MetroTextBox txtRightMargin;
        private MetroFramework.Controls.MetroTextBox txtTopMargin;
        private MetroFramework.Controls.MetroTextBox txtBottomMargin;
        private System.Windows.Forms.ComboBox comboError;
        private Bunifu.Framework.UI.BunifuFlatButton btnQRCode;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroTextBox txtAdm;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn admNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn qrcodeDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}