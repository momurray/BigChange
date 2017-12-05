using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BigChange.General;

namespace TestBigChange
{
    [TestClass]
    public class DuplicateCharsTest
    {

        [TestMethod]
        public void NormalString()
        {
            string str = "aaaabbbbccd".RemoveConsecutiveChars(2);
            Assert.AreEqual("aabbccd", str);
        }

        [TestMethod]
        public void InvalidNrChars()
        {
            // Should do nothing. 
            string str = "aabbccddd".RemoveConsecutiveChars(0);
            Assert.AreEqual("aabbccddd", str);
        }

        [TestMethod]
        public void NoRepeatedChars()
        {
            // Should do nothing. 
            string str = "abcde".RemoveConsecutiveChars(2);
            Assert.AreEqual("abcde", str);
        }

        [TestMethod]
        public void DifferentNrChars()
        {
            // Should do nothing. 
            string str = "aaaaaaabbbbbbcccccddddeee".RemoveConsecutiveChars(5);
            Assert.AreEqual("aaaaabbbbbcccccddddeee", str);
        }

    }
}
