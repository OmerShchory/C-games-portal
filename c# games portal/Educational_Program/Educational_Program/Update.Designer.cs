namespace Educational_Program
{
    partial class Update_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_frm));
            this.word_update_txt = new System.Windows.Forms.TextBox();
            this.header_update_lbl = new System.Windows.Forms.Label();
            this.saveImage = new System.Windows.Forms.SaveFileDialog();
            this.save_image_btn = new System.Windows.Forms.Button();
            this.saveSound = new System.Windows.Forms.SaveFileDialog();
            this.save_sound_btn = new System.Windows.Forms.Button();
            this.check_word_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.availble_lbl = new System.Windows.Forms.Label();
            this.taken_lbl = new System.Windows.Forms.Label();
            this.image_picbx = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.image_picbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // word_update_txt
            // 
            this.word_update_txt.Location = new System.Drawing.Point(302, 71);
            this.word_update_txt.Multiline = true;
            this.word_update_txt.Name = "word_update_txt";
            this.word_update_txt.Size = new System.Drawing.Size(192, 70);
            this.word_update_txt.TabIndex = 0;
            // 
            // header_update_lbl
            // 
            this.header_update_lbl.AutoSize = true;
            this.header_update_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_update_lbl.Location = new System.Drawing.Point(179, 16);
            this.header_update_lbl.Name = "header_update_lbl";
            this.header_update_lbl.Size = new System.Drawing.Size(475, 36);
            this.header_update_lbl.TabIndex = 1;
            this.header_update_lbl.Text = "Please enter the word to update:";
            // 
            // save_image_btn
            // 
            this.save_image_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.save_image_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_image_btn.Location = new System.Drawing.Point(29, 261);
            this.save_image_btn.Name = "save_image_btn";
            this.save_image_btn.Size = new System.Drawing.Size(145, 47);
            this.save_image_btn.TabIndex = 2;
            this.save_image_btn.Text = "Upload Image of object";
            this.save_image_btn.UseVisualStyleBackColor = false;
            this.save_image_btn.Visible = false;
            this.save_image_btn.Click += new System.EventHandler(this.save_image_btn_Click);
            this.save_image_btn.MouseHover += new System.EventHandler(this.save_image_btn_MouseHover);
            // 
            // save_sound_btn
            // 
            this.save_sound_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.save_sound_btn.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_sound_btn.Location = new System.Drawing.Point(617, 118);
            this.save_sound_btn.Name = "save_sound_btn";
            this.save_sound_btn.Size = new System.Drawing.Size(145, 107);
            this.save_sound_btn.TabIndex = 3;
            this.save_sound_btn.Text = "Upload Sound";
            this.save_sound_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.save_sound_btn.UseVisualStyleBackColor = false;
            this.save_sound_btn.Visible = false;
            this.save_sound_btn.Click += new System.EventHandler(this.save_sound_btn_Click);
            this.save_sound_btn.MouseHover += new System.EventHandler(this.save_sound_btn_MouseHover);
            // 
            // check_word_btn
            // 
            this.check_word_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.check_word_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.check_word_btn.Location = new System.Drawing.Point(331, 157);
            this.check_word_btn.Name = "check_word_btn";
            this.check_word_btn.Size = new System.Drawing.Size(132, 31);
            this.check_word_btn.TabIndex = 6;
            this.check_word_btn.Text = "Check word";
            this.check_word_btn.UseVisualStyleBackColor = false;
            this.check_word_btn.Click += new System.EventHandler(this.check_word_btn_Click);
            this.check_word_btn.MouseHover += new System.EventHandler(this.check_word_btn_MouseHover);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.Turquoise;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.save_btn.Location = new System.Drawing.Point(348, 375);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(129, 49);
            this.save_btn.TabIndex = 7;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Visible = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            this.save_btn.MouseHover += new System.EventHandler(this.save_btn_MouseHover);
            // 
            // availble_lbl
            // 
            this.availble_lbl.AutoSize = true;
            this.availble_lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availble_lbl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.availble_lbl.Location = new System.Drawing.Point(271, 216);
            this.availble_lbl.Name = "availble_lbl";
            this.availble_lbl.Size = new System.Drawing.Size(259, 41);
            this.availble_lbl.TabIndex = 9;
            this.availble_lbl.Text = "Word is availble";
            this.availble_lbl.Visible = false;
            // 
            // taken_lbl
            // 
            this.taken_lbl.AutoSize = true;
            this.taken_lbl.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taken_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.taken_lbl.Location = new System.Drawing.Point(191, 296);
            this.taken_lbl.Name = "taken_lbl";
            this.taken_lbl.Size = new System.Drawing.Size(426, 38);
            this.taken_lbl.TabIndex = 10;
            this.taken_lbl.Text = "Word is taken, try again";
            this.taken_lbl.Visible = false;
            // 
            // image_picbx
            // 
            this.image_picbx.BackColor = System.Drawing.Color.Transparent;
            this.image_picbx.Location = new System.Drawing.Point(29, 127);
            this.image_picbx.Name = "image_picbx";
            this.image_picbx.Size = new System.Drawing.Size(153, 110);
            this.image_picbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_picbx.TabIndex = 4;
            this.image_picbx.TabStop = false;
            this.image_picbx.Visible = false;
            // 
            // Update_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.BackgroundImage = global::Educational_Program.Properties.Resources._21056753;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.taken_lbl);
            this.Controls.Add(this.availble_lbl);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.check_word_btn);
            this.Controls.Add(this.image_picbx);
            this.Controls.Add(this.save_sound_btn);
            this.Controls.Add(this.save_image_btn);
            this.Controls.Add(this.header_update_lbl);
            this.Controls.Add(this.word_update_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Update_frm";
            this.Text = "Update";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Update_frm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.image_picbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox word_update_txt;
        private System.Windows.Forms.Label header_update_lbl;
        private System.Windows.Forms.SaveFileDialog saveImage;
        private System.Windows.Forms.Button save_image_btn;
        private System.Windows.Forms.SaveFileDialog saveSound;
        private System.Windows.Forms.Button save_sound_btn;
        private System.Windows.Forms.PictureBox image_picbx;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button check_word_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label availble_lbl;
        private System.Windows.Forms.Label taken_lbl;
    }
}