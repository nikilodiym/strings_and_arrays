using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings_and_arrays
{
    internal class task14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an arithmetic expression:");
            string expression = Console.ReadLine();

            int result = CalculateExpression(expression);
            Console.WriteLine("Result: " + result);
        }

        private static int CalculateExpression(string expression)
        {
            int result = 0;
            int sign = 1;

            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];

                if (c == '+')
                {
                    sign = 1;
                }
                else if (c == '-')
                {
                    sign = -1;
                }
                else
                {
                    int number = int.Parse(c.ToString());
                    result += sign * number;
                }
            }

            return result;
        }
    }
}
