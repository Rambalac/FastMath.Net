using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FastMath.Tests
{
    [TestClass]
    public class FloatPerfTest : PerformanceTests
    {
        readonly float[] test = new float[2];

        [TestMethod]
        public void Fast24Add()
        {
            var a = new[] { 0.5f, 0.8f };
            const float b = 0.2f;
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
            var a = 0.5f;
            var b = 0.2f;
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
            var a = 0.5f;
            var b = 0.2f;
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
            var a = 0.5f;
            var b = 0.2f;
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
