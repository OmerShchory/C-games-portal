using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;


namespace Educational_Program
{
    //form is adding a word/words to the system, including images and sounds files


    public partial class Update_frm : Form
    {
        //string is for the name of the image (similar to the word)
        string user_image_ext;
        bool word_available = false, image_saved = false, sound_saved = false;
        //values determine if the inputs from the user are correct (wav format, available word, image format)

        public Update_frm()
        {
            InitializeComponent();
        }

        //setting what occurs when clicking the save button
        private void save_image_btn_Click(object sender, EventArgs e)
        {
            //open the window for the user to upload an image
            Cursor.Current = Cursors.Hand;
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select an Image";
            opFile.Filter = "jpg files (*.jpg)|*.jpg| png files (*.png)| ";
            //saving the image location
            string image_path = @".\DIMAGES\";
            if (opFile.ShowDialog() == DialogResult.OK) //when user clicks OK
            {
                try //try uploading a valid image
                {
                    //setting the name of the image, the ext and the filepath
                    string picName = opFile.SafeFileName;
                    picName = word_update_txt.Text;
                    string filepath = opFile.FileName;
                    string ext = Path.GetExtension(filepath);
                    user_image_ext = ext;
                    if (ext != ".jpg" && ext != ".png") //accept only jpg and png images
                    {
                        MessageBox.Show("Wrong format of image file.");
                    }
                    else
                    {
                        File.Copy(filepath, image_path + picName + ext);
                        image_picbx.Image = new Bitmap(opFile.OpenFile());
                        MessageBox.Show("Image was uploaded successfully.");
                        image_saved = true;
                    }
                }
                catch (Exception exp) //if image is invalid
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }
        }

