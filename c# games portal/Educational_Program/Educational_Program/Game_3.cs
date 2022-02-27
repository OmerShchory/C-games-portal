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
    public partial class Game_3 : Form
    {
        public static bool is_msg_yes = false;
        SoundPlayer speaker;
        public static int score = 0, index = 0, num_words = 9, wrong = 0, time = 10;
        public static int player_num = Program.Players_manager.Current_player_num;
        public static string player_name = Program.Players_manager.Player_array[player_num - 1].Name;
        public static string image_path = @".\DIMAGES\", image_name, word, sound_path = @".\VOICE\";
        public static string[] correct_words_array, wrong_words_array, used_words_array, game_images_array;
        public static Player game_player = Program.Players_manager.Player_array[player_num - 1];
        static int counter1 = 0, counter2 = 0, counter_running = 0;
        static bool is_1_clicked = false, is_2_clicked = false, is_3_clicked = false;

        private void Game_3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!is_msg_yes)
            {
                Choosing_Exercise_frm Choosing_Exercise = new Choosing_Exercise_frm();
                Choosing_Exercise.Show();
            }
        }

        //constructor
        public Game_3()
        {
            speaker = new SoundPlayer();
            InitializeComponent();
            //game manager reads from file the data from last games and choosing the words and images to display at the games
            Program.Games_Manager.Game_start_initialize();
            correct_words_array = new string[6];
            correct_words_array = Program.Games_Manager.Correct_words_array;
            game_images_array = new string[6];
            game_images_array = Program.Games_Manager.Game_images_array;
            wrong_words_array = new string[3];
            used_words_array = new string[3];

        }


        private void Game_3_Load(object sender, EventArgs e)
        {
            is_msg_yes = false;
            is_1_clicked = false;
            is_2_clicked = false;
            is_3_clicked = false;
            counter1 = 0;
            counter2 = 0;
            index = 0;
            time = 10;
            timer_game3.Start();
            speaker.SoundLocation = (sound_path + correct_words_array[index] + ".wav");
            speaker.Play();
            pic1_picbx.Image = new Bitmap(image_path + correct_words_array[index + 3]);
            pic2_picbx.Image = new Bitmap(image_path + game_images_array[index]);
            pic3_picbx.Image = new Bitmap(image_path + game_images_array[index + 3]);
            score_lbl_3.Text = "Score: " + score.ToString();
        }

        //when clicking the sound pic, updating the value
        private void pic_sound_Click_1(object sender, EventArgs e)
        {
            speaker.SoundLocation = (sound_path + correct_words_array[index] + ".wav");
            speaker.Play();
        }


        //when clicking the left picturebox, pick is correct
        private void pic1_picbx_Click(object sender, EventArgs e)
        {

            is_1_clicked = true;
            pic1_picbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pic2_picbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pic3_picbx.BorderStyle = System.Windows.Forms.BorderStyle.None;

            Cursor.Current = Cursors.Hand; //keep the image of the cursor
            index++;


        //if we are not at the end
        if (index < 3)
            {
            //keep displaying images, score
            //updating the and used array and updating counters
            time = time + 5;
                lbl_timer.Text = "Timer: " + time.ToString();
                timer_game3.Start();
                pic1_picbx.Image = new Bitmap(image_path + correct_words_array[index + 3]);
                pic2_picbx.Image = new Bitmap(image_path + game_images_array[index]);
                pic3_picbx.Image = new Bitmap(image_path + game_images_array[index + 3]);

                score = score + 100;
                score_lbl_3.Text = "Score: " + score.ToString();
                used_words_array[counter1] = correct_words_array[counter_running];
                counter1++;
                counter_running++;
            }
            else
            {
                //updating used words, display score
                timer_game3.Stop();
                used_words_array[counter1] = correct_words_array[counter_running];
                counter_running = 0;
                score = score + 100;
                game_player.Update_used_file(used_words_array);
                game_player.Update_wrong_file(wrong_words_array);
                score_lbl_3.Text = "Score: " + score.ToString();
                //displaying the scores, mistakes if there are, and encouragement
                string score_end = "Game end.\n\nYour Score:" + score.ToString();
                string mistakes = null;
                bool are_mistakes = false;
                for (int i = 0; i < wrong_words_array.Length; i++)
                {
                    if (wrong_words_array[i] != null)
                    {
                        if (i == 0)
                        {
                            mistakes = "\nMistakes:\n";
                        }
                        are_mistakes = true;
                        mistakes += wrong_words_array[i] + "\n";
                    }
                }
                if (!are_mistakes)
                {
                    mistakes = "\n\nNo mistakes! You are great!\n";
                }
                //asking the user if they want to play another game
                DialogResult d = MessageBox.Show(score_end + mistakes + "\nWould you like to play more games?", "Game ", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes) //go to games menu
                    {
                    is_msg_yes = true;
                    score = 0;
                    counter1 = 0;
                    counter2 = 0;
                    index = 0;
                    this.Close();
                    Games_Menu_frm Games_Menu = new Games_Menu_frm();
                    Games_Menu.Show();
                }
                else //go to main menu
                {
                    score = 0;
                    counter1 = 0;
                    counter2 = 0;
                    index = 0;
                    this.Close();
                }
            }
        }

        //when clicking the middle picturebox, pick is wrong
        private void pic2_picbx_Click(object sender, EventArgs e)
        {

            is_2_clicked = true;

            timer_game3.Start();
            if (time > 2)
                time = time - 2;
            else
            {
                pic1_picbx.Image = new Bitmap(image_path + correct_words_array[index + 3]);
                pic2_picbx.Image = new Bitmap(image_path + game_images_array[index]);
                pic3_picbx.Image = new Bitmap(image_path + game_images_array[index + 3]);
                speaker.SoundLocation = (sound_path + correct_words_array[index] + ".wav");
                speaker.Play();
            }
            lbl_timer.Text = "Timer: " + time.ToString();
            Cursor.Current = Cursors.Hand; //keep the image of the cursor
            pic1_picbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pic2_picbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pic3_picbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            index++;


            if (index < 3)
            {
                //keep displaying images, score
                //updating the and used array and updating counters
                pic1_picbx.Image = new Bitmap(image_path + correct_words_array[index + 3]);
                pic2_picbx.Image = new Bitmap(image_path + game_images_array[index]);
                pic3_picbx.Image = new Bitmap(image_path + game_images_array[index + 3]);
                score_lbl_3.Text = "Score: " + score.ToString();
                wrong_words_array[counter2] = correct_words_array[counter_running];
                counter_running++;
                wrong++;
                counter2++;
            }
            else
            {
                //update wrong words
                timer_game3.Stop();
                wrong_words_array[counter2] = correct_words_array[counter_running];
                counter_running = 0;
                game_player.Update_used_file(used_words_array);
                game_player.Update_wrong_file(wrong_words_array);
                score_lbl_3.Text = "Score: " + score.ToString();
                DialogResult d = MessageBox.Show("Game end. Your Score: " + score.ToString() + "\nWould you like to play more games?", "Game ", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)  //go to games menu if the use want to play more games
                {
                    is_msg_yes = true;
                    score = 0;
                    counter1 = 0;
                    counter2 = 0;
                    index = 0;
                    this.Close();
                    Games_Menu_frm Games_Menu = new Games_Menu_frm();
                    Games_Menu.Show();
                }
                else //go to main menu 
                {
                    score = 0;
                    counter1 = 0;
                    counter2 = 0;
                    index = 0;
                    this.Close();
                    //Choosing_Exercise_frm Choosing_Exercise = new Choosing_Exercise_frm();
                    //Choosing_Exercise.Show();
                }
            }
        }

        //when clicking the left picturebox, pick is wrong
        private void pic3_picbx_Click(object sender, EventArgs e)
        {
            is_3_clicked = true;

            timer_game3.Start();
            if (time > 2)
                time = time - 2;
            else
            {
                pic1_picbx.Image = new Bitmap(image_path + correct_words_array[index + 3]);
                pic2_picbx.Image = new Bitmap(image_path + game_images_array[index]);
                pic3_picbx.Image = new Bitmap(image_path + game_images_array[index + 3]);
                speaker.SoundLocation = (sound_path + correct_words_array[index] + ".wav");
                speaker.Play();
            }
            lbl_timer.Text = "Timer: " + time.ToString();
            Cursor.Current = Cursors.Hand; //keep the image of the cursor
            pic1_picbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pic2_picbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pic3_picbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            index++;

            if (index < 3)
            {
                //keep displaying images, score
                //updating the and used array and updating counters
                pic1_picbx.Image = new Bitmap(image_path + correct_words_array[index + 3]);
                pic2_picbx.Image = new Bitmap(image_path + game_images_array[index]);
                pic3_picbx.Image = new Bitmap(image_path + game_images_array[index + 3]);
                score_lbl_3.Text = "Score: " + score.ToString();
                wrong_words_array[counter2] = correct_words_array[counter_running];
                counter_running++;
                wrong++;
                counter2++;
            }
            else//we are at the end of the game
            {
                //update files with words from this game
                timer_game3.Stop();
                wrong_words_array[counter2] = correct_words_array[counter_running];
                counter_running = 0;
                game_player.Update_used_file(used_words_array);
                game_player.Update_wrong_file(wrong_words_array);
                score_lbl_3.Text = "Score: " + score.ToString();
                //ask the user if they want to play another game
                DialogResult d = MessageBox.Show("Game end. Your Score: " + score.ToString() + "\nWould you like to play more games?", "Game ", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)  //go to games menu
                {
                    is_msg_yes = true;
                    score = 0;
                    counter1 = 0;
                    counter2 = 0;
                    index = 0;
                    this.Close();
                    Games_Menu_frm Games_Menu = new Games_Menu_frm();
                    Games_Menu.Show();

                }
                else //go to main menu
                {
                    score = 0;
                    counter1 = 0;
                    counter2 = 0;
                    index = 0;
                    this.Close();
                    //Choosing_Exercise_frm Choosing_Exercise = new Choosing_Exercise_frm();
                    //Choosing_Exercise.Show();
                }
            }
        }

        private void timer_game3_Tick(object sender, EventArgs e)
        {
            //if there is time left
            if (time >= 0)
            {
                lbl_timer.Text = "Timer: " + time;
                time = time - 1;
            }
            else //if there is no time left
            {
                //go to the next slide
                if (!(is_1_clicked) && !(is_2_clicked) && !(is_3_clicked))
                {
                    wrong_words_array[counter2] = correct_words_array[counter_running];
                }
                timer_game3.Stop();
                time = 10;
                lbl_timer.Text = "Timer: " + time.ToString();
                index++;

                
                if (index < 3)
                {
                    speaker.SoundLocation = (sound_path + correct_words_array[index] + ".wav");
                    speaker.Play();
                    pic1_picbx.Image = new Bitmap(image_path + correct_words_array[index + 3]);
                    pic2_picbx.Image = new Bitmap(image_path + game_images_array[index]);
                    pic3_picbx.Image = new Bitmap(image_path + game_images_array[index + 3]);
                    timer_game3.Start();
                }
                else //end game if we are at the end and timer stops
                {
                    is_msg_yes = false;
                    timer_game3.Stop();
                }
            }
        }
    }
}


