using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public static class CouponNumbers
    {
        public static void GenerateDistinctCoupon()
        {
            Console.WriteLine("Generate a coupon number containing N distinct single/double digit numbers and find the\ntotal number of random numbers generated in this process.");
            Console.Write("Enter a number less than 100 to generate a distinct coupon number: ");
            int num = Convert.ToInt32(Console.ReadLine());


            if (num > 1 && num < 100)       //to generate a coupon code that contains upto 99 distinct numbers
            {
                Random random = new Random();
                int a = random.Next(0, 100);            //we include only single and double digit numbers-
                                                        //-to be added to coupon code

                
                List<int> couponNums = new List<int>();
                //all random numbers generated and added to the list above if the are not already present in the list
                couponNums.Add(a);
                int countRandomNums = 1;

                for (int i = 0; i < num-1; i++)     // i < num-1; because we already added one distinct number to the list
                {
                    bool isPresent = true;
                    while (isPresent == true)
                    {
                        int b = random.Next(0, 100);
                        countRandomNums++;
                        isPresent = couponNums.Contains(b);
                        if (isPresent == false)                 //if the next randomly generated number is not-
                        {                                       //-present in the list, it gets added and the while loop breaks and-
                            couponNums.Add(b);                  //-we proceed to the next iteration of for loop.
                        }                                       
                    }
                }
                Console.Write("Your coupon number containing " + num + " distinct numbers is: ");

                //printing all the numbers in the list, which composes coupon code
                for (int i = 0; i < couponNums.Count; i++)
                {
                    Console.Write(couponNums[i]);
                    Console.Write(" ");
                }
                Console.WriteLine("");
                Console.WriteLine("Total number of random numbers generated in this process: " + countRandomNums);
            }
            else if(num == 1)           //to generate a coupon code that contains exactly 1 distinct number
            {
                Random random = new Random();
                int a = random.Next(0, 100);

                List<int> couponNums = new List<int>();
                couponNums.Add(a);
                int countRandomNums = 1;

                Console.WriteLine("Your coupon number containing " + num + " distinct numbers is: " + couponNums[0]);
                Console.WriteLine("Total number of random numbers generated in this process: " + countRandomNums);
            }
            else
            {
                Console.WriteLine("Please enter a number greater than zero and less than hundred!");
            }
        }
    }
}
