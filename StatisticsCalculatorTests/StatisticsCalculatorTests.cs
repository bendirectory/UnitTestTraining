using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticsCalculator;

namespace StatisticsCalculatorTests
{
    [TestClass]
    public class StatisticsCalculatorTests
    {
        [DataTestMethod]
        [DataRow(new[] { 5, 15 }, 10)]
        public void Mean(int[] inputs, double expected)
        {
            var calculator = new StatsCalculator(inputs);
            var actual = calculator.Mean();
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(new[] { 5, 15 }, 10)]
        [DataRow(new[] { 5, 8, 15 }, 8)]
        [DataRow(new[] {8, 5, 15}, 8)]
        public void Median(int[] inputs, double expected)
        {
            var calculator = new StatsCalculator(inputs);
            var actual = calculator.Median();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatorString()
        {
            var inputs = new[] {7, 5, 5, 15};
            var calculator = new StatsCalculator(inputs);
            var expected = "Mean: 8\r\nMedian: 6\r\nMode: 5";
            Assert.AreEqual(expected, calculator.ToString());
        }
    }
}
