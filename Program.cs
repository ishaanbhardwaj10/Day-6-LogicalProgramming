namespace LogicalProgramming
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs in C#");
            Console.WriteLine("Program #1: Fibonacci Series");
            Console.WriteLine("Program #2: Perfect Numbers");
            Console.WriteLine("Program #3: Prime Numbers");
            Console.WriteLine("Program #4: Reverse A Number");
            Console.WriteLine("Program #5: Coupon Numbers");
            Console.WriteLine("Program #6: Stopwatch Simulator");

            Console.Write("Please select a program to run from options above: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    FibonacciSeries.PrintSeries();
                    break;
                case 2:
                    PerfectNumbers.PrintPerfectNumbers();
                    break;
                case 3:
                    PrimeNumber.CheckPrimeNumbers();
                    break;
                case 4:
                    ReverseNumber.Reverse();
                    break;
                case 5:
                    CouponNumbers.GenerateDistinctCoupon();
                    break;
                case 6:
                    StopwatchSimulator.RunStopwatch();
                    break;
                default:
                    Console.WriteLine("Please enter a valid number from given options");
                    break;
            }
        }
    }
}