using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Program
{
    //Letter manager class - managing and maintaining all the letters objects throughout the program.
    //allowing to initialize all 26 letters in English from the letter class one time in main program,
    //and allowing access to all the letters, including updates from various classes in the program
    //each update and change refers to the same object and guarantees saving all the changes


    public class LettersManager
    {
        private static Letter[] letters; //arrays of letter objects
        int array_size; //letters array size

        //properties
        public Letter[] Letters { get => letters; set => letters = value; }
        public int Array_size { get => array_size; set => array_size = value; }

        //constructor 
        public LettersManager()
        {
            array_size = 26; //26 letters in English
            letters = new Letter[Array_size];
            for (int i = 0; i < Array_size; i++) //initializing all the letters, by the constructor of the letter
            {
                Letter l = new Letter(i + 1);
                Letters[i] = l;
            }
        }
    }
}
