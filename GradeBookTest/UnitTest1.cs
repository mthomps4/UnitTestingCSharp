using System;
using UnitTestingCSharp; 
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GradeBookTest
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeBookStats results = book.ComputeStatistics();
            Assert.AreEqual(90, results.HighestGrade); 
        }

        [TestMethod]
        public void ComputeLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeBookStats results = book.ComputeStatistics();
            Assert.AreEqual(10, results.LowestGrade);
        }

        [TestMethod]
        public void ComputeAverage()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeBookStats results = book.ComputeStatistics();
            Assert.AreEqual(85.16667, results.AverageGrade, 0.01);
        }
    }
}
