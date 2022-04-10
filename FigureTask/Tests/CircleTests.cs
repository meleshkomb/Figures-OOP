using System;
using FigureTask.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureTask.Tests
{
    [TestClass]
    class CircleTests
    {
        //TODO: Add borderline tests

        [TestMethod]
        public void TestCorrectCases()
        {
            Circle testCircle = new Circle(10);
            double expect1 = 314.159;
            double actual1 = Math.Round(testCircle.GetSquare(), 3);
            Assert.AreEqual(expect1, actual1);

            testCircle = new Circle(12.3);
            double expect2 = 475.292;
            double actual2 = Math.Round(testCircle.GetSquare(), 3);
            Assert.AreEqual(expect2, actual2);
        }

        [TestMethod]
        public void TestErrorCases()
        {
            try
            {
                Circle testCircle = new Circle(-5);
            }
            catch (Exception ex)
            {
                var expect = "must be greater than zero";
                var actual = ex.Message;
                Assert.IsTrue(actual.Contains(expect));
            }
        }
    }
}
