using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public static class ReverseNumber
    {
        public static void Reverse()
        {
            Console.Write("Enter a number to find it's reverse: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int a, reverseNum = 0;
            while (num != 0)
            {
                a = num % 10;                           //extracting the digit at once place
                reverseNum = (reverseNum * 10) + a;     //adding that digit to reverseNum
                num = num / 10;                         //chopping off the last digit, so we can proceed for the next iteration
            }

            Console.WriteLine("Reversed number is: " + reverseNum);
        }
    }
}
