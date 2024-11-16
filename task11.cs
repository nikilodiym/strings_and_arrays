using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings_and_arrays
{
    internal class task11
    {
        public static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = random.Next(-100, 101);
                }
            }

            int min = array[0, 0];
            int max = array[0, 0];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }

            int sum = 0;
            bool foundMin = false;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] == min)
                    {
                        foundMin = true;
                    }
                    else if (array[i, j] == max)
                    {
                        foundMin = false;
                    }
                    else if (foundMin)
                    {
                        sum += array[i, j];
                    }
                }
            }

            Console.WriteLine("Sum of elements between min and max: " + sum);
        }
    }
}
