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

namespace Educational_Program
{
    //form allowing the user to choose from 3 options: letters exercise, games menu or adding a word to the system
    public partial class Choosing_Exercise_frm : Form
    {
        public Choosing_Exercise_frm()
        {
            InitializeComponent();
        }

        //what happens when clicking the games menu button
        private void Play_btn_Click(object sender, EventArgs e)
        {
            //opening the games menu forms
            Cursor.Current = Cursors.Hand;
            Games_Menu_frm Games_Menu_frm = new Games_Menu_frm();
            Games_Menu_frm.Show();
            this.Hide();
        }

        //what happens when clicking the letters exercise button
        private void educational_btn_Click(object sender, EventArgs e)
        {
            //opening the letters exercise form
            Cursor.Current = Cursors.Hand;
            Educational_frm Educational_frm = new Educational_frm();
            Educational_frm.Show();
            this.Hide();

        }

        //what happens when clicking the adding a word button
        private void update_btn_Click(object sender, EventArgs e)
        {
            //opens the adding words form
            Cursor.Current = Cursors.Hand;
            Update_frm Update_frm = new Update_frm();
            Update_frm.Show();
            this.Hide();

        }

        private void Play_btn_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void educational_btn_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void update_btn_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        //setting the EXIT button click
        private void exit_btn_Click(object sender, EventArgs e)
        {
            //asking the user if deleting the history
            DialogResult d = MessageBox.Show("Would you like to delete your user history?", "Delete user history", MessageBoxButtons.YesNoCancel);
            if (d == DialogResult.Cancel) { }
            else if (d == DialogResult.No) //just closing the form without deleting
            {
                this.Close();
                System.Windows.Forms.Application.ExitThread();
            }
            else //deleting user hitory
            {
                //delete the user details from the wrong file and the used file
                File.Delete(@".\OUTPUT\" + Program.Players_manager.Player_array[Program.Players_manager.Current_player_num - 1].Name + "_Wrong.txt");
                File.Delete(@".\USED\" + Program.Players_manager.Player_array[Program.Players_manager.Current_player_num - 1].Name + "_Used.txt");
                //deleting the user email
                string[] all_lines = new string[File.ReadAllLines(@".\DATA\usersEmails.txt").Length - 1];
                all_lines = File.ReadAllLines(@".\DATA\usersEmails.txt").Where(line => line.Trim() != Program.Players_manager.Player_array[Program.Players_manager.Current_player_num - 1].Email).ToArray();
                System.IO.File.WriteAllLines(@".\DATA\usersEmails.txt", all_lines);
                MessageBox.Show("User history was successfully deleted.");
                this.Close();
                System.Windows.Forms.Application.ExitThread();
            }
        }
    }
}
