using System;
using System.Diagnostics;
using FastMath.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FastMath.Tests
{
    [TestClass]
    public class Fast24PerfTest : PerformanceTests
    {
        Fast24[] test = new Fast24[2];

        [TestMethod]
        public void Fast24Add()
        {
            var a = new[] { (Fast24)0.5, (Fast24)0.8 };
            var b = (Fast24)0.2;
            Start();
            for (var i = 0; i < PerformanceIterations; i++)
            {
                test[i & 1] = a[i & 1] + b;
            }
            Stop();
            Console.WriteLine();
            Console.WriteLine((double)test[0] + (double)test[1]);
        }

        [TestMethod]
        public void Fast24Sub()
        {
            var a = (Fast24)0.5;
            var b = (Fast24)0.2;
            Start();
            for (var i = 0; i < PerformanceIterations; i++)
            {
                test[i & 1] = a - b;
            }
            Stop();
            Console.WriteLine((double)test[0] + (double)test[1]);
        }

        [TestMethod]
        public void Fast24Mul()
        {
            var a = (Fast24)0.5;
            var b = (Fast24)0.2;
            Start();
            for (var i = 0; i < PerformanceIterations; i++)
            {
                test[i & 1] = a * b;
            }
            Stop();
            Console.WriteLine((double)test[0] + (double)test[1]);
        }

        [TestMethod]
        public void Fast24Div()
        {
            var a = (Fast24)0.5;
            var b = (Fast24)0.2;
            Start();
            for (var i = 0; i < PerformanceIterations; i++)
            {
                test[i & 1] = a / b;
            }
            Stop();
            Console.WriteLine((double)test[0] + (double)test[1]);
        }
    }
}
