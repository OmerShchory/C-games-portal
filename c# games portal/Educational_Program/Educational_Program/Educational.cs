using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educational_Program
{
   //form allowing choosing a letter from the ABC alphabeth to display on screen
   //and allowing the user to choose MANUAL/AUTO mode. Manual mode allows the user to move between the slides,
   //auto mode plays the slides each 5 seconds.


    public partial class Educational_frm : Form
    {
        private static int user_pic = 1;
        private static string letter_pic = "A";
        public static bool is_start_clicked = false;
        public static int User_pic { get => user_pic; set => user_pic = value; }
        public static string Letter_pic { get => letter_pic; set => letter_pic = value; }

        public Educational_frm()
        {
            InitializeComponent();
        }

        //what happens when clicking the start button
        private void start_btn_Click(object sender, EventArgs e)
        {
            is_start_clicked = true;
            if (letter_pic_combx.SelectedIndex == -1) //if there is no letter picked
            {
                MessageBox.Show("Please pick a letter.");
            }
            else
            {
                Letter_pic = letter_pic_combx.Text;
                //open the educational form 
                Educational_Manual_Mode Educational_Manual_Mode = new Educational_Manual_Mode();
                Educational_Manual_Mode.Show();
                //Letter_pic = letter_pic_combx.Text;
                this.Close();
            }
        }

        //what happens when clicking the auto button
        private void auto_btn_Click(object sender, EventArgs e)
        {
            User_pic = 1;
            //setting colors of the buttons
            auto_btn.BackColor = Color.Blue;            manual_btn.BackColor = Color.Gray;
        }

        //what happens when clicking the manual button
        private void manual_btn_Click(object sender, EventArgs e)
        {
            User_pic = 2;
            //setting colors of the buttons
            auto_btn.BackColor = Color.Gray;            manual_btn.BackColor = Color.Blue;
        }

        //setting the user pick of the letter
        private void letter_pic_combx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Letter_pic = letter_pic_combx.Text;
        }

        //when closing the form, open the main menu file
        private void Educational_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!is_start_clicked)
            {
                Choosing_Exercise_frm Choosing_Exercise = new Choosing_Exercise_frm();
                Choosing_Exercise.Show();
            }
        }

        //when loading the form, set the start button click to false
        private void Educational_frm_Load(object sender, EventArgs e)
        {
            is_start_clicked = false;
        }
    }
}
