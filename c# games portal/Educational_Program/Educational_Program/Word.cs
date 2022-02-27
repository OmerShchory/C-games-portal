using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Educational_Program
{
    //class word 
    //has parameters of number of word in the word file txt and a string which is the word itself


    public class Word
    {
        protected int number;
        protected string word_;

        //properties
        public int Number { get => number; set => number = value; }
        public string Word_ { get => word_; set => word_ = value; }

        //constructor gets an int number which is the number of the line of the word in the words file
        public Word(int num)
        {
            Number = num;
            //reads from the file the relevant line
            string line = File.ReadLines(@".\DATA\wordImageData.txt").Skip(num - 1).Take(1).First();
            string[] line_Array = line.Split(';'); //splits the lines to individuals (without ;)
            Word_ = line_Array[1]; //word appears in the second spot in the line in the file
        }
    }
}
