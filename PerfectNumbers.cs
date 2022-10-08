using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public static class PerfectNumbers
    {
        public static void PrintPerfectNumbers()
        {
            int num;
            int min, max;
            Console.WriteLine("Find the perfect numbers within a given range of numbers");

            Console.Write("Input the starting range of number: ");
            min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the ending range of number: ");
            max = Convert.ToInt32(Console.ReadLine());

            //checking for perfect numbers withing the user specified range
            for (num = min; num < max; num++)
            {
                int i = 1;
                int sum = 0;
                while (i < num)     //for each number in the range, we check the condition for perfect number
                {
                    if ( num % i == 0)
                    {
                        sum += i;
                    }
                    i++;
                }

                if (sum == num)     //if the sum of all perfect divisors of the numeber is equal to the number itself
                {                   //then, it is a perfect number. so we print it.
                    Console.WriteLine(num);
                }
            }

        }
    }
}
