using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings_and_arrays
{
    internal class task4
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 5, 6 };
            int[] array2 = { 4, 5, 6, 7, 8, 8 };

            int[] commonElements = array1.Intersect(array2).ToArray();

            Console.WriteLine("Common elements without duplicates:");
            foreach (int num in commonElements)
            {
                Console.Write(num + " ");
            }
        }
    }
}
