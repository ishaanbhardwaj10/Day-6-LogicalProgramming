﻿namespace LogicalProgramming
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs in C#");
            Console.WriteLine("Program #1: Fibonacci Series");

            Console.Write("Please select a program to run from options above: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    FibonacciSeries.PrintSeries();
                    break;
                default:
                    Console.WriteLine("Please enter a valid number from given options");
                    break;
            }
        }
    }
}