using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings_and_arrays
{
    internal class task6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            int wordCount = CountWords(sentence);
            Console.WriteLine("Number of words: " + wordCount);
        }

        static int CountWords(string sentence)
        {
            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}
