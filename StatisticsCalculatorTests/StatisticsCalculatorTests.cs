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
            var actual = StatsCalculator.Mean(inputs);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(new[] { 5, 15 }, 10)]
        [DataRow(new[] { 5, 8, 15 }, 8)]
        [DataRow(new[] {8, 5, 15}, 8)]
        public void Median(int[] inputs, double expected)
        {
            var actual = StatsCalculator.Median(inputs);
            Assert.AreEqual(expected, actual);
        }
    }
}
