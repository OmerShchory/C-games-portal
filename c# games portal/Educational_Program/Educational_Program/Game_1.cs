﻿using System;
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
    public partial class Game_1 : Form
    {
        //setting sounds, player name, player number, image and sound location
        public static SoundPlayer correct_sound;
        public static SoundPlayer wrong_sound;
        public static int score = 0, index = 0, num_words = 9, wrong = 0;
        public static int player_num = Program.Players_manager.Current_player_num;
        public static string player_name = Program.Players_manager.Player_array[player_num - 1].Name;
        public static string image_path = @".\DIMAGES\", image_name, word, sound_path = @".\VOICE\";
        public static string[] correct_words_array, wrong_words_array, used_words_array, game_images_array;
        public static Player game_player = Program.Players_manager.Player_array[player_num - 1];
        static int counter1 = 0, counter2 = 0, counter_running = 0; //counting the updates in wrong array and used array

        //setting what happens when form is closing
        private void Game_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //open the main menu
            Choosing_Exercise_frm Choosing_Exercise = new Choosing_Exercise_frm();
            Choosing_Exercise.Show();
        }


        //constructor
        public Game_1()
        {
            InitializeComponent();
            //game manager reads from file the data from last games and choosing the words and images to display at the games
            Program.Games_Manager.Game_start_initialize();
            correct_words_array = new string[6];
            correct_words_array = Program.Games_Manager.Correct_words_array;
            game_images_array = new string[6];
            game_images_array = Program.Games_Manager.Game_images_array;
            wrong_words_array = new string[3];
            used_words_array = new string[3];
            correct_sound = new SoundPlayer(@".\GAMESOUND\correct.wav");
            wrong_sound = new SoundPlayer(@".\GAMESOUND\wrong.wav");
        }

        //when clicking the left picturebox, pick is correct
        private void pic1_picbx_Click(object sender, EventArgs e)
            {
            correct_sound.Play();
            pic1_picbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pic2_picbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pic3_picbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Cursor.Current = Cursors.Hand; //keep the image of the cursor
            index++; //updating the count of the slides - at 3 slides game over
                
            //if we are not at the end
            if (index < 3)
            {
                //keep displaying images, score
                //updating the and used array and updating counters
                pic1_picbx.Image = new Bitmap(image_path + correct_words_array[index + 3]);
                pic2_picbx.Image = new Bitmap(image_path + game_images_array[index]);
                pic3_picbx.Image = new Bitmap(image_path + game_images_array[index + 3]);
                Word_lbl.Text = correct_words_array[index];
                score = score + 100;
                score_lbl.Text = "Score: " + score.ToString();
                used_words_array[counter1] = correct_words_array[counter_running];
                counter1++;
                counter_running++;
            }
            else //we are at the end of the game
            {
                //updating used words, display score
                used_words_array[counter1] = correct_words_array[counter_running];
                counter_running = 0;
                score = score + 100;
                //update used and wrong words
                game_player.Update_used_file(used_words_array);
                game_player.Update_wrong_file(wrong_words_array);
                score_lbl.Text = "Score: " + score.ToString();
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
                //ask the user if they want to play more games or exit
                DialogResult d = MessageBox.Show(score_end + mistakes + "\nWould you like to play more games?", "Game ", MessageBoxButtons.YesNo); 
                if (d == DialogResult.Yes) //go to games menu
                {
                    score = 0;
                    counter1 = 0;
                    counter2 = 0;
                    index = 0;
                    this.Hide();
                    Games_Menu_frm Games_Menu = new Games_Menu_frm();
                    Games_Menu.Show();
                }
                else //go to main menu
                {
                    score = 0;
                    counter1 = 0;
                    counter2 = 0;
                    index = 0;
                    this.Hide();
                    Choosing_Exercise_frm Choosing_Exercise = new Choosing_Exercise_frm();
                    Choosing_Exercise.Show();
                }
            }
        }

        //when clicking the middle picturebox, pick is wrong
        private void pic2_picbx_Click(object sender, EventArgs e)
            {
            //play sound
            wrong_sound.Play();
            Cursor.Current = Cursors.Hand; //keep the image of the cursor
            pic1_picbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pic2_picbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pic3_picbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            index++;

            //keep displaying images, score
            //updating the and used array and updating counters
            if (index < 3)
            {
                pic1_picbx.Image = new Bitmap(image_path + correct_words_array[index + 3]);
                pic2_picbx.Image = new Bitmap(image_path + game_images_array[index]);
                pic3_picbx.Image = new Bitmap(image_path + game_images_array[index + 3]);
                Word_lbl.Text = correct_words_array[index];
                wrong_words_array[counter2] = correct_words_array[counter_running];
                counter_running++;
                wrong++;
                counter2++;
            }
            else //we are at the end of the game
            {
                //update wrong words
                wrong_words_array[counter2] = correct_words_array[counter_running];
                counter_running = 0;
                //update the files 
                game_player.Update_used_file(used_words_array);
                game_player.Update_wrong_file(wrong_words_array);
                score_lbl.Text = "Score: " + score.ToString();
                //displaying the scores, mistakes if there are, and encouragement
                string score_end = "Game end.\n\nYour Score:" + score.ToString();
                string mistakes = null;
                for (int i = 0; i < wrong_words_array.Length; i++)
                {
                    if (wrong_words_array[i] != null)
                    {
                        if(i ==0)
                        {
                        mistakes = "\n\nMistakes:\n";
                        }
                        mistakes += wrong_words_array[i] + "\n";
                    }
                }
                DialogResult d = MessageBox.Show(score_end + mistakes +"\nWould you like to play more games?", "Game ", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes) //ask the user want to play another game open games menu
                {
                    score = 0;
                    counter1 = 0;
                    counter2 = 0;
                    index = 0;
                    this.Hide();
                    Games_Menu_frm Games_Menu = new Games_Menu_frm();
                    Games_Menu.Show();
                }
                else //open main menu
                {
                    score = 0;
                    counter1 = 0;
                    counter2 = 0;
                    index = 0;
                    this.Hide();
                    Choosing_Exercise_frm Choosing_Exercise = new Choosing_Exercise_frm();
                    Choosing_Exercise.Show();
                }
            }

        }
        
        //when clicking the left picturebox, pick is wrong
        private void pic3_picbx_Click(object sender, EventArgs e)
        {
            //play sound
            wrong_sound.Play();
            Cursor.Current = Cursors.Hand; //keep the image of the cursor
            pic1_picbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pic2_picbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pic3_picbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            index++;

            //keep displaying images, score
            //updating the and used array and updating counters
            if (index < 3)
            {
                pic1_picbx.Image = new Bitmap(image_path + correct_words_array[index + 3]);
                pic2_picbx.Image = new Bitmap(image_path + game_images_array[index]);
                pic3_picbx.Image = new Bitmap(image_path + game_images_array[index + 3]);
                Word_lbl.Text = correct_words_array[index];
                wrong_words_array[counter2] = correct_words_array[counter_running];
                counter_running++;
                wrong++;
                counter2++;
            }
            else //we are at the end of the game
            {
                //update files with words from this game
                wrong_words_array[counter2] = correct_words_array[counter_running];
                counter_running = 0;
                game_player.Update_used_file(used_words_array);
                game_player.Update_wrong_file(wrong_words_array);
                score_lbl.Text = "Score: " + score.ToString();
                //displaying the scores, mistakes if there are, and encouragement
                string score_end = "Game end.\n\nYour Score:" + score.ToString();
                string mistakes = null;
                for (int i = 0; i < wrong_words_array.Length; i++)
                {
                    if (wrong_words_array[i] != null)
                    {
                        if (i == 0)
                        {
                            mistakes = "\n\nMistakes:\n";
                        }
                        mistakes += wrong_words_array[i] + "\n";
                    }
                }
              //ask the user if they want to play another game
                DialogResult d = MessageBox.Show(score_end + mistakes + "\nWould you like to play more games?", "Game ", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes) //show games menu 
                {
                    score = 0;
                    counter1 = 0;
                    counter2 = 0;
                    index = 0;
                    this.Hide();
                    Games_Menu_frm Games_Menu = new Games_Menu_frm();
                    Games_Menu.Show();

                }
                else
                {
                    score = 0;
                    counter1 = 0;
                    counter2 = 0;
                    index = 0;
                    this.Hide();
                    Choosing_Exercise_frm Choosing_Exercise = new Choosing_Exercise_frm();
                    Choosing_Exercise.Show();

                }
            }

        }
        //when game loading
            private void Game_1_Load(object sender, EventArgs e)
            {
                counter1 = 0;
                counter2 = 0;
                index = 0;
                pic1_picbx.Image = new Bitmap(image_path + correct_words_array[index + 3]);
                pic2_picbx.Image = new Bitmap(image_path + game_images_array[index]);
                pic3_picbx.Image = new Bitmap(image_path + game_images_array[index + 3]);
                Word_lbl.Text = correct_words_array[index];

            }
        }
    }

