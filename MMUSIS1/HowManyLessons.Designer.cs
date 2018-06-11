namespace MMUSIS1
{
    partial class HowManyLessons
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCourse = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MMUSIS1.Properties.Resources.mmusas;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(195, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "How many lessons have you taught between the 2 dates?";
            // 
            // txtCourse
            // 
            // 
            // 
            // 
            this.txtCourse.CustomButton.Image = null;
            this.txtCourse.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.txtCourse.CustomButton.Name = "";
            this.txtCourse.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCourse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCourse.CustomButton.TabIndex = 1;
            this.txtCourse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCourse.CustomButton.UseSelectable = true;
            this.txtCourse.CustomButton.Visible = false;
            this.txtCourse.Lines = new string[0];
            this.txtCourse.Location = new System.Drawing.Point(250, 72);
            this.txtCourse.MaxLength = 32767;
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.PasswordChar = '\0';
            this.txtCourse.PromptText = "Enter the number of lessons taught";
            this.txtCourse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCourse.SelectedText = "";
            this.txtCourse.SelectionLength = 0;
            this.txtCourse.SelectionStart = 0;
            this.txtCourse.ShortcutsEnabled = true;
            this.txtCourse.Size = new System.Drawing.Size(220, 23);
            this.txtCourse.TabIndex = 21;
            this.txtCourse.UseSelectable = true;
            this.txtCourse.WaterMark = "Enter the number of lessons taught";
            this.txtCourse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCourse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCourse.TextChanged += new System.EventHandler(this.txtCourse_TextChanged);
            this.txtCourse.Click += new System.EventHandler(this.txtCourse_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(285, 110);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(96, 23);
            this.metroButton1.TabIndex = 22;
            this.metroButton1.Text = "Ok";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // HowManyLessons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(649, 154);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HowManyLessons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HowManyLessons";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtCourse;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}