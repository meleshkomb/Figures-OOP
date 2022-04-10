using FigureTask.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FigureTask.Tests
{
    [TestClass]
    class TriangleTests
    {
        //TODO: Add borderline tests

        [TestMethod]
        public void TestCorrectCases()
        {
            Triangle testTriangle = new Triangle(3, 4,5);
            double expect1 = 6;
            double actual1 = Math.Round(testTriangle.GetSquare(), 3);
            Assert.AreEqual(expect1, actual1);

            Assert.IsTrue(testTriangle.IsRectangular);

            testTriangle = new Triangle(7,8,10);
            double expect2 = 27.811;
            double actual2 = Math.Round(testTriangle.GetSquare(), 3);
            Assert.AreEqual(expect2, actual2);

            Assert.IsFalse(testTriangle.IsRectangular);

        }

        [TestMethod]
        public void TestErrorCases()
        {

        }
    }
}
