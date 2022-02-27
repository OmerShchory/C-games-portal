using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Educational_Program
{
    //form displays slides of the letters and the words that start with this letter.
    //form allows manual mode and auto mode.
    //user has the option to move right and left throughout the display in the manual mode.

    public partial class Educational_Manual_Mode : Form
    {
        //initialzing the sounds of the words
        SoundPlayer sp = new SoundPlayer();
        public int letter_pic = Program.letter_to_num(Educational_frm.Letter_pic); //variable holds the user pick of the letter
        Letter Letter_ = Program.Letters_manager.Letters[Program.letter_to_num(Educational_frm.Letter_pic) - 1];

        //index holds the number of the slide 
        public static int index = 0;
        //keeping the images and sounds location
        public string image_path = @".\DIMAGES\";
        public string image_name;
        public string sound_path = @".\VOICE\";
        //varible holds the user pick of the mode 
        public int mode = Educational_frm.User_pic;
        //initializing the timer seconds
        public static int time_left = 5;

        public Educational_Manual_Mode()
        {
            InitializeComponent();
        }

        //what happens when clicking the right button click
        private void Right_btn_Click(object sender, EventArgs e)
        {
            //if the slide is in the range of 0 t o the last
            if (index >= 0 && index < Letter_.Images_Array.Length)
            {
                //update the image, sound and the word
                pic_display.Image = new Bitmap(image_path + Letter_.Images_Array[index]);
                Word_lbl.Text = Letter_.Words_Array[index];
                sp.SoundLocation = sound_path + Letter_.Words_Array[index] + ".wav";
                sp.Play();
                index++; //updating the index of the slide
            }
            else if (index == Letter_.Images_Array.Length) //if reaching the end of the slides
            {
                //ask the user if they want to have the images displayes again
                DialogResult d = MessageBox.Show("You reached the end!\n Would you like to start again?", "", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes) //reset the index, and display it all again
                {
                    letter_pic = Program.letter_to_num(Educational_frm.Letter_pic);
                    index = 0;
                    pic_display.Image = new Bitmap(image_path + Letter_.Letter_p + ".png");
                    Word_lbl.Text = Letter_.Letter_p;
                    sp.SoundLocation = sound_path + Letter_.Letter_p + ".wav";
                    sp.Play();

                }
                else
                {
                    letter_pic = Program.letter_to_num(Educational_frm.Letter_pic);
                    index = 0; //reset to 0
                    this.Close();
                }
            }
        }


        //what happens when clicking the right button click
        private void Left_btn_Click(object sender, EventArgs e)
        {
            //if the slide is in the range of 0 t o the last
            if (index >= 0 && index <= Letter_.Images_Array.Length)
            {
                if (index == 1) //if there is no more left to the slides
                {
                    //keep showing the same slide which is the first
                    pic_display.Image = new Bitmap(image_path + Letter_.Letter_p + ".png");
                    Word_lbl.Text = Letter_.Letter_p;
                    sp.SoundLocation = sound_path + Letter_.Letter_p + ".wav";
                    sp.Play();
                    index = 0;
                }
                else if (!(index == 0)) //if there is a slide to the left
                {
                    //update word, sound and image
                    pic_display.Image = new Bitmap(image_path + Letter_.Images_Array[index - 2]);
                    Word_lbl.Text = Letter_.Words_Array[index - 2];
                    sp.SoundLocation = sound_path + Letter_.Words_Array[index - 2] + ".wav";
                    sp.Play();
                    index--; //update index
                }
                else
                {
                    index = 0;
                }
            }
            else
            {
                index = 0;
            }
        }
        
        //setting what happens when the form is loading 
        private void Educational_Manual_Mode_Load(object sender, EventArgs e)
        {
            //setting the choose of the letter of the user 
            letter_pic = Program.letter_to_num(Educational_frm.Letter_pic);
            //applying the method that sorts the word and images array from shortest word to longest
            Letter.sort_two_arrays(Letter_);
            //update word, image, sound
            pic_display.Image = new Bitmap(image_path + Letter_.Letter_p + ".png");
            Word_lbl.Text = Letter_.Letter_p;
            sp.SoundLocation = sound_path + Letter_.Letter_p + ".wav";
            sp.Play();

            if (mode == 1) //if mode is auto
            {
                //show the correct controls
                stop_btn.Visible = true;
                timer_tmr.Start();
                time_left_lbl.Visible = true;
                Left_btn.Visible = false;
                Right_btn.Visible = false;

            }
            else //if mode is manual
            {
                //show the correct controls
                stop_btn.Visible = false;
                timer_tmr.Stop();
                time_left_lbl.Visible = false;
                Left_btn.Visible = true;
                Right_btn.Visible = true;
            }
        }

        //setting the timer 
        private void timer_tmr_Tick(object sender, EventArgs e)
        {
            //if there is time left 
            if (time_left >= 0)
            {
                //dislay time and update seconds 
                time_left_lbl.Text = "Timer: " + time_left;
                time_left = time_left - 1;
            }
            else //if there is no time left
            {
                timer_tmr.Stop();
                if (index >= 0 && index < Letter_.Images_Array.Length) //if the range is between 0 to last slide
                {
                    //resetting the time
                    time_left = 5;
                    timer_tmr.Start();
                    //resetting the image, word, sound
                    pic_display.Image = new Bitmap(image_path + Letter_.Images_Array[index]);
                    Word_lbl.Text = Letter_.Words_Array[index];
                    sp.SoundLocation = sound_path + Letter_.Words_Array[index] + ".wav";
                    sp.Play();
                    index++; //keep the counting of the slides

                }
                else if (index == Letter_.Images_Array.Length) //if the slide is the last
                {
                    //ask user if they want to see the slides again
                    DialogResult d = MessageBox.Show("You reached the end!\n Would you like to start again?", "", MessageBoxButtons.YesNo);
                    if (d == DialogResult.Yes)
                    {
                        //reset time and index
                        time_left = 5;
                        timer_tmr.Start();
                        index = 0;
                        //display the image, sound and word
                        pic_display.Image = new Bitmap(image_path + Letter_.Letter_p + ".png");
                        Word_lbl.Text = Letter_.Letter_p;
                        sp.SoundLocation = sound_path + Letter_.Letter_p + ".wav";
                        sp.Play();
                    }
                    else //stop the display of the slides
                    {
                        timer_tmr.Stop();
                        index = 0;
                        this.Close();
                    }
                }
            }
        }

        //what happens when clicking the stop button at auto mode
        private void stop_btn_Click(object sender, EventArgs e)
        {
            timer_tmr.Stop(); //stop the time
            DialogResult d = MessageBox.Show("Would you like to exit?", "Stop Exercise", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes) //exit the letters exercise and reset index
            {
                index = 0;
                this.Close();
            }
            else
            {
                timer_tmr.Start(); //continue if the user doesn't want to exit
            }
        }

        //what happens when closing the form
        private void Educational_Manual_Mode_FormClosing(object sender, FormClosingEventArgs e)
        {
            //open the main menu again
            Choosing_Exercise_frm Choosing_Exercise = new Choosing_Exercise_frm();
            Choosing_Exercise.Show();
        }
    }
}



