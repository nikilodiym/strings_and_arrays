using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings_and_arrays
{
    internal class task1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write elements of the array separated by space: ");

            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int ev = array.Count(x => x % 2 == 0);
            int od = array.Count(x => x % 2 != 0);
            int ui = array.Distinct().Count();

            Console.WriteLine($"Even numbers: {ev}");
            Console.WriteLine($"Odd numbers: {od}");
            Console.WriteLine($"Unique numbers: {ui}");
        }
    }
}
