using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educational_Program
{

    public static class Program
    {
    
        //setting the managers for the program.
        //managers will allow changes and updates of words, wrong words, used words, player's details
        //throughout the while program.
    public static WordsManager Words_manager = new WordsManager();
    public static LettersManager Letters_manager = new LettersManager();
    public static PlayersManager Players_manager = new PlayersManager();
    public static GameManager Games_Manager;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new access_frm());
            
        }

        //method gets a letter and returns the value of it in the english alphabetic order (1-26)
        public static int letter_to_num(string letter)
        {
            letter = letter.ToUpper(); //only upper case letters
            char[] charArr = letter.ToCharArray();
            char letter_ = charArr[0];
            int num = (int)letter_ - 64; //ascii value
            return num;
        }
    }
}
