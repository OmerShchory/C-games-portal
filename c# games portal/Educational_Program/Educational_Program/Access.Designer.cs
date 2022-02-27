namespace Educational_Program
{
    partial class access_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(access_frm));
            this.header_lbl = new System.Windows.Forms.Label();
            this.UserEmail_txt = new System.Windows.Forms.TextBox();
            this.sendEmail_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header_lbl
            // 
            this.header_lbl.AutoSize = true;
            this.header_lbl.BackColor = System.Drawing.SystemColors.ControlText;
            this.header_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.header_lbl.ForeColor = System.Drawing.Color.White;
            this.header_lbl.Location = new System.Drawing.Point(44, 20);
            this.header_lbl.Name = "header_lbl";
            this.header_lbl.Size = new System.Drawing.Size(588, 25);
            this.header_lbl.TabIndex = 0;
            this.header_lbl.Text = "Please enter your email address to access the system:\r\n";
            // 
            // UserEmail_txt
            // 
            this.UserEmail_txt.Location = new System.Drawing.Point(209, 88);
            this.UserEmail_txt.Name = "UserEmail_txt";
            this.UserEmail_txt.Size = new System.Drawing.Size(200, 20);
            this.UserEmail_txt.TabIndex = 1;
            // 
            // sendEmail_btn
            // 
            this.sendEmail_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sendEmail_btn.Font = new System.Drawing.Font("Californian FB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendEmail_btn.Location = new System.Drawing.Point(244, 168);
            this.sendEmail_btn.Name = "sendEmail_btn";
            this.sendEmail_btn.Size = new System.Drawing.Size(125, 52);
            this.sendEmail_btn.TabIndex = 2;
            this.sendEmail_btn.Text = "Start";
            this.sendEmail_btn.UseVisualStyleBackColor = false;
            this.sendEmail_btn.Click += new System.EventHandler(this.sendEmail_btn_Click);
            this.sendEmail_btn.MouseHover += new System.EventHandler(this.sendEmail_btn_MouseHover);
            // 
            // access_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(651, 269);
            this.Controls.Add(this.sendEmail_btn);
            this.Controls.Add(this.UserEmail_txt);
            this.Controls.Add(this.header_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "access_frm";
            this.Text = "Identification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header_lbl;
        private System.Windows.Forms.TextBox UserEmail_txt;
        private System.Windows.Forms.Button sendEmail_btn;
    }
}

