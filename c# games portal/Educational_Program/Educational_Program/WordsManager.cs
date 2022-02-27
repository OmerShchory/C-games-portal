using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Educational_Program
{
    //wordsManager class
    //class is managing and maintaining all the words objects throughout the program.
    //allowing to initialize all the words from the wordImageData.txt file one time in main program,
    //and allowing access to all the words, including updates from various classes in the program
    //each update and change refers to the same object and guarantees saving all the changes

    public class WordsManager
    {
        int real_size; //amount of the words, size of the arrays
        Word[] single_words_array; //arrays of words objects - only nums and numbers
        Word_Total[] words_array; //arrays of word_total objects - all details of the words


        //properties
        public int Real_size { get => real_size; set => real_size = value; }
        internal Word_Total[] Words_array { get => words_array; set => words_array = value; }
        internal Word[] Single_words_array { get => single_words_array; set => single_words_array = value; }

        //constructor
        public WordsManager()
        {
            //reading how many lines are in the file and updating real size
            Real_size = File.ReadAllLines(@".\DATA\wordImageData.txt").Length;
            Words_array = new Word_Total[Real_size];
            Single_words_array = new Word [Real_size];
            //initializing words array and single words array
            for (int i = 0; i < Real_size; i++)
            {
                Words_array[i] = new Word_Total(i + 1);
                Single_words_array[i] = new Word(i + 1);

            }

        }




    }
}
