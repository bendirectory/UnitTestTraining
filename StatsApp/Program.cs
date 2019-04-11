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
            Console.WriteLine(calculator);

            Console.ReadLine();
        }
    }
}
