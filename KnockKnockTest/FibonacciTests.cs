using System;
using KnockKnock;
using KnockKnock.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KnockKnockTest
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void Fibonacci_Lower_Range_Test()
        {
            var results = new RedPill().FibonacciNumber(0);
            Assert.AreEqual(0, results);
        }

        [TestMethod]
        public void Fibonacci_Upper_Range_Test()
        {
            var results = new RedPill().FibonacciNumber(92);
            Assert.AreEqual(7540113804746346429, results);
        }

        [TestMethod]
        [ExpectedException (typeof(ArgumentOutOfRangeException))]
        public void Fibonacci_Exception_Test()
        {
            var results = new RedPill().FibonacciNumber(100);
        }

        [TestMethod]
        public void Fibonacci_PositivieNumber_Test()
        {
            var results = new RedPill().FibonacciNumber(12);
            Assert.AreEqual(144, results);
        }

        [TestMethod]
        public void Fibonacci_Negative_Number_Test()
        {
            var results = new RedPill().FibonacciNumber(-12);
            Assert.AreEqual(-144, results);
            Assert.AreNotEqual(144, results);
        }
    }
}
