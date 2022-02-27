namespace Educational_Program
{
    partial class Educational_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Educational_frm));
            this.auto_btn = new System.Windows.Forms.Button();
            this.letter_pic_combx = new System.Windows.Forms.ComboBox();
            this.lettet_choose_lbl = new System.Windows.Forms.Label();
            this.manual_btn = new System.Windows.Forms.Button();
            this.game_mode_lbl = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // auto_btn
            // 
            this.auto_btn.BackColor = System.Drawing.Color.Gray;
            this.auto_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.auto_btn.Location = new System.Drawing.Point(76, 331);
            this.auto_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.auto_btn.Name = "auto_btn";
            this.auto_btn.Size = new System.Drawing.Size(180, 80);
            this.auto_btn.TabIndex = 0;
            this.auto_btn.Text = "Auto";
            this.auto_btn.UseVisualStyleBackColor = false;
            this.auto_btn.Click += new System.EventHandler(this.auto_btn_Click);
            // 
            // letter_pic_combx
            // 
            this.letter_pic_combx.FormattingEnabled = true;
            this.letter_pic_combx.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.letter_pic_combx.Location = new System.Drawing.Point(224, 126);
            this.letter_pic_combx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.letter_pic_combx.Name = "letter_pic_combx";
            this.letter_pic_combx.Size = new System.Drawing.Size(180, 28);
            this.letter_pic_combx.TabIndex = 2;
            this.letter_pic_combx.SelectedIndexChanged += new System.EventHandler(this.letter_pic_combx_SelectedIndexChanged);
            // 
            // lettet_choose_lbl
            // 
            this.lettet_choose_lbl.AutoSize = true;
            this.lettet_choose_lbl.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lettet_choose_lbl.Font = new System.Drawing.Font("Malgun Gothic", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lettet_choose_lbl.Location = new System.Drawing.Point(153, 32);
            this.lettet_choose_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lettet_choose_lbl.Name = "lettet_choose_lbl";
            this.lettet_choose_lbl.Size = new System.Drawing.Size(324, 54);
            this.lettet_choose_lbl.TabIndex = 3;
            this.lettet_choose_lbl.Text = "Choose a letter:";
            // 
            // manual_btn
            // 
            this.manual_btn.BackColor = System.Drawing.Color.Gray;
            this.manual_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.manual_btn.Location = new System.Drawing.Point(382, 331);
            this.manual_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.manual_btn.Name = "manual_btn";
            this.manual_btn.Size = new System.Drawing.Size(180, 80);
            this.manual_btn.TabIndex = 5;
            this.manual_btn.Text = "Manual";
            this.manual_btn.UseVisualStyleBackColor = false;
            this.manual_btn.Click += new System.EventHandler(this.manual_btn_Click);
            // 
            // game_mode_lbl
            // 
            this.game_mode_lbl.AutoSize = true;
            this.game_mode_lbl.BackColor = System.Drawing.Color.PaleTurquoise;
            this.game_mode_lbl.Font = new System.Drawing.Font("Malgun Gothic", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_mode_lbl.Location = new System.Drawing.Point(100, 238);
            this.game_mode_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.game_mode_lbl.Name = "game_mode_lbl";
            this.game_mode_lbl.Size = new System.Drawing.Size(462, 54);
            this.game_mode_lbl.TabIndex = 6;
            this.game_mode_lbl.Text = "Choose exercise mode:";
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.LightYellow;
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.start_btn.Location = new System.Drawing.Point(162, 462);
            this.start_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(282, 117);
            this.start_btn.TabIndex = 7;
            this.start_btn.Text = "Start Exercise";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // Educational_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(651, 603);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.game_mode_lbl);
            this.Controls.Add(this.manual_btn);
            this.Controls.Add(this.lettet_choose_lbl);
            this.Controls.Add(this.letter_pic_combx);
            this.Controls.Add(this.auto_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Educational_frm";
            this.Text = "Educational";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Educational_frm_FormClosing);
            this.Load += new System.EventHandler(this.Educational_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button auto_btn;
        private System.Windows.Forms.ComboBox letter_pic_combx;
        private System.Windows.Forms.Label lettet_choose_lbl;
        private System.Windows.Forms.Button manual_btn;
        private System.Windows.Forms.Label game_mode_lbl;
        private System.Windows.Forms.Button start_btn;
    }
}