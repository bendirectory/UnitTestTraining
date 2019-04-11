using System;
using System.Collections.Generic;
using System.Linq;

namespace StatisticsCalculator
{
    public class StatsCalculator
    {
        private int[] _inputs;

        public StatsCalculator(params int[] inputs)
        {
            _inputs = inputs;
        }

        public double Mean()
        {
            return Mean(_inputs);
        }

        private double Mean(params int[] inputs)
        {
            var total = 0;
            foreach (var number in inputs)
            {
                total += number;
            }

            return total / inputs.Length;
        }

        public double Median()
        {
            Array.Sort(_inputs);

            var remainder = _inputs.Length % 2;
            var middleIndex = _inputs.Length / 2;
            if (remainder > 0)
            {
                return _inputs[middleIndex];
            }

            var leftOfMiddleItem = _inputs[middleIndex - 1];
            var rightOfMiddleItem = _inputs[middleIndex];
            return Mean(leftOfMiddleItem, rightOfMiddleItem);
        }

        public double? Mode()
        {
            var dictionary = new Dictionary<int, int>();
            foreach (var inputValue in _inputs)
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

        public double StandardDeviation()
        {
            double result;

            result = Variance();
            result = Math.Sqrt(result);

            return result;
        }

        private double Variance()
        {
            double result = 0.0d;
            double mean = Mean(_inputs);

            foreach (double d in _inputs)
            {
                double dif = mean - d;
                dif = Math.Abs(dif);
                dif = Math.Pow(dif, 2);
                result += dif;
            }

            result = result / _inputs.Length;

            return result;
        }
    }
}
