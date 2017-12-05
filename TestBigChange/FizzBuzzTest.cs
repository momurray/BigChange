using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BigChange.General;
using System.Collections.Generic;

namespace TestBigChange
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void Test3and5()
        {
            (bool bResult, List<string> listResults, string Message) = FizzBuzz.Calculate(27);

            Assert.AreEqual(bResult, true);
            Assert.AreEqual(listResults.Count, 27);
            Assert.AreEqual(listResults[2] , "3=Fiz");                // 3
            Assert.AreEqual(listResults[4], "5=Buz");                 // 5
            Assert.AreEqual(listResults[14], "15=Fizzzzz-Buzzz");      // 15 case

        }

        [TestMethod]
        public void Test0and5()
        {
            (bool bResult, List<string> listResults, string Message) = FizzBuzz.Calculate(27,0,5);

            Assert.AreEqual(bResult, false);
            Assert.AreEqual(listResults.Count, 0);
        }

        [TestMethod]
        public void Test5and0()
        {
            (bool bResult, List<string> listResults, string Message) = FizzBuzz.Calculate(27, 5, 0);

            Assert.AreEqual(bResult, false);
            Assert.AreEqual(listResults.Count, 0);
        }

        [TestMethod]
        public void BigNumber()
        {
            int iValue = 100000;
            (bool bResult, List<string> listResults, string Message) = FizzBuzz.Calculate(iValue, 4, 6);

            Assert.AreEqual(bResult, true);
            Assert.AreEqual(listResults.Count, iValue);
        }

        [TestMethod]
        public void CrazyBigNumber()
        {
            int iValue = int.MaxValue;

            (bool bResult, List<string> listResults, string Message) = FizzBuzz.Calculate(iValue, 4, 6);

            // This should have caused an "out of memory" exception.
            Assert.AreEqual(bResult,false);
        }

        [TestMethod]
        public void NegativeNumber()
        {
            (bool bResult, List<string> listResults, string Message) = FizzBuzz.Calculate(-100, 4, 6);

            Assert.AreEqual(bResult, false);
            Assert.AreEqual(listResults.Count, 0);
        }

    }
}
