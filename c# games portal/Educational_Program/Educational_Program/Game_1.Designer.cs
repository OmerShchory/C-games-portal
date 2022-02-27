namespace Educational_Program
{
    partial class Game_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_1));
            this.score_lbl = new System.Windows.Forms.Label();
            this.Word_lbl = new System.Windows.Forms.Label();
            this.match_lbl = new System.Windows.Forms.Label();
            this.pic1_picbx = new System.Windows.Forms.PictureBox();
            this.pic2_picbx = new System.Windows.Forms.PictureBox();
            this.pic3_picbx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1_picbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2_picbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3_picbx)).BeginInit();
            this.SuspendLayout();
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.BackColor = System.Drawing.Color.MistyRose;
            this.score_lbl.Font = new System.Drawing.Font("Microsoft Yi Baiti", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lbl.ForeColor = System.Drawing.Color.Navy;
            this.score_lbl.Location = new System.Drawing.Point(35, 71);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(113, 30);
            this.score_lbl.TabIndex = 19;
            this.score_lbl.Text = "Score: 0";
            // 
            // Word_lbl
            // 
            this.Word_lbl.AutoSize = true;
            this.Word_lbl.Font = new System.Drawing.Font("David", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.Word_lbl.Location = new System.Drawing.Point(237, 341);
            this.Word_lbl.Name = "Word_lbl";
            this.Word_lbl.Size = new System.Drawing.Size(316, 72);
            this.Word_lbl.TabIndex = 18;
            this.Word_lbl.Text = "The Word";
            // 
            // match_lbl
            // 
            this.match_lbl.AutoSize = true;
            this.match_lbl.Font = new System.Drawing.Font("MingLiU-ExtB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.match_lbl.Location = new System.Drawing.Point(41, 17);
            this.match_lbl.Name = "match_lbl";
            this.match_lbl.Size = new System.Drawing.Size(746, 32);
            this.match_lbl.TabIndex = 16;
            this.match_lbl.Text = "Click on the picture that matches the word.";
            // 
            // pic1_picbx
            // 
            this.pic1_picbx.BackColor = System.Drawing.Color.Transparent;
            this.pic1_picbx.Location = new System.Drawing.Point(75, 143);
            this.pic1_picbx.Name = "pic1_picbx";
            this.pic1_picbx.Size = new System.Drawing.Size(182, 161);
            this.pic1_picbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1_picbx.TabIndex = 17;
            this.pic1_picbx.TabStop = false;
            this.pic1_picbx.Click += new System.EventHandler(this.pic1_picbx_Click);
            // 
            // pic2_picbx
            // 
            this.pic2_picbx.BackColor = System.Drawing.Color.Transparent;
            this.pic2_picbx.Location = new System.Drawing.Point(309, 145);
            this.pic2_picbx.Name = "pic2_picbx";
            this.pic2_picbx.Size = new System.Drawing.Size(182, 161);
            this.pic2_picbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2_picbx.TabIndex = 22;
            this.pic2_picbx.TabStop = false;
            this.pic2_picbx.Click += new System.EventHandler(this.pic2_picbx_Click);
            // 
            // pic3_picbx
            // 
            this.pic3_picbx.BackColor = System.Drawing.Color.Transparent;
            this.pic3_picbx.Location = new System.Drawing.Point(563, 145);
            this.pic3_picbx.Name = "pic3_picbx";
            this.pic3_picbx.Size = new System.Drawing.Size(182, 161);
            this.pic3_picbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic3_picbx.TabIndex = 23;
            this.pic3_picbx.TabStop = false;
            this.pic3_picbx.Click += new System.EventHandler(this.pic3_picbx_Click);
            // 
            // Game_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pic3_picbx);
            this.Controls.Add(this.pic2_picbx);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.Word_lbl);
            this.Controls.Add(this.pic1_picbx);
            this.Controls.Add(this.match_lbl);
            this.ForeColor = System.Drawing.Color.ForestGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game_1";
            this.Text = "Game - Words and Images";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_1_FormClosing);
            this.Load += new System.EventHandler(this.Game_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1_picbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2_picbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3_picbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.Label Word_lbl;
        private System.Windows.Forms.PictureBox pic1_picbx;
        private System.Windows.Forms.Label match_lbl;
        private System.Windows.Forms.PictureBox pic2_picbx;
        private System.Windows.Forms.PictureBox pic3_picbx;
    }
}