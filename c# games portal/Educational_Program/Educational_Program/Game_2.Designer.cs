namespace Educational_Program
{
    partial class Game_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_2));
            this.score_lbl = new System.Windows.Forms.Label();
            this.match_lbl = new System.Windows.Forms.Label();
            this.score_lbl_2 = new System.Windows.Forms.Label();
            this.header_game2 = new System.Windows.Forms.Label();
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
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.score_lbl.Location = new System.Drawing.Point(-88, -29);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(100, 25);
            this.score_lbl.TabIndex = 27;
            this.score_lbl.Text = "Score: 0";
            // 
            // match_lbl
            // 
            this.match_lbl.AutoSize = true;
            this.match_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.match_lbl.Location = new System.Drawing.Point(111, -46);
            this.match_lbl.Name = "match_lbl";
            this.match_lbl.Size = new System.Drawing.Size(336, 31);
            this.match_lbl.TabIndex = 24;
            this.match_lbl.Text = "Click on the correct picture";
            // 
            // score_lbl_2
            // 
            this.score_lbl_2.AutoSize = true;
            this.score_lbl_2.Font = new System.Drawing.Font("Juice ITC", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lbl_2.ForeColor = System.Drawing.Color.OliveDrab;
            this.score_lbl_2.Location = new System.Drawing.Point(19, 296);
            this.score_lbl_2.Name = "score_lbl_2";
            this.score_lbl_2.Size = new System.Drawing.Size(95, 37);
            this.score_lbl_2.TabIndex = 31;
            this.score_lbl_2.Text = "Score: 0";
            // 
            // header_game2
            // 
            this.header_game2.AutoSize = true;
            this.header_game2.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_game2.ForeColor = System.Drawing.Color.Red;
            this.header_game2.Location = new System.Drawing.Point(9, 6);
            this.header_game2.Name = "header_game2";
            this.header_game2.Size = new System.Drawing.Size(646, 54);
            this.header_game2.TabIndex = 30;
            this.header_game2.Text = "Click the speaker in order to hear a word, and choose the correct word.\r\nYou must" +
    " click the speaker in order to play.";
            // 
            // pic_sound
            // 
            this.pic_sound.BackColor = System.Drawing.Color.Transparent;
            this.pic_sound.Image = global::Educational_Program.Properties.Resources.speaker_png_icon_speaker_circle_icon;
            this.pic_sound.Location = new System.Drawing.Point(305, 284);
            this.pic_sound.Name = "pic_sound";
            this.pic_sound.Size = new System.Drawing.Size(113, 106);
            this.pic_sound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_sound.TabIndex = 32;
            this.pic_sound.TabStop = false;
            this.pic_sound.Click += new System.EventHandler(this.pic_sound_Click);
            // 
            // pic3_picbx
            // 
            this.pic3_picbx.BackColor = System.Drawing.Color.Transparent;
            this.pic3_picbx.Location = new System.Drawing.Point(510, 118);
            this.pic3_picbx.Name = "pic3_picbx";
            this.pic3_picbx.Size = new System.Drawing.Size(145, 131);
            this.pic3_picbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic3_picbx.TabIndex = 29;
            this.pic3_picbx.TabStop = false;
            this.pic3_picbx.Click += new System.EventHandler(this.pic3_picbx_Click_1);
            // 
            // pic2_picbx
            // 
            this.pic2_picbx.BackColor = System.Drawing.Color.Transparent;
            this.pic2_picbx.Location = new System.Drawing.Point(290, 118);
            this.pic2_picbx.Name = "pic2_picbx";
            this.pic2_picbx.Size = new System.Drawing.Size(145, 131);
            this.pic2_picbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2_picbx.TabIndex = 28;
            this.pic2_picbx.TabStop = false;
            this.pic2_picbx.Click += new System.EventHandler(this.pic2_picbx_Click_1);
            // 
            // pic1_picbx
            // 
            this.pic1_picbx.BackColor = System.Drawing.Color.Transparent;
            this.pic1_picbx.Location = new System.Drawing.Point(72, 118);
            this.pic1_picbx.Name = "pic1_picbx";
            this.pic1_picbx.Size = new System.Drawing.Size(145, 129);
            this.pic1_picbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1_picbx.TabIndex = 25;
            this.pic1_picbx.TabStop = false;
            this.pic1_picbx.Click += new System.EventHandler(this.pic1_picbx_Click_1);
            // 
            // Game_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(724, 402);
            this.Controls.Add(this.pic_sound);
            this.Controls.Add(this.score_lbl_2);
            this.Controls.Add(this.header_game2);
            this.Controls.Add(this.pic3_picbx);
            this.Controls.Add(this.pic2_picbx);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.pic1_picbx);
            this.Controls.Add(this.match_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game_2";
            this.Text = "Game - Images and Sounds";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_2_FormClosing);
            this.Load += new System.EventHandler(this.Game_2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pic_sound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3_picbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2_picbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1_picbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic3_picbx;
        private System.Windows.Forms.PictureBox pic2_picbx;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.PictureBox pic1_picbx;
        private System.Windows.Forms.Label match_lbl;
        private System.Windows.Forms.Label score_lbl_2;
        private System.Windows.Forms.Label header_game2;
        private System.Windows.Forms.PictureBox pic_sound;
    }
}