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
    //form access is the main form.
    //allowing the user to register/sign in the system and start playing.
    //recieving the user email

    public partial class access_frm : Form
    {
        public access_frm()
        {
            InitializeComponent();
        }
        
        //what happens when clicking the start button
        private void sendEmail_btn_Click(object sender, EventArgs e)
        {
            var item = new Regex("^[a-zA-Z0-9@.@]+$"); //allowing only letters, numbers and @ . signs
            Cursor.Current = Cursors.Hand;
            if (String.IsNullOrEmpty(UserEmail_txt.Text)) //if the text box is empy
                {
                    MessageBox.Show("Text bar is empty.");
                }
            else if (!item.IsMatch(UserEmail_txt.Text)) //is the email address includes symbols
            {
                MessageBox.Show("Email includes invalid symbols.");
                return;
            }
            if (UserEmail_txt.Text.Contains(" ")) //not allowing space bars
                {
                    MessageBox.Show("Not a valid email address. Spaces are not allowed.");
                return;
                }

            if (UserEmail_txt.Text.Contains("@") && UserEmail_txt.Text.Contains(".")) //checking if the dot is written after @
            {
                int at_idx = UserEmail_txt.Text.IndexOf(@"@");
                int dot_idx = UserEmail_txt.Text.IndexOf(@".");
                if (dot_idx < at_idx)
                {
                    MessageBox.Show("Not a valid email address. A dot required after @.");
                }
                else
                {
                    //save email address to txt and compare to old users
                    StreamReader userEmails_Reader = new StreamReader(@".\DATA\usersEmails.txt");
                    bool count_saved_email = false;
                    int counter = 0; //counting the line of the old user if appears in the file
                    while (!userEmails_Reader.EndOfStream) //read until the file useremail.txt ends
                    {
                        counter++;
                        if (userEmails_Reader.ReadLine() == UserEmail_txt.Text) //if the user already registered
                        {
                            count_saved_email = true;
                            MessageBox.Show("Welcome back! You are already registered.");
                            this.WindowState = FormWindowState.Minimized;
                            Program.Players_manager.Current_player_num = counter; //setting the player current num
                            Program.Games_Manager = new GameManager();
                            Choosing_Exercise_frm Choosing_Exercise_frm = new Choosing_Exercise_frm(); //opening the main nenu
                            Choosing_Exercise_frm.Show();
                            break;
                        }
                    }
                    userEmails_Reader.Close();
                    if (!count_saved_email) //if the use is new
                    {
                        //update the useremails file at the bottom, used file, and username_wrong file
                        StreamWriter userEmails_Writer = new StreamWriter(@".\DATA\usersEmails.txt", true);
                        userEmails_Writer.WriteLine(UserEmail_txt.Text);
                        userEmails_Writer.Close();
                        string username = UserEmail_txt.Text.Substring(0, at_idx);
                        StreamWriter userwrong_writer = new StreamWriter(@".\OUTPUT\" + username + "_Wrong.txt");
                        userwrong_writer.Close();
                        StreamWriter userused_writer = new StreamWriter(@".\USED\" + username + "_Used.txt");
                        userused_writer.Close();
                        MessageBox.Show("Welcome. A new user address has been saved.");

                        this.WindowState = FormWindowState.Minimized;
                        Program.Players_manager.Size++;
                        Player p = new Player(); //initializing a new player object
                        //updating the players array
                        Player[] temp = Program.Players_manager.Player_array; 
                        Array.Resize( ref temp, Program.Players_manager.Player_array.Length + 1);
                        Program.Players_manager.Player_array = temp;
                        //adding the new player to the players array
                        Program.Players_manager.Player_array[Program.Players_manager.Player_array.Length - 1] = p;
                        Program.Players_manager.Current_player_num =  File.ReadAllLines(@".\DATA\usersEmails.txt").Length;
                        Program.Games_Manager = new GameManager();
                        //opening the main menu
                        Choosing_Exercise_frm Choosing_Exercise_frm = new Choosing_Exercise_frm();
                        Choosing_Exercise_frm.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Not a valid email address. A @ and a dot are required.");
            }
        }

        private void sendEmail_btn_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        

    }
}
