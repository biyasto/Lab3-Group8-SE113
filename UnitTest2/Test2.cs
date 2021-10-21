﻿using System;
using FunctionX;
using NUnit.Framework;
namespace Test_Validate
{
    [TestFixture]
   public class TestCase
        {
            [TestCase(28, 0, 2000, false)]
            [TestCase(28, 13, 2000, false)]
            [TestCase(0, 4, 2000, false)]

            [TestCase(0, 1, 2000, false)]
            [TestCase(0, 3, 2000, false)]
            [TestCase(0, 5, 2000, false)]
            [TestCase(0, 7, 2000, false)]
            [TestCase(0, 8, 2000, false)]
            [TestCase(0, 10, 2000, false)]
            [TestCase(0, 12, 2000, false)]


            [TestCase(31, 1, 2000, true)]
            [TestCase(31, 3, 2000, true)]
            [TestCase(31, 5, 2000, true)]
            [TestCase(31, 7, 2000, true)]
            [TestCase(31, 8, 2000, true)]
            [TestCase(31, 10, 2000, true)]
            [TestCase(31, 12, 2000, true)]

            [TestCase(30, 6, 2000, true)]
            [TestCase(30, 9, 2000, true)]
            [TestCase(30, 11, 2000, true)]
            [TestCase(30, 4, 2000, true)]

            [TestCase(31, 6, 2000, false)]
            [TestCase(31, 9, 2000, false)]
            [TestCase(31, 11, 2000, false)]
            [TestCase(31, 4, 2000, false)]

            [TestCase(32, 1, 2000, false)]
            [TestCase(32, 3, 2000, false)]
            [TestCase(32, 5, 2000, false)]
            [TestCase(32, 7, 2000, false)]
            [TestCase(32, 8, 2000, false)]
            [TestCase(32, 10, 2000, false)]
            [TestCase(32, 12, 2000, false)]
            

            [TestCase(29, 2, 1900, false)]
            [TestCase(28, 2, 1990, true)]
            [TestCase(29, 2, 1904, true)]
            [TestCase(28, 2, 2000, true)]

            [TestCase(28, 1, 2000, true)]
            [TestCase(28, 2, 2000, true)]
            [TestCase(28, 3, 2000, true)]
            [TestCase(28, 4, 2000, true)]
            [TestCase(28, 5, 2000, true)]
            [TestCase(28, 6, 2000, true)]
            [TestCase(28, 7, 2000, true)]
            [TestCase(28, 8, 2000, true)]
            [TestCase(28, 9, 2000, true)]
            [TestCase(28, 10, 2000, true)]
            [TestCase(28, 11, 2000, true)]
            [TestCase(28, 12, 2000, true)]
        
        public void Test_Validate(int day, int month, int year, bool result)
            {
                var check = new CheckDayClass();
                Assert.AreEqual(result, check.IsValidDate(day,month, year));
            }
        }
    
}
