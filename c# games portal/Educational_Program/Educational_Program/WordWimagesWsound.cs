using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Educational_Program
{
    //class WordWimagesWsound - inhereting class word
    //has parameters of number, word, sound and image.



    public class WordWimagesWsound : Word
    {
        protected string sound;
        protected string image;

        //properties
        public string Sound { get => sound; set => sound = value; }
        public string Image { get => image; set => image = value; }

        //constructor
        public WordWimagesWsound(int num): base(num)
        {
            //reads data from the file
            string line = File.ReadLines(@".\DATA\wordImageData.txt").Skip(num - 1).Take(1).First();
            string[] line_Array = line.Split(';'); //splits the line to individual strings
            Sound = line_Array[3]; //sound string in at the 3rd place in the line
            Image = line_Array[2];//image string in at the 2nd place in the line
        }

    }
}
