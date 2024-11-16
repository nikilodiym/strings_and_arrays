using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings_and_arrays
{
    internal class task9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the input string:");
            string inputString = Console.ReadLine();

            Console.WriteLine("Enter the substring to search:");
            string substring = Console.ReadLine();

            int count = CountSubstringOccurrences(inputString, substring);

            Console.WriteLine("Result: " + count);
        }

        static int CountSubstringOccurrences(string inputString, string substring)
        {
            int count = 0;
            int index = 0;

            while ((index = inputString.IndexOf(substring, index)) != -1)
            {
                count++;
                index += substring.Length;
            }

            return count;
        }
    }
}
