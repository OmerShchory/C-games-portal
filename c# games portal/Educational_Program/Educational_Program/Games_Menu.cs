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
    //form displays the game menu, the user has 4 options for games

    public partial class Games_Menu_frm : Form
    {
        public Games_Menu_frm()
        {
            InitializeComponent();
        }

        //when clicking game 1 opens the game form
        private void Game1_btn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            Game_1 Game_1 = new Game_1();
            Game_1.Show();
            this.Hide();
        }

        //when clicking game 2 opens the game form
        private void Game2_btn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            Game_2 Game_2 = new Game_2();
            Game_2.Show();
            this.Hide();
        }

        //when clicking game 3 opens the game form
        private void Game3_btn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            Game_3 Game_3 = new Game_3();
            Game_3.Show();
            this.Hide();
        }

        //when clicking game 4 opens the game form
        private void Game4_btn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            Game_4 Game_4 = new Game_4();
            Game_4.Show();
            this.Hide();
        }

        //what happens when the form is closing
        private void Games_Menu_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //open the main menu form
            Choosing_Exercise_frm choose = new Choosing_Exercise_frm();
            choose.Show();

        }
    }
}
