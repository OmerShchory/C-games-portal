using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Educational_Program
{
    //Players manager class - managing and maintaining all the players objects throughout the program.
    //allowing to initialize all the players that are registered in the username_file.txt one time in main program,
    //and allowing access to all the players files, including updates from various classes in the program
    //each update and change refers to the same object and guarantees saving all the changes

    public class PlayersManager
    {
        //size is the number of players
        int size;
        int current_player_num; //the number of the player that is playing the games whike the program is running
        Player[] player_array; //all the players in the game

        //properties
        public int Size { get => size; set => size = value; }
        internal Player[] Player_array { get => player_array; set => player_array = value; }
        public int Current_player_num { get => current_player_num; set => current_player_num = value; }

        //constructor
        public PlayersManager()
        {
            //size in the number of lines in the useremails.txt file
            size = File.ReadAllLines(@".\DATA\usersEmails.txt").Length;
            Player_array = new Player[size];
            for (int i = 0; i < size; i++)
            {
                player_array[i] = new Player(); 
            }
            Current_player_num = -1; //initializing the current_num is the Access form after the user enters the system, at this point it is -1
        }

    }
}
