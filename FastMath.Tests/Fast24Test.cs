using System;
using System.Diagnostics;
using FastMath.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FastMath.Tests
{
    [TestClass]
    public class Fast24Test
    {
        [TestMethod]
        public void Fast24Add()
        {
            var a = (Fast24)0.5;
            var b = (Fast24)0.2;
            Assert.AreEqual(0.7, (double)(a + b), 0.00001);
        }

        [TestMethod]
        public void Fast24Sub()
        {
            var a = (Fast24)0.5;
            var b = (Fast24)0.2;
            Assert.AreEqual(0.3, (double)(a - b), 0.00001);
        }

        [TestMethod]
        public void Fast24Mul()
        {
            var a = (Fast24)0.5;
            var b = (Fast24)0.2;
            Assert.AreEqual((0.5 * 0.2), (double)(a * b), 0.001);
        }

        [TestMethod]
        public void Fast24Div()
        {
            var a = (Fast24)0.5;
            var b = (Fast24)0.2;
            Assert.AreEqual((0.5 / 0.2), (double)(a / b), 0.001);
        }


    }
}
