using System;
using System.Linq;
using FastMath.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FastMath.Tests
{
    [TestClass]
    public class RgbTest : PerformanceTests
    {
        private const int acount = 1000000;

        [TestMethod]
        public void FloatTest()
        {
            float[][] test = { new float[3], new float[3] };
            var a = Enumerable.Repeat(new[] { 0.1f, 0.2f, 0.3f }, acount).ToArray();
            var b = new[] { 0.7f, 0.8f, 0.9f };
            Start();
            for (var i = 0; i < PerformanceIterations; i++)
            {
                var t = test[i & 1];
                var aa = a[i & 1];
                t[0] = aa[0] + b[0];
                t[1] = aa[1] + b[1];
                t[2] = aa[2] + b[2];
            }
            Stop();
            Console.WriteLine(test[0][0] + test[0][1] + test[0][2] + test[1][0] + test[1][1] + test[1][2]);
        }

        [TestMethod]
        public void Float2Test()
        {
            var test = new float[6];
            var a = Enumerable.Repeat(new[] { 0.1f, 0.2f, 0.3f }, acount).SelectMany(v => v).ToArray();
            var b = new[] { 0.7f, 0.8f, 0.9f };
            Start();
            for (var i = 0; i < PerformanceIterations; i++)
            {
                var t = i & 1;
                var aa = (i % acount) * 3;
                test[t + 0] = a[aa + 0] + b[0];
                test[t + 1] = a[aa + 1] + b[1];
                test[t + 2] = a[aa + 2] + b[2];
            }
            Stop();
            Console.WriteLine(test[0] + test[1] + test[2] + test[3] + test[4] + test[5]);
        }

        [TestMethod]
        public void RgbRefTest()
        {
            var test = new Rgb[2];
            var a = Enumerable.Repeat(new Rgb(0.1f, 0.2f, 0.3f), acount).ToArray();
            var b = new Rgb(0.7f, 0.8f, 0.9f);
            Start();
            for (var i = 0; i < PerformanceIterations; i++)
            {
                Rgb.Add(ref a[i % acount], ref b, ref test[i & 1]);
            }
            Stop();
            Console.WriteLine(test[0].r + test[0].g + test[0].b + test[1].r + test[1].g + test[1].b);
        }
        [TestMethod]
        public void RgbCopyTest()
        {
            var test = new Rgb[2];
            var a = Enumerable.Repeat(new Rgb(0.1f, 0.2f, 0.3f), acount).ToArray();
            var b = new Rgb(0.7f, 0.8f, 0.9f);
            Start();
            for (var i = 0; i < PerformanceIterations; i++)
            {
                test[i & 1] = Rgb.Add(a[i & 1], b);
            }
            Stop();
            Console.WriteLine(test[0].r + test[0].g + test[0].b + test[1].r + test[1].g + test[1].b);
        }
        [TestMethod]
        public void RgbClassTest()
        {
            var test = new RgbClass[2];
            var a = Enumerable.Repeat(new RgbClass(0.1f, 0.2f, 0.3f), acount).ToArray();
            var b = new RgbClass(0.7f, 0.8f, 0.9f);
            Start();
            for (var i = 0; i < PerformanceIterations; i++)
            {
                RgbClass.Add(a[i % acount], b, test[i & 1]);
            }
            Stop();
            Console.WriteLine(test[0].r + test[0].g + test[0].b + test[1].r + test[1].g + test[1].b);
        }
        [TestMethod]
        public void RgbClassCopyTest()
        {
            var test = new RgbClass[2];
            var a = Enumerable.Repeat(new RgbClass(0.1f, 0.2f, 0.3f), acount).ToArray();
            var b = new RgbClass(0.7f, 0.8f, 0.9f);
            Start();
            for (var i = 0; i < PerformanceIterations; i++)
            {
                test[i & 1] = RgbClass.Add(a[i % acount], b);
            }
            Stop();
            Console.WriteLine(test[0].r + test[0].g + test[0].b + test[1].r + test[1].g + test[1].b);
        }

    }
}