        //setting what occurs when clicking the save button of the sound
        private void save_sound_btn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            //open the window for the user to upload an image
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select a wav file";
            opFile.Filter = "wav files (*.wav)| ";
            string sound_path = @".\VOICE\"; //saving the location of the sound
            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try //try uploading the sound 
                {
                    string soundName = opFile.SafeFileName;
                    string filepath = opFile.FileName;

                    string ext = Path.GetExtension(filepath);
                    if (ext != ".wav") //accept only wav files
                    {
                        MessageBox.Show("Wrong format of sound file.");
                    }
                    else
                    {
                        soundName = word_update_txt.Text;
                        File.Copy(filepath, sound_path + soundName + ".wav");
                        MessageBox.Show("Sound was uploaded successfully.");
                        sound_saved = true;
                    }
                }
                catch (Exception exp) //if the file is not valid
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }
        }

        //setting what occurs when clicking the check button of the word
        private void check_word_btn_Click(object sender, EventArgs e)
        {
            try //reading word from the user
            {
                save_btn.Visible = true; //only if the sound and image were uploaded
                var item = new Regex("^[a-zA-Z]+$"); //accept only letters
                if (!item.IsMatch(word_update_txt.Text)) //is the words has symbols
                {
                    //showing the correct controls
                    word_available = false;
                    taken_lbl.Visible = false;
                    availble_lbl.Visible = false;
                    image_picbx.Visible = false;
                    save_image_btn.Visible = false;
                    save_sound_btn.Visible = false;
                    save_btn.Visible = false;
                    throw new Exception(); 
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The word contains invalid symbols, or empty");
                return;
            }
            Cursor.Current = Cursors.Hand;
            string word = word_update_txt.Text;
            char[] chars = word.ToCharArray();
          
            if (word_update_txt.Text.Length == 1) //if the user entered only one letter
            {
                //showing the correct controls
                word_update_txt.Text = "";
                word_available = false;
                taken_lbl.Visible = false;
                availble_lbl.Visible = false;
                image_picbx.Visible = false;
                save_image_btn.Visible = false;
                save_sound_btn.Visible = false;
                save_btn.Visible = false;
                MessageBox.Show("You must enter a word with at least 2 letters."); 
            }

            else
            {
                //keeping the first letter of the word
                string first_letter = chars[0].ToString();
                //setting the number of the word
                int letter_num = Program.letter_to_num(first_letter);
                //reading the line of the word from the letters manager
                string[] line_Word = Program.Letters_manager.Letters[letter_num - 1].Words_Array;
                bool word_found = false;
                try
                {
                    for (int i = 0; i < line_Word.Length; i++)
                    {
                        if (line_Word[i].Equals(word)) //if the word is already in the system
                        {
                            //showing the correct controls
                            word_found = true;
                            availble_lbl.Visible = false;
                            taken_lbl.Visible = true;
                            image_picbx.Visible = false;
                            save_image_btn.Visible = false;
                            save_sound_btn.Visible = false;
                            save_btn.Visible = false;
                            throw new Exception();
                        }

                        if (word_found == false)
                        {
                            //showing the correct controls
                            word_available = true;
                            taken_lbl.Visible = false;
                            availble_lbl.Visible = true;
                            image_picbx.Visible = true;
                            save_image_btn.Visible = true;
                            save_sound_btn.Visible = true;
                  
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("The word you chose exists in the system already.");
                }
            }
        }
    

        private void check_word_btn_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void save_sound_btn_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void save_image_btn_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        //when closing reahc the main menu again
        private void Update_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Choosing_Exercise_frm Choosing_Exercise = new Choosing_Exercise_frm();
            Choosing_Exercise.Show();
        }

        //allowing the save button only if the sound, image and word are valid
        private void save_btn_MouseHover(object sender, EventArgs e)
        {
            if (image_saved && sound_saved && word_available)
            {
                save_btn.Enabled = true;
            }
        }

        //what happens when clicking the button save
        private void save_btn_Click(object sender, EventArgs e)
        {
            if (image_saved && sound_saved && word_available) //only if all the uploads and word were valid
            {
                //updating the firstletterdata.txt
                //searching for the first letter of the word in order to access the right line
                //in the firstletterdata file.
                string word = word_update_txt.Text;
                char[] letters = word.ToCharArray();
                string first_letter = letters[0].ToString();
                int letter_num = Program.letter_to_num(first_letter);
                string line_to_change = File.ReadLines(@".\DATA\firstletterData.txt").Skip(letter_num - 1).Take(1).First();
                //adding the word to the file
                string adding = ";" + word + ";" + word + user_image_ext;
                string new_line = line_to_change + adding;

                //reading from the filr of the letters
                StreamReader sr = new StreamReader(@".\DATA\firstletterData.txt");
                string[] lines_array = new string[26];
                lines_array = File.ReadAllLines(@".\DATA\firstletterData.txt");
                lines_array[letter_num - 1] = new_line;
                sr.Close();
                File.WriteAllLines(@".\DATA\firstletterData.txt", lines_array);


                //updating the wordImageData.txt
                int line_to_add = Program.Words_manager.Real_size + 1; 
                string last_letters = null;
                int i = 1;
                for (i = 1; i < letters.Length - 1; i++)
                {
                    last_letters += letters[i].ToString() + ";"; //setting the last letters that will go to the file of words
                }
                last_letters += letters[i].ToString();
                string complete_line = line_to_add.ToString() + ";" + word + ";" + word + user_image_ext +
                 ";" + word + ".wav;" + first_letter.ToUpper() + ";" + letters.Length.ToString() +
                 ";" + last_letters; //setting the complete line to add to the file

                StreamReader sr_ = new StreamReader(@".\DATA\wordImageData.txt");
                string[] words_array = new string[Program.Words_manager.Real_size];
                words_array = File.ReadAllLines(@".\DATA\wordImageData.txt");
                Array.Resize(ref words_array, words_array.Length + 1);
                words_array[words_array.Length - 1] = complete_line;
                sr_.Close();
                File.WriteAllLines(@".\DATA\wordImageData.txt", words_array);

                //updating the word manager
                Program.Words_manager.Real_size++;
                Word_Total[] temp = Program.Words_manager.Words_array;
                Array.Resize(ref temp, temp.Length + 1);
                Program.Words_manager.Words_array = temp;
                Program.Words_manager.Words_array[Program.Words_manager.Real_size - 1] = new Word_Total(line_to_add);

                //updating the letters manager
                Program.Letters_manager.Letters[letter_num - 1].update_from_firstletterData(letter_num);
                DialogResult d = MessageBox.Show("Word and files were successfully uploaded!\nWould you like to add another word", "", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)//if the user wants to add another word
                {
                    //showing the correct controls
                    image_picbx.Image = null;
                    sound_saved = false;
                    image_saved = false;
                    word_available = false;
                    availble_lbl.Visible = false;
                    taken_lbl.Visible = false;
                    image_picbx.Visible = false;
                    save_image_btn.Visible = false;
                    save_sound_btn.Visible = false;
                    save_btn.Visible = false;
                    word_update_txt.Text = "";

                }
                else
                {
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("You must upload picture and sound files."); //if the user tries to save word without files
            }
        }
    }
}
