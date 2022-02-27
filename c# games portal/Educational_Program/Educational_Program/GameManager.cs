using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Program
{
    //Game manager class - class has parameters and one method only.
    //the parameters are initialized by the program players manager object.
    //class guarantees that the user will keep playing games with mistaken words from previous games,
    //and assuring the player will play with new words at each game, and not previous words that the player 
    //got correct and seen them already in a game before.
    //***in the player class the check_balance method assures that the user will never run out of words,
    //even after playing multiple games and having correct words over and over again.***//

    //using string arrays to keep the correct words of the player, wrong words, 
    //games_images_array keeps different random images to display at games, that are different from the correct images
    //at the game.



    public class GameManager
    {
        public static int score = 0, index = 0, num_words = 9, wrong = 0;
        public static int player_num = Program.Players_manager.Current_player_num;
        public static string player_name = Program.Players_manager.Player_array[player_num - 1].Name;
        public static string image_path = @".\DIMAGES\", image_name, word, sound_path = @".\VOICE\";
        public string[] used_words_array;
        public string[] wrong_words_array;
        public static Player game_player = Program.Players_manager.Player_array[player_num - 1];
        private string[] correct_words_array;
        private string[] game_images_array;

        //properties
        public string[] Correct_words_array { get => correct_words_array; set => correct_words_array = value; }
        public string[] Game_images_array { get => game_images_array; set => game_images_array = value; }

        //method reads from the files the wrong and used words, updating the local arrays, and writing to the files at the end.
        public void Game_start_initialize()
        {
            //checking the balance of the words
            game_player.check_balance();
            //reading the wrong words from the user_wrong file in to the queue
            game_player.Update_wrong_queue();
            //reading the used words from the user_used file in to the stack
            game_player.Update_used_stack();
            Correct_words_array = new string[6];
            wrong_words_array = new string[3];
            used_words_array = new string[3];
            Game_images_array = new string[6];
            int counter = 0; //counting the words in the correct array

            //checking if there are wrong words to add to the array of the correct words that will be displayed in the next game
            for (int i = 0; i < 3; i++)
            {
                if (!(game_player.Wrong_words_player.Count == 0))
                {
                    counter++;
                    Correct_words_array[i] = game_player.Wrong_words_player.Dequeue();
                }
                else
                break;
            }

            //checking if the words already appear in the same array already
            if (counter < 3)
            {
                bool is_in_correct = false;
                Random rnd = new Random();
                int j = rnd.Next(1, Program.Words_manager.Words_array.Length); //j has a random value between the range of the words available
                int i = counter;
                while (i < 3)
                {
                    is_in_correct = false;
                    for (int k = 0; k < 3; k++)
                    {
                        if (Program.Words_manager.Words_array[j].Word_ == Correct_words_array[k]) //if the random word is already in the array
                        {
                            is_in_correct = true;
                            j = rnd.Next(1, Program.Words_manager.Words_array.Length); //change the random value
                            break;
                        }
                    }
                    if (is_in_correct)
                    {
                        break;
                    }
                    if (game_player.Used_words.Contains(Program.Words_manager.Words_array[j].Word_)) //checking if the new word has been used already
                    {
                        j = rnd.Next(1, Program.Words_manager.Words_array.Length);
                    }
                    //checking if the new word has been taken already from the wrong user and has been randomed again
                    else if (game_player.Wrong_words_player.Contains(Program.Words_manager.Words_array[j].Word_)) 
                    {
                        j = rnd.Next(1, Program.Words_manager.Words_array.Length);
                    }
                    else //the word is available
                    {
                        Correct_words_array[i] = Program.Words_manager.Words_array[j].Word_;
                        j = rnd.Next(1, Program.Words_manager.Words_array.Length);
                        i++;
                    }
                }
            }
            //setting the images of the correct words
            game_player.Used_words.Clear(); //empty the stack from game to game
            int dot_idx;
            string image;
            bool is_taken_in_correct = false, is_taken_in_same = false;
            for (int i = 3; i < Correct_words_array.Length; i++) 
            {
                for (int j = 0; j < Program.Words_manager.Words_array.Length; j++) //if the word is equal to the string until . of the image, it is the image of the correct word
                {
                    dot_idx = Program.Words_manager.Words_array[j].Image.IndexOf(@".");
                    image = Program.Words_manager.Words_array[j].Image.Substring(0, dot_idx);
                    if (Correct_words_array[i - 3] == image) //if they are equal
                    {
                        Correct_words_array[i] = Program.Words_manager.Words_array[j].Image; //put the correct matching image to correct array
                    }
                }
            }
            //setting the game_images_array with new random images that will be displayed at the next game
            Random imgrnd = new Random();
            for (int i = 0; i < Game_images_array.Length; i++)//i is for random images array
            {
                while (i < 6)
                {
                    is_taken_in_correct = false;
                    is_taken_in_same = false;
                    //checking if the image that supposed to be in the game_images_array is already in the correct_array
                    int k = imgrnd.Next(0, Program.Words_manager.Words_array.Length);
                    for (int r = 3; r < 6; r++) //run on the places with the correct words index 3-5
                    {
                        //if the image already exists in the correct array, replace the index
                        if (Program.Words_manager.Words_array[k].Image == Correct_words_array[r])
                        {
                            is_taken_in_correct = true;
                            i = i - 1;
                            break; //in order to re-check the word 
                        }
                    }
                    if (is_taken_in_correct)
                    {
                        break;
                    }
                    //checking if the image that supposed to be in the game_images_array is already in the same array

                    int j = 0; //counting checks from index 0 to index temp
                    while (j < i)
                    {
                        if (Program.Words_manager.Words_array[k].Image == Game_images_array[j])
                        {
                            is_taken_in_same = true;
                            break;
                        }
                        j++;
                    }
                    if (is_taken_in_same)
                    {

                        i--;
                        break;
                    }
                    Game_images_array[i] = Program.Words_manager.Words_array[k].Image;
                    i++;
                }
            }
        }
    }
}

