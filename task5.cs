using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings_and_arrays
{
    internal class task5
    {
        static void Main(string[] args)
        {
            int[,] array =
            {
                    { 3, 5, 7 },
                    { 2, 8, 1 },
                    { 4, 9, 6 }
                };

            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    min = Math.Min(min, array[i, j]);
                    max = Math.Max(max, array[i, j]);
                }
            }

            Console.WriteLine("Minimum value: " + min);
            Console.WriteLine("Maximum value: " + max);
        }
    }
}
