using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings_and_arrays
{
    internal class task2
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 5, 7, 9, 11, 13 };

            Console.WriteLine("Enter a number:");
            int threshold = ReadIntegerInput();

            int count = CountNumbersLessThanThreshold(numbers, threshold);

            Console.WriteLine($"Number of elements less than {threshold}: {count}");
        }

        static int ReadIntegerInput()
        {
            int threshold;
            while (!int.TryParse(Console.ReadLine(), out threshold))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer:");
            }
            return threshold;
        }

        static int CountNumbersLessThanThreshold(int[] numbers, int threshold)
        {
            int count = 0;
            foreach (int num in numbers)
            {
                if (num < threshold)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
