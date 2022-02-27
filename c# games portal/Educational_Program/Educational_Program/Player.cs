using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Educational_Program
{

    //class player
    //class allows reading files and writing to files for each individual player throughout the program.
    
    
    public class Player
    {
        //counter - counting the numbers for the players. Each one has a different number.
        static int counter = 1;
        int num;
        string email; //player email
        string name; //player name
        //stack of the words that have been used in games for this player, 
        //and have been chose correctly by the user
        static Stack<string> used_words;
        //queue of the wrong words for this player, words that the player got wrong during games
        static Queue<string> wrong_words_player;
        

        //properties
        public string Email { get => email; set => email = value; }
        public Stack<string> Used_words { get => used_words; set => used_words = value; }
        public int Num { get => num; set => num = value; }
        public string Name { get => name; set => name = value; }
        public Queue<string> Wrong_words_player { get => wrong_words_player; set => wrong_words_player = value; }

        //constructor
        public Player()
        {
            Num = counter;
            //reaading the file useremails in order to read the name and the email
            string mail = File.ReadLines(@".\DATA\usersEmails.txt").Skip(Num - 1).Take(1).First();
            Used_words = new Stack<string>();
            Wrong_words_player = new Queue<string>();
            int at_idx = mail.IndexOf(@"@");
            Name = mail.Substring(0, at_idx);
            Email = mail;
            counter++; //counting players
        }

        //method gets an array of strings of the wrong words in the game, and updates the file username_wrong.txt 
        //with the wrong relevant words
        public void Update_wrong_file(string[] game_wrong)
        {
            int temp = 0;
            for (int i = 0; i < game_wrong.Length; i++) //game_wrong array is always set to 3 places
            {
                if (game_wrong[i] != null) //if there are mistakes of words appearing in the array
                {
                    wrong_words_player.Enqueue(game_wrong[i]); //add the wrong words to the queue
                }
            }
            temp = Wrong_words_player.Count; //keeping the amount of the wrong words
            //updating the file username_wrong.txt
            StreamWriter sw_ = new StreamWriter(@".\OUTPUT\" + Name + "_Wrong.txt"); 
            for (int i = 0; i < temp; i++)
            {
                sw_.WriteLine(Wrong_words_player.Dequeue()); //emptying the queue and moving the wrong words to the file
            }
            sw_.Close();

        }

        //method updating the wrong_queue of the player from the file
        public void Update_wrong_queue()
        {
            //reading the file
            StreamReader sr_ = new StreamReader(@".\OUTPUT\" + Name + "_Wrong.txt");
            //len is the number of wrong words in the file
            int len = File.ReadAllLines(@".\OUTPUT\" + Name + "_Wrong.txt").Length;
            for (int i = 0; i < len; i++)
            {
                Wrong_words_player.Enqueue(sr_.ReadLine()); //updating the queue from the file
            }
            sr_.Close();
        }
        
        //method updates the used words stack from the file used
        public void Update_used_stack()
        {
            //rading the file
            StreamReader sr_ = new StreamReader(@".\USED\" + Name + "_Used.txt");
            //keeping the number of used words in len
            int len = File.ReadAllLines(@".\USED\" + Name + "_Used.txt").Length;
            for (int i = 0; i < len; i++)
            {
                Used_words.Push(sr_.ReadLine()); //pushing the words from the file to the stack
            }
            sr_.Close();
        }

        //method updates the file used.txt of this player. gets the used words array from the game
        public void Update_used_file(string[] used)
        {
            int temp = 0;
            for (int i = 0; i < used.Length; i++) //used string array can have 3 used words only - 3 words in each game
            {
                if(used[i] != null)//if there are used words 
                Used_words.Push(used[i]);//push the words in to the stack
            }
            temp = Used_words.Count; //keeping the amount of used words
            //writing to the file
            StreamWriter sw_user = new StreamWriter(@".\USED\" + Name + "_Used.txt", true);
            for (int i = 0; i < temp; i++)
            {
                sw_user.WriteLine(Used_words.Pop()); //poping all the used words from the stack to the file
            }
        sw_user.Close();
        }

        //method keeps the balance of the amount of words in the words array versus the words in the used array
        //so that when the data runs out, the code will still run
        public void check_balance()
        {
            //a player can play multipule games and fill their used file.
            //in order to guarantee the continuation of the game, when there are 30 words available in the words manager
            //the words manager will reset, and the used words will reset to 0.
            //thus allowing the game to have 30 pictures.
            int num_words_used = File.ReadAllLines(@".\USED\" + Name + "_Used.txt").Length;
            int interval = Program.Words_manager.Words_array.Length - num_words_used;
            if (interval < 30)
            {
                System.IO.File.WriteAllText(@".\USED\" + Name + "_Used.txt", string.Empty);
            }
        }


    }
}
