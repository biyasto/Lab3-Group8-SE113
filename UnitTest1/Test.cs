using System;
using NUnit.Framework;
using FunctionX;
namespace Test_day_in_month
{
    [TestFixture]
    public class TestCase
    {

        [TestCase(1, 2021, 31)]
        [TestCase(3, 2021, 31)]
        [TestCase(5, 2021, 31)]
        [TestCase(7, 2021, 31)]
        [TestCase(9, 2021, 30)]
        [TestCase(0,2010,0)]
        [TestCase(1,0,0)]
        [TestCase(10, 2021, 31)]
        [TestCase(12, 2021, 31)]
        [TestCase(1, 2000, 31)]
        [TestCase(9, 2000, 30)]
        [TestCase(6, 2000, 30)]
        [TestCase(7, 2000, 31)]
        [TestCase(11, 2000, 30)]
        [TestCase(0, 2000, 0)]
        [TestCase(2, 2000, 29)]
        [TestCase(2, 2004, 29)]
        [TestCase(2, 2100, 28)]
        [TestCase(2, 2009, 28)]

        public void Test_day_in_month(int month, int year, int result)
        {
            var check = new CheckDayClass();
            Assert.AreEqual(result, check.CheckDayinMonth(month, year));
        }
    }
    
}
