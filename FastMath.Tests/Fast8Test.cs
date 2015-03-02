using System;
using FastMath.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FastMath.Tests
{
    [TestClass]
    public class Fast8Test
    {
        [TestMethod]
        public void Fast8Add()
        {
            var a = (Fast8)0.5;
            var b = (Fast8)0.2;
            Assert.AreEqual(0.7, (double)(a + b), 0.01);
        }

        [TestMethod]
        public void Fast8Sub()
        {
            var a = (Fast8)0.5;
            var b = (Fast8)0.2;
            Assert.AreEqual(0.3, (double)(a - b), 0.01);
        }

        [TestMethod]
        public void Fast8Mul()
        {
            var a = (Fast8)0.5;
            var b = (Fast8)0.2;
            Assert.AreEqual((0.5 * 0.2), (double)(a * b), 0.01);
        }

        [TestMethod]
        public void Fast8Div()
        {
            var a = (Fast8)0.5;
            var b = (Fast8)0.2;
            Assert.AreEqual((0.5 / 0.2), (double)(a / b), 0.15);
        }
    }
}
