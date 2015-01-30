using System;
using KnockKnock;
using KnockKnock.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KnockKnockTest
{
    [TestClass]
    public class ReverseWordsTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ReverseWords_NullExceptionTest()
        {
            var results = new RedPill().ReverseWords(null);
        }
        
        [TestMethod]
        public void ReverseWords_EmptyStringTest()
        {
            var results = new RedPill().ReverseWords("");
            Assert.AreEqual(String.Empty, results, false);
        }

        [TestMethod]
        public void ReverseWords_SingleCharTest()
        {
            var results = new RedPill().ReverseWords("1");
            Assert.AreEqual("1", results, false);
        }

        [TestMethod]
        public void ReverseWords_MultipleCharsTest()
        {
            var results = new RedPill().ReverseWords("123");
            Assert.AreEqual("321", results, false);
        }

        [TestMethod]
        public void ReverseWords_SimpleStringTest()
        {
            var results = new RedPill().ReverseWords("My Sample String");
            Assert.AreEqual("yM elpmaS gnirtS", results, false);
        }

        [TestMethod]
        public void ReverseWords_SingleSpaceInStartTest()
        {
            var results = new RedPill().ReverseWords(" My Sample String");
            Assert.AreEqual(" yM elpmaS gnirtS", results, false);
        }

        [TestMethod]
        public void ReverseWords_SingleSpaceInEndTest()
        {
            var results = new RedPill().ReverseWords("My Sample String ");
            Assert.AreEqual("yM elpmaS gnirtS ", results, false);
        }

        [TestMethod]
        public void ReverseWords_SingleSpaceBothEndsTest()
        {
            var results = new RedPill().ReverseWords(" My Sample String ");
            Assert.AreEqual(" yM elpmaS gnirtS ", results, false);
        }

        [TestMethod]
        public void ReverseWords_DoubleSpacesBothEndsTest()
        {
            var results = new RedPill().ReverseWords("  My Sample String  ");
            Assert.AreEqual("  yM elpmaS gnirtS  ", results, false);
        }

        [TestMethod]
        public void ReverseWords_MultipleSpacesInBetweenTest()
        {
            var results = new RedPill().ReverseWords("My  Sample  String");
            Assert.AreEqual("yM  elpmaS  gnirtS", results, false);
        }
    }
}
