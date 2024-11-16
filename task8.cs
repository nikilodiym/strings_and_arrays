using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace strings_and_arrays
{
    internal class task8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();

            int vowelCount = CountVowels(str);
            Console.WriteLine("Number of vowels: " + vowelCount);
        }

        static int CountVowels(string str)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";

            foreach (char c in str)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
