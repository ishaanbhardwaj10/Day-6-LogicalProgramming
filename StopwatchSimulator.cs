using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LogicalProgramming
{
    public static class StopwatchSimulator
    {
        public static void RunStopwatch()
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.Write("Type START and press enter to start the stopwatch: ");
            string startCommand = Console.ReadLine();

            if (startCommand == "START")
            {
                stopwatch.Start();

                Console.Write("Type STOP and press enter to stop the stopwatch: ");
                string stopCommand = Console.ReadLine();

                if (stopCommand == "STOP")
                {
                    stopwatch.Stop();
                    Console.WriteLine("Time Elapsed : {0}", stopwatch.Elapsed);
                }
                else
                {
                    Console.Write("Please enter STOP in all caps and press enter: ");
                    string newCommand = Console.ReadLine();

                    while (newCommand != "STOP")
                    {
                        Console.Write("Please enter STOP in all caps and press enter: ");
                        newCommand = Console.ReadLine();
                    }
                    Console.WriteLine("Time Elapsed : {0}", stopwatch.Elapsed);
                }
            }
            else
            {
                Console.WriteLine("Please enter commands correctly! (START in all upper case)");
            }
        }
    }
}
