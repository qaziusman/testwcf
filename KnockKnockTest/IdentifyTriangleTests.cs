using System;
using KnockKnock;
using KnockKnock.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KnockKnockTest
{
    [TestClass]
    public class IdentifyTriangleTests
    {
        [TestMethod]
        public void IdentifyTriangle_ErrorTest()
        {
            var result = new RedPill().WhatShapeIsThis(10, 10, 20);
            Assert.AreEqual(TriangleType.Error, result);
        }

        [TestMethod]
        public void IdentifyTriangle_ScaleneTest()
        {
            var result = new RedPill().WhatShapeIsThis(10, 12, 20);
            Assert.AreEqual(TriangleType.Scalene, result);
        }

        [TestMethod]
        public void IdentifyTriangle_IsocelesTest()
        {
            var result = new RedPill().WhatShapeIsThis(10, 10, 15);
            Assert.AreEqual(TriangleType.Isosceles, result);
        }

        [TestMethod]
        public void IdentifyTriangle_EquilateralTest()
        {
            var result = new RedPill().WhatShapeIsThis(10, 10, 10);
            Assert.AreEqual(TriangleType.Equilateral, result);
        }
    }
}
