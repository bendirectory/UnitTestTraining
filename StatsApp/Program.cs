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

            Console.WriteLine("Mean: " + StatsCalculator.Mean(numberList.ToArray()));
            Console.WriteLine("Median: " + StatsCalculator.Median(numberList.ToArray()));
            Console.WriteLine("Mode: " + StatsCalculator.Mode(numberList.ToArray()));
            Console.WriteLine("Standard Deviation: " + StatsCalculator.StandardDeviation(numberList.ToArray()));

            Console.ReadLine();
        }
    }
}
