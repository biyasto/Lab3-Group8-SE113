using System;
using FunctionX;
using NUnit.Framework;
namespace Test_Validate
{
    [TestFixture]
   public class TestCase
        {
            [TestCase(20, 10, 1999, true)]
            [TestCase(11, 11, 1, true)]
            [TestCase(31, 12, 1, true)]
            [TestCase(1, 13, 1957, false)]
            [TestCase(29, 2, 2009, false)]
            [TestCase(29, 1, 2000, true)]
            [TestCase(10, 1, 2001, true)]
            [TestCase(18, 8, 2001, true)]
            [TestCase(28, 3, 2001, true)]
            [TestCase(28, 4, 2001, true)]
            [TestCase(28, 5, 2001, true)]
            [TestCase(28, 6, 2001, true)]
            [TestCase(28, 7, 2001, true)]
            [TestCase(-1, 8, 2000, false)]
            [TestCase(28, 9, 3000, true)]
            [TestCase(30, 1, 2000, true)]
            [TestCase(31, 1, 2010, true)]
            [TestCase(30, 2, 1950, false)]
            [TestCase(0, 6, 2021, false)]

            public void Test_Validate(int day, int month, int year, bool result)
            {
                var check = new CheckDayClass();
                Assert.AreEqual(result, check.IsValidDate(day,month, year));
            }
        }
    
}
