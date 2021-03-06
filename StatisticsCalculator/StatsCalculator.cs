﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace StatisticsCalculator
{
    public class StatsCalculator
    {
        public static double Mean(params int[] inputs)
        {
            var total = 0;
            foreach (var number in inputs)
            {
                total += number;
            }

            return total / inputs.Length;
        }

        public static double Median(params int[] inputs)
        {
            if (inputs.Length % 2 > 0)
            {
                return inputs[inputs.Length / 2];
            }
            else
            {
                return (inputs[(inputs.Length / 2)] + inputs[(inputs.Length / 2)-1])/2;
            }
        }

        public static double? Mode(params int[] inputs)
        {
            var dictionary = new Dictionary<int, int>();
            foreach (var inputValue in inputs)
            {
                if (dictionary.ContainsKey(inputValue))
                {
                    dictionary[inputValue]++;
                }
                else
                {
                    dictionary.Add(inputValue, 1);
                }
            }

            var maxOccurrenceOfAnyValue = dictionary.Values.Max();

            if (dictionary.Values.Count(v => v == maxOccurrenceOfAnyValue) == 1)
            {
                return dictionary.Single(k => k.Value == maxOccurrenceOfAnyValue).Key;
            }

            return null;
        }

        public static double StandardDeviation(int[] val)
        {
            double result;

            result = Variance(val);
            result = Math.Sqrt(result);

            return result;
        }

        private static double Variance(int[] val)
        {
            double result = 0.0d;
            double mean = Mean(val);

            foreach (double d in val)
            {
                double dif = mean - d;
                dif = Math.Abs(dif);
                dif = Math.Pow(dif, 2);
                result += dif;
            }

            result = result / val.Length;

            return result;
        }
    }
}
