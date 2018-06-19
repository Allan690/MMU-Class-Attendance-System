namespace MMUSIS1
{
    partial class errForm
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.icon = new System.Windows.Forms.PictureBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.icon_delay = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.ForeColor = System.Drawing.Color.Ivory;
            this.metroButton1.Location = new System.Drawing.Point(61, 222);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(117, 27);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Ok";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(124, 178);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(234, 17);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "Do you want to exit MMUSAS V 1.0?";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.icon.Image = global::MMUSIS1.Properties.Resources.errorbtn;
            this.icon.Location = new System.Drawing.Point(127, 25);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(223, 126);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 3;
            this.icon.TabStop = false;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.SeaGreen;
            this.metroButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton2.ForeColor = System.Drawing.Color.Ivory;
            this.metroButton2.Location = new System.Drawing.Point(292, 222);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(117, 27);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Cancel";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 8;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            this.bunifuFormFadeTransition1.TransitionEnd += new System.EventHandler(this.bunifuFormFadeTransition1_TransitionEnd);
            // 
            // icon_delay
            // 
            this.icon_delay.Enabled = true;
            this.icon_delay.Interval = 5000;
            this.icon_delay.Tick += new System.EventHandler(this.icon_delay_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "MMUSAS V 1.0";
            // 
            // errForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(510, 282);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "errForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "errForm";
            this.Load += new System.EventHandler(this.errForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox icon;
        private MetroFramework.Controls.MetroButton metroButton2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private System.Windows.Forms.Timer icon_delay;
        private System.Windows.Forms.Label label2;
    }
}