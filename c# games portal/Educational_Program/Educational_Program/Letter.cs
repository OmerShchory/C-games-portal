using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Educational_Program
{
    //class of letter - contains parameters, constructor, and methods 
    //contains parameters of number of letter from 1-26 (English letters), letter string, words array 
    //with all the words that start with the this letter, and all the images of those words. 
    //Array size is the length og these arrays.


    public class Letter : IComparable 
    {
        int number;
        int array_size;
        string letter;
        string[] words_Array;
        string[] images_Array;
  
        //properties
        public int Number { get => number; set => number = value; }
        public int Array_size { get => array_size; set => array_size = value; }
        public string Letter_p { get => letter; set => letter = value; }
        public string[] Images_Array { get => images_Array; set => images_Array = value; }
        public string[] Words_Array { get => words_Array; set => words_Array = value; }

        //constructor gets an int number and initializes all the fields for this letter
        public Letter(int letter_num)
        {
            Number = letter_num;
            //reads data from file firstletter.txt
            string line = File.ReadLines(@".\DATA\firstletterData.txt").Skip(letter_num - 1).Take(1).First();
            //split the one string to several strings, splits the line from the file to individuals
            string[] line_array = line.Split(';');
            Letter_p = line_array[1]; //letter itself appears on the second spot in the line (array)
            //array size is the number of the words in one line. 3 first spots aren't words. every two spots is a word and an image.
            Array_size = (line_array.Length - 3) / 2; 
            words_Array = new string[Array_size];
            Images_Array = new string[Array_size];

            //initialize the words and images arrays, skipping the first 3 spots
            for (int i = 0, j = 0; j < Array_size; j++, i = i + 2)
            {
                Words_Array[j] = line_array[i + 3];
                Images_Array[j] = line_array[i + 4];
            }
        }

        //method gets an int number which is the line to read from the firstletterData.txt file, 
        //and updates the words array and images array
        public void update_from_firstletterData(int line_update)
        {
            Array_size++; //increasing the size
            string line = File.ReadLines(@".\DATA\firstletterData.txt").Skip(line_update - 1).Take(1).First(); //read the specific line from the file
            string[] line_array = line.Split(';'); //splits the line to individuals words
            //resizing the words array and images array
            String[] temp_ = Words_Array;
            Array.Resize(ref temp_, Array_size);
            Words_Array = temp_;
            String[] temp = Images_Array;
            Array.Resize(ref temp, Array_size);
            Images_Array = temp;
            //puts the words from the file (line array) in to the words and images arrays
            Words_Array[Array_size - 1] = line_array[line_array.Length - 2];
            Images_Array[Array_size - 1] = line_array[line_array.Length - 1];
        }

        //methods implements the Icomparable interface
        public int CompareTo(object obj)        {            if (!(obj is Letter))//throw exception if not Letter object
            {                throw new Exception("Object is not an Letter, cannot compare!"); 
            }            if (obj == null) //throw exception if object is null
            {                throw new ArgumentNullException("Object is null, cannot compare!"); 
            }            else            {            Letter item = (Letter)obj;                //compare number of words of each letter                if (item.array_size == this.array_size)
                    return 0;
                else if (item.array_size < this.array_size)
                    return -1;
                else return 1;
                      }        }

        //method gets a letter object and sort words array and images array.
        //methods gets a letter object and sorting the words array and images array, shortest
        //word to longest.
        //sorting in order to present the user shortest word to longest in the program
        public static void sort_two_arrays(Letter l)
        {
            //sorting the words array - by insertion sort method
            int len = l.Words_Array.Length; //length of the total array
            for (int i = 1; i < len; ++i)
            {
                string key = l.Words_Array[i];
                int j = i - 1;
                while (j >= 0 && l.Words_Array[j].Length > key.Length) //comparing the current place backwards until reaching index 0
                {
                    l.Words_Array[j + 1] = l.Words_Array[j];
                    j = j - 1;
                }
                l.Words_Array[j + 1] = key;
            }

            //sorting the images_array
            string[] assist_array = new string[l.array_size];
            string word_temp, image_temp = null;
            //running all the strings images in the array and comparing and sorting the array by the length of the string
            for(int i = 0 ; i < l.array_size; i++) 
            {
                word_temp = l.Words_Array[i]; 
                for (int j = 0; j < l.array_size; j++)
                {
                    image_temp = l.images_Array[j];
                    image_temp = image_temp.Substring(0,image_temp.Length - 4);
                    if (image_temp == word_temp) 
                    {
                        assist_array[i] = l.images_Array[j];
                    }
                }
            }
            l.images_Array = assist_array;
        }
    }
}
