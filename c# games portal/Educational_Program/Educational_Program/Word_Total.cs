using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Educational_Program
{
    //class word_Total
    //inhereting class WordWimagesWsound
    //contains all the details of the word: number, word, image, sound, first letter, last letters and length

    public class Word_Total : WordWimagesWsound , IComparable
    {
        string first_letter;
        string[] last_letters;
        int length;

        //properties
        public string First_letter { get => first_letter; set => first_letter = value; }
        public string[] Last_letters { get => last_letters; set => last_letters = value; }
        public int Length { get => length; set => length = value; }

        //constructor gets an int number
        public Word_Total(int num) : base (num)
        {
            //read data from the file from the relevant line
            string line = File.ReadLines(@".\DATA\wordImageData.txt").Skip(num - 1).Take(1).First();
            string[] line_Array = line.Split(';'); //splits the line to individual words
            First_letter = line_Array[4]; //spot nunmber 4 in the line is the first letter
            Length = int.Parse(line_Array[5]);//spot nunmber 5 in the line is the length
            Last_letters = new string [Length - 1];
            for (int i = 0; i < Length - 1; i++)
            {
                last_letters[i] = line_Array[6 + i]; //last spots in the line are the last letters
            }

        }

// לבדוק עדכון נתונים

        public int CompareTo(object obj)        {            if (!(obj is Word_Total))//throw exception if not appsystem object
            {                throw new Exception("Object is not an Word_Total, cannot compare!"); //adding try catch in main
            }            if (obj == null) //if object is null
            {                throw new ArgumentNullException("Object is null, cannot compare!"); //adding try catch in main
            }            else            {                Word_Total item = (Word_Total)obj;                if (item.Length == this.Length)                    return 0;                else if (item.Length < this.Length)                    return -1;                else return 1;            }        }

        
    }
}
