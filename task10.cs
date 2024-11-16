using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings_and_arrays
{
    internal class task10
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];

            Console.WriteLine("Enter values for array A:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"A[{i}]: ");
                A[i] = int.Parse(Console.ReadLine());
            }

            double[,] B = new double[3, 4];

            Random random = new Random();
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = random.NextDouble();
                }
            }

            Console.WriteLine("Array A:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"{A[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("Array B:");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write($"{B[i, j]} ");
                }
                Console.WriteLine();
            }

            int maxA = A.Max();
            double maxB = B.Cast<double>().Max();

            int minA = A.Min();
            double minB = B.Cast<double>().Min();

            int sumA = A.Sum();
            double sumB = B.Cast<double>().Sum();

            int productA = A.Aggregate((a, b) => a * b);
            double productB = B.Cast<double>().Aggregate((a, b) => a * b);

            int sumEvenA = A.Where(a => a % 2 == 0).Sum();

            double sumOddColumnsB = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (j % 2 != 0)
                {
                    for (int i = 0; i < B.GetLength(0); i++)
                    {
                        sumOddColumnsB += B[i, j];
                    }
                }
            }

            Console.WriteLine($"Maximum element in array A: {maxA}");
            Console.WriteLine($"Maximum element in array B: {maxB}");
            Console.WriteLine($"Minimum element in array A: {minA}");
            Console.WriteLine($"Minimum element in array B: {minB}");
            Console.WriteLine($"Sum of all elements in array A: {sumA}");
            Console.WriteLine($"Sum of all elements in array B: {sumB}");
            Console.WriteLine($"Product of all elements in array A: {productA}");
            Console.WriteLine($"Product of all elements in array B: {productB}");
            Console.WriteLine($"Sum of even elements in array A: {sumEvenA}");
            Console.WriteLine($"Sum of odd columns in array B: {sumOddColumnsB}");
        }
    }
}
