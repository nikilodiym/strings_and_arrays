using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings_and_arrays
{
    internal class task3
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };

            Console.WriteLine("Enter three numbers separated by space:");
            string input = Console.ReadLine();
            string[] inputNumbers = input.Split(' ');

            if (inputNumbers.Length != 3 ||
                !int.TryParse(inputNumbers[0], out int num1) ||
                !int.TryParse(inputNumbers[1], out int num2) ||
                !int.TryParse(inputNumbers[2], out int num3))
            {
                Console.WriteLine("Invalid input. Please enter exactly three integers separated by spaces.");
                return;
            }

            int count = CountSequenceOccurrences(array, num1, num2, num3);

            Console.WriteLine($"The sequence ({num1}, {num2}, {num3}) appears {count} times in the array.");
        }

        static int CountSequenceOccurrences(int[] array, int num1, int num2, int num3)
        {
            int count = 0;

            for (int i = 0; i < array.Length - 2; i++)
            {
                if (array[i] == num1 && array[i + 1] == num2 && array[i + 2] == num3)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
