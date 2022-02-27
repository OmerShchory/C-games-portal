namespace Educational_Program
{
    partial class Game_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_3));
            this.score_lbl_3 = new System.Windows.Forms.Label();
            this.header_game3 = new System.Windows.Forms.Label();
            this.timer_game3 = new System.Windows.Forms.Timer(this.components);
            this.lbl_timer = new System.Windows.Forms.Label();
            this.pic_sound = new System.Windows.Forms.PictureBox();
            this.pic3_picbx = new System.Windows.Forms.PictureBox();
            this.pic2_picbx = new System.Windows.Forms.PictureBox();
            this.pic1_picbx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3_picbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2_picbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1_picbx)).BeginInit();
            this.SuspendLayout();
            // 
            // score_lbl_3
            // 
            this.score_lbl_3.AutoSize = true;
            this.score_lbl_3.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lbl_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.score_lbl_3.Location = new System.Drawing.Point(11, 319);
            this.score_lbl_3.Name = "score_lbl_3";
            this.score_lbl_3.Size = new System.Drawing.Size(139, 40);
            this.score_lbl_3.TabIndex = 37;
            this.score_lbl_3.Text = "Score: 0";
            // 
            // header_game3
            // 
            this.header_game3.AutoSize = true;
            this.header_game3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_game3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.header_game3.Location = new System.Drawing.Point(9, 6);
            this.header_game3.Name = "header_game3";
            this.header_game3.Size = new System.Drawing.Size(535, 60);
            this.header_game3.TabIndex = 36;
            this.header_game3.Text = "Click the word that matches the sound. \r\nClick the speaker icon to hear the word " +
    "again.\r\n";
            // 
            // timer_game3
            // 
            this.timer_game3.Interval = 1000;
            this.timer_game3.Tick += new System.EventHandler(this.timer_game3_Tick);
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("Algerian", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_timer.Location = new System.Drawing.Point(13, 294);
            this.lbl_timer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(95, 25);
            this.lbl_timer.TabIndex = 39;
            this.lbl_timer.Text = "Timer: ";
            // 
            // pic_sound
            // 
            this.pic_sound.BackColor = System.Drawing.Color.Transparent;
            this.pic_sound.Image = global::Educational_Program.Properties.Resources.speaker_png_icon_speaker_circle_icon;
            this.pic_sound.Location = new System.Drawing.Point(329, 267);
            this.pic_sound.Name = "pic_sound";
            this.pic_sound.Size = new System.Drawing.Size(89, 77);
            this.pic_sound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_sound.TabIndex = 38;
            this.pic_sound.TabStop = false;
            this.pic_sound.Click += new System.EventHandler(this.pic_sound_Click_1);
            // 
            // pic3_picbx
            // 
            this.pic3_picbx.BackColor = System.Drawing.Color.Transparent;
            this.pic3_picbx.Location = new System.Drawing.Point(508, 106);
            this.pic3_picbx.Name = "pic3_picbx";
            this.pic3_picbx.Size = new System.Drawing.Size(145, 131);
            this.pic3_picbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic3_picbx.TabIndex = 35;
            this.pic3_picbx.TabStop = false;
            this.pic3_picbx.Click += new System.EventHandler(this.pic3_picbx_Click);
            // 
            // pic2_picbx
            // 
            this.pic2_picbx.BackColor = System.Drawing.Color.Transparent;
            this.pic2_picbx.Location = new System.Drawing.Point(299, 104);
            this.pic2_picbx.Name = "pic2_picbx";
            this.pic2_picbx.Size = new System.Drawing.Size(145, 131);
            this.pic2_picbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2_picbx.TabIndex = 34;
            this.pic2_picbx.TabStop = false;
            this.pic2_picbx.Click += new System.EventHandler(this.pic2_picbx_Click);
            // 
            // pic1_picbx
            // 
            this.pic1_picbx.BackColor = System.Drawing.Color.Transparent;
            this.pic1_picbx.Location = new System.Drawing.Point(105, 104);
            this.pic1_picbx.Name = "pic1_picbx";
            this.pic1_picbx.Size = new System.Drawing.Size(145, 129);
            this.pic1_picbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1_picbx.TabIndex = 33;
            this.pic1_picbx.TabStop = false;
            this.pic1_picbx.Click += new System.EventHandler(this.pic1_picbx_Click);
            // 
            // Game_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(761, 393);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.pic_sound);
            this.Controls.Add(this.score_lbl_3);
            this.Controls.Add(this.header_game3);
            this.Controls.Add(this.pic3_picbx);
            this.Controls.Add(this.pic2_picbx);
            this.Controls.Add(this.pic1_picbx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game_3";
            this.Text = "Game - Images and Sounds on Time";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_3_FormClosing);
            this.Load += new System.EventHandler(this.Game_3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_sound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3_picbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2_picbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1_picbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_sound;
        private System.Windows.Forms.Label score_lbl_3;
        private System.Windows.Forms.Label header_game3;
        private System.Windows.Forms.PictureBox pic3_picbx;
        private System.Windows.Forms.PictureBox pic2_picbx;
        private System.Windows.Forms.PictureBox pic1_picbx;
        private System.Windows.Forms.Timer timer_game3;
        private System.Windows.Forms.Label lbl_timer;
    }
}