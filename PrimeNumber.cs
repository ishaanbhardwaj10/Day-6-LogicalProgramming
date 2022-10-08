using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public static class PrimeNumber
    {
        public static void CheckPrimeNumbers()
        {
            Console.Write("Enter a number to print all prime numbers upto that number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 2)
            {
                Console.Write(2 + " ");

                for (int i = 3; i <= num; i++)
                {
                    bool isPrime = true;
                    int j = 1;
                    while (j <= i / 2)
                    {
                        j++;                //we increment value of j at the start of the loop, so divisiblity
                        if (i % j == 0)     //is checked by values of j >= 2
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else if (num == 2)      //2 is the only even prime number, so we handle that case seperately
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Please enter a number greater than 1");
            }
        }
    }
}
