using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public static class FibonacciSeries
    {
        public static void PrintSeries()
        {
            Console.Write("Enter a number to print fibonacci series: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int n1 = 0, n2 = 1, n3;

            for (int i = 1; i <= num; i++)
            {
                n3 = n2 + n1;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
