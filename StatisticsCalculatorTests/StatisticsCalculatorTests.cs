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
        [DataRow(new[] { 8, 15, 5 }, 8)]
        public void Median(int[] inputs, double expected)
        {
            var actual = StatsCalculator.Median(inputs);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(new[] {5, 15}, null)]
        [DataRow(new [] {5, 5, 15}, 5d)]
        [DataRow(new [] {5, 5, 8, 8, 8, 15, 15, 15, 15}, 15d)]
        public void Mode(int[] inputs, double? expected)
        {
            var actual = StatsCalculator.Mode(inputs);
            Assert.AreEqual(expected, actual);
        }
    }
}
