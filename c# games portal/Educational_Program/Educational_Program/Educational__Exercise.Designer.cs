namespace Educational_Program
{
    partial class Educational_Manual_Mode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Educational_Manual_Mode));
            this.Letters_study_lbl = new System.Windows.Forms.Label();
            this.Word_lbl = new System.Windows.Forms.Label();
            this.timer_tmr = new System.Windows.Forms.Timer(this.components);
            this.pic_display = new System.Windows.Forms.PictureBox();
            this.Right_btn = new System.Windows.Forms.Button();
            this.Left_btn = new System.Windows.Forms.Button();
            this.time_left_lbl = new System.Windows.Forms.Label();
            this.stop_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_display)).BeginInit();
            this.SuspendLayout();
            // 
            // Letters_study_lbl
            // 
            this.Letters_study_lbl.AutoSize = true;
            this.Letters_study_lbl.Font = new System.Drawing.Font("Lucida Sans Typewriter", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Letters_study_lbl.Location = new System.Drawing.Point(340, 9);
            this.Letters_study_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Letters_study_lbl.Name = "Letters_study_lbl";
            this.Letters_study_lbl.Size = new System.Drawing.Size(552, 59);
            this.Letters_study_lbl.TabIndex = 7;
            this.Letters_study_lbl.Text = "Letters Exercise:";
            // 
            // Word_lbl
            // 
            this.Word_lbl.AutoSize = true;
            this.Word_lbl.Font = new System.Drawing.Font("Perpetua Titling MT", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word_lbl.ForeColor = System.Drawing.Color.Navy;
            this.Word_lbl.Location = new System.Drawing.Point(48, 326);
            this.Word_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Word_lbl.Name = "Word_lbl";
            this.Word_lbl.Size = new System.Drawing.Size(340, 63);
            this.Word_lbl.TabIndex = 11;
            this.Word_lbl.Text = "The Word";
            // 
            // timer_tmr
            // 
            this.timer_tmr.Interval = 1000;
            this.timer_tmr.Tick += new System.EventHandler(this.timer_tmr_Tick);
            // 
            // pic_display
            // 
            this.pic_display.Location = new System.Drawing.Point(482, 195);
            this.pic_display.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_display.Name = "pic_display";
            this.pic_display.Size = new System.Drawing.Size(411, 395);
            this.pic_display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_display.TabIndex = 8;
            this.pic_display.TabStop = false;
            // 
            // Right_btn
            // 
            this.Right_btn.BackColor = System.Drawing.Color.Transparent;
            this.Right_btn.BackgroundImage = global::Educational_Program.Properties.Resources.red_arrow_PddG3;
            this.Right_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Right_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Right_btn.Location = new System.Drawing.Point(938, 525);
            this.Right_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Right_btn.Name = "Right_btn";
            this.Right_btn.Size = new System.Drawing.Size(250, 105);
            this.Right_btn.TabIndex = 1;
            this.Right_btn.UseVisualStyleBackColor = false;
            this.Right_btn.Click += new System.EventHandler(this.Right_btn_Click);
            // 
            // Left_btn
            // 
            this.Left_btn.BackgroundImage = global::Educational_Program.Properties.Resources.red_arrow_PddG31;
            this.Left_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Left_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Left_btn.Location = new System.Drawing.Point(82, 525);
            this.Left_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Left_btn.Name = "Left_btn";
            this.Left_btn.Size = new System.Drawing.Size(226, 105);
            this.Left_btn.TabIndex = 0;
            this.Left_btn.UseVisualStyleBackColor = true;
            this.Left_btn.Click += new System.EventHandler(this.Left_btn_Click);
            // 
            // time_left_lbl
            // 
            this.time_left_lbl.AutoSize = true;
            this.time_left_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_left_lbl.Location = new System.Drawing.Point(51, 55);
            this.time_left_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time_left_lbl.Name = "time_left_lbl";
            this.time_left_lbl.Size = new System.Drawing.Size(138, 46);
            this.time_left_lbl.TabIndex = 12;
            this.time_left_lbl.Text = "Timer:";
            this.time_left_lbl.Visible = false;
            // 
            // stop_btn
            // 
            this.stop_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.stop_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.stop_btn.Location = new System.Drawing.Point(482, 94);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(224, 82);
            this.stop_btn.TabIndex = 13;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = false;
            this.stop_btn.Visible = false;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // Educational_Manual_Mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1206, 703);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.time_left_lbl);
            this.Controls.Add(this.Word_lbl);
            this.Controls.Add(this.pic_display);
            this.Controls.Add(this.Letters_study_lbl);
            this.Controls.Add(this.Right_btn);
            this.Controls.Add(this.Left_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Educational_Manual_Mode";
            this.Text = "Letters Exercise";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Educational_Manual_Mode_FormClosing);
            this.Load += new System.EventHandler(this.Educational_Manual_Mode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Left_btn;
        private System.Windows.Forms.Button Right_btn;
        private System.Windows.Forms.Label Letters_study_lbl;
        private System.Windows.Forms.PictureBox pic_display;
        private System.Windows.Forms.Label Word_lbl;
        private System.Windows.Forms.Timer timer_tmr;
        private System.Windows.Forms.Label time_left_lbl;
        private System.Windows.Forms.Button stop_btn;
    }
}