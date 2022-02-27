namespace Educational_Program
{
    partial class Game_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_4));
            this.lbl_timer = new System.Windows.Forms.Label();
            this.score_lbl_3 = new System.Windows.Forms.Label();
            this.header_game3 = new System.Windows.Forms.Label();
            this.pic3_picbx = new System.Windows.Forms.PictureBox();
            this.pic2_picbx = new System.Windows.Forms.PictureBox();
            this.pic1_picbx = new System.Windows.Forms.PictureBox();
            this.timer_game4 = new System.Windows.Forms.Timer(this.components);
            this.lbl_word_moving = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic3_picbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2_picbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1_picbx)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer.Location = new System.Drawing.Point(627, 415);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(146, 40);
            this.lbl_timer.TabIndex = 46;
            this.lbl_timer.Text = "Timer: ";
            // 
            // score_lbl_3
            // 
            this.score_lbl_3.AutoSize = true;
            this.score_lbl_3.Font = new System.Drawing.Font("Guttman Mantova", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.score_lbl_3.ForeColor = System.Drawing.Color.Purple;
            this.score_lbl_3.Location = new System.Drawing.Point(13, 402);
            this.score_lbl_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.score_lbl_3.Name = "score_lbl_3";
            this.score_lbl_3.Size = new System.Drawing.Size(180, 53);
            this.score_lbl_3.TabIndex = 44;
            this.score_lbl_3.Text = "Score: 0";
            // 
            // header_game3
            // 
            this.header_game3.AutoSize = true;
            this.header_game3.Font = new System.Drawing.Font("Malgun Gothic", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_game3.Location = new System.Drawing.Point(13, 13);
            this.header_game3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.header_game3.Name = "header_game3";
            this.header_game3.Size = new System.Drawing.Size(920, 108);
            this.header_game3.TabIndex = 43;
            this.header_game3.Text = "Click the picture that matches the word below.\r\n\r\n";
            // 
            // pic3_picbx
            // 
            this.pic3_picbx.BackColor = System.Drawing.Color.Transparent;
            this.pic3_picbx.Location = new System.Drawing.Point(620, 126);
            this.pic3_picbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic3_picbx.Name = "pic3_picbx";
            this.pic3_picbx.Size = new System.Drawing.Size(217, 202);
            this.pic3_picbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic3_picbx.TabIndex = 42;
            this.pic3_picbx.TabStop = false;
            this.pic3_picbx.Click += new System.EventHandler(this.pic3_picbx_Click);
            // 
            // pic2_picbx
            // 
            this.pic2_picbx.BackColor = System.Drawing.Color.Transparent;
            this.pic2_picbx.Location = new System.Drawing.Point(362, 126);
            this.pic2_picbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic2_picbx.Name = "pic2_picbx";
            this.pic2_picbx.Size = new System.Drawing.Size(217, 202);
            this.pic2_picbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2_picbx.TabIndex = 41;
            this.pic2_picbx.TabStop = false;
            this.pic2_picbx.Click += new System.EventHandler(this.pic2_picbx_Click);
            // 
            // pic1_picbx
            // 
            this.pic1_picbx.BackColor = System.Drawing.Color.Transparent;
            this.pic1_picbx.Location = new System.Drawing.Point(111, 126);
            this.pic1_picbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic1_picbx.Name = "pic1_picbx";
            this.pic1_picbx.Size = new System.Drawing.Size(217, 199);
            this.pic1_picbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1_picbx.TabIndex = 40;
            this.pic1_picbx.TabStop = false;
            this.pic1_picbx.Click += new System.EventHandler(this.pic1_picbx_Click);
            // 
            // timer_game4
            // 
            this.timer_game4.Interval = 1000;
            this.timer_game4.Tick += new System.EventHandler(this.timer_game4_Tick);
            // 
            // lbl_word_moving
            // 
            this.lbl_word_moving.AutoSize = true;
            this.lbl_word_moving.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_word_moving.Location = new System.Drawing.Point(389, 374);
            this.lbl_word_moving.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_word_moving.Name = "lbl_word_moving";
            this.lbl_word_moving.Size = new System.Drawing.Size(180, 55);
            this.lbl_word_moving.TabIndex = 47;
            this.lbl_word_moving.Text = "WORD";
            // 
            // Game_4
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(943, 464);
            this.Controls.Add(this.lbl_word_moving);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.score_lbl_3);
            this.Controls.Add(this.header_game3);
            this.Controls.Add(this.pic3_picbx);
            this.Controls.Add(this.pic2_picbx);
            this.Controls.Add(this.pic1_picbx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game_4";
            this.Text = "Game - Words and Images on Time";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_4_FormClosing);
            this.Load += new System.EventHandler(this.Game_4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic3_picbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2_picbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1_picbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Label score_lbl_3;
        private System.Windows.Forms.Label header_game3;
        private System.Windows.Forms.PictureBox pic3_picbx;
        private System.Windows.Forms.PictureBox pic2_picbx;
        private System.Windows.Forms.PictureBox pic1_picbx;
        private System.Windows.Forms.Timer timer_game4;
        private System.Windows.Forms.Label lbl_word_moving;
    }
}