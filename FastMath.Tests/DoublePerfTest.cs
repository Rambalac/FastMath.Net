using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using FastMath.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FastMath.Tests
{
    [TestClass]
    public class DoublePerfTest : PerformanceTests
    {
        double[] test = new double[2];

        [TestMethod]
        public void Fast24Add()
        {
            var a = new[] { 0.5, 0.8 };
            var b = 0.2;
            Start();
            for (var i = 0; i < PerformanceIterations; i++)
            {
                test[i & 1] = a[i & 1] + b;
            }
            Stop();
            Console.WriteLine(test[0] + test[1]);
        }

        [TestMethod]
        public void Fast24Sub()
        {
            var a = 0.5;
            var b = 0.2;
            Start();
            for (var i = 0; i < PerformanceIterations; i++)
            {
                test[i & 1] = a - b;
            }
            Stop();
            Console.WriteLine(test[0] + test[1]);
        }

        [TestMethod]
        public void Fast24Mul()
        {
            var a = 0.5;
            var b = 0.2;
            Start();
            for (var i = 0; i < PerformanceIterations; i++)
            {
                test[i & 1] = a * b;
            }
            Stop();
            Console.WriteLine(test[0] + test[1]);
        }

        [TestMethod]
        public void Fast24Div()
        {
            var a = 0.5;
            var b = 0.2;
            Start();
            for (var i = 0; i < PerformanceIterations; i++)
            {
                test[i & 1] = a / b;
            }
            Stop();
            Console.WriteLine(test[0] + test[1]);
        }
    }
}
