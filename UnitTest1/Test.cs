using System;
using NUnit.Framework;
using FunctionX;
namespace Test_day_in_month
{
    [TestFixture]
    public class TestCase
    {

    
        //Lab testcase
        [TestCase(0, 2000, 0)]
        [TestCase(13, 2000, 0)]

        [TestCase(1, 2000, 31)]
        [TestCase(3, 2000, 31)]
        [TestCase(4, 2000, 30)]
        [TestCase(5, 2000, 31)]
        [TestCase(6, 2000, 30)]
        [TestCase(7, 2000, 31)]
        [TestCase(8, 2000, 31)]
        [TestCase(9, 2000, 30)]
        [TestCase(10, 2000, 31)]
        [TestCase(11, 2000, 30)]
        [TestCase(12, 2000, 31)]
        
        [TestCase(2, 2000, 29)]
        [TestCase(2, 2009, 28)]
        [TestCase(2, 1900, 28)]
        [TestCase(2, 1904, 29)]
        [TestCase(2, 1903, 28)]
       
        public void Test_day_in_month(int month, int year, int result)
        {
            var check = new CheckDayClass();
            Assert.AreEqual(result, check.CheckDayinMonth(month, year));
        }
    }
    
}
