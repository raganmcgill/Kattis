using System;
using System.Collections.Generic;

namespace FreeFood
{
    public class Tester
    {
        // VERY SIMPLE TEST CLASS - EXPLORE SOMETHING LIKE NUNIT OR XUNIT WHEN A BIT MORE FAMILIAR WITH C#
        public void TestCalculator()
        {
            var calculator = new FreeFoodCalculator();

            TestOne(calculator);
            TestTwo(calculator);
            TestThree(calculator);
        }

        private void TestOne(FreeFoodCalculator calculator)
        {
            var periods = new List<string>
            {
                "10 14",
                "13 17",
                "25 26"
            };

            var result = calculator.CalculateTotalDuration(periods);

            if (result == 10)
            {
                Console.WriteLine("Test One PASSED");
            }
            else
            {
                Console.WriteLine($"Test One FAILED - {result}");
            }
        }
        private void TestTwo(FreeFoodCalculator calculator)
        {
            var periods = new List<string>
            {
                "1 365",
                "20 28"
            };

            var result = calculator.CalculateTotalDuration(periods);

            if (result == 365)
            {
                Console.WriteLine("Test Two PASSED");
            }
            else
            {
                Console.WriteLine($"Test Two FAILED - {result}");
            }
        }
        private void TestThree(FreeFoodCalculator calculator)
        {
            var periods = new List<string>
            {
                "29 29",
                "48 48",
                "102 102",
                "94 94"
            };

            var result = calculator.CalculateTotalDuration(periods);
            if (result == 4)
            {
                Console.WriteLine("Test Three PASSED");
            }
            else
            {
                Console.WriteLine($"Test Three FAILED - {result}");
            }
        }
    }
}
