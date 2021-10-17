using System;
using System.Collections.Generic;
using System.Linq;

namespace FreeFood
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();

            //Run();
        }

        private static void Run()
        {
            Console.Write("Please enter the number of events this year: ");
            int numberOfEvents = int.Parse(Console.ReadLine());

            var periods = GetPeriods(numberOfEvents);

            var calculator = new FreeFoodCalculator();

            var totalDays = calculator.CalculateTotalDuration(periods);

            Console.WriteLine(totalDays.ToString() + " days this year are taken up by an event!");
        }

        private static void Test()
        {
            var tester = new Tester();
            tester.TestCalculator();
        }

        private static List<String> GetPeriods(int numberOfEvents)
        {
            var periods = new List<String>();

            for (int i = 1; i <= numberOfEvents; i += 1)
            {
                Console.WriteLine("Please enter the start day and the end day of event " + i.ToString() + " seperated by a space: ");

                var period = Console.ReadLine();

                periods.Add(period);
            }

            return periods;
        }
    }
}
