using System;
using System.Collections.Generic;
using StatisticsCalculator;

namespace StatsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberList = new List<int>();
            foreach (var stringNumber in args)
            {
                numberList.Add(Convert.ToInt32(stringNumber));
            }

            var calculator = new StatsCalculator(numberList.ToArray());

            Console.WriteLine("Mean: " + calculator.Mean());
            Console.WriteLine("Median: " + calculator.Median());
            Console.WriteLine("Mode: " + calculator.Mode());
            Console.WriteLine("Standard Deviation: " + calculator.StandardDeviation());

            Console.ReadLine();
        }
    }
}
