using System;
using System.Linq;
using System.Threading.Tasks;
using FastMath.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FastMath.Tests
{
    [TestClass]
    public class ParallelRgbTest : PerformanceTests
    {
        private const int acount = 1000000;

        [TestMethod]
        public void FloatBy3Test()
        {
            var test = Enumerable.Repeat(new float[3], acount).ToArray();
            var a = Enumerable.Repeat(new[] { 0.1f, 0.2f, 0.3f }, acount).ToArray();
            var b = new[] { 0.7f, 0.8f, 0.9f };
            Start();
            Parallel.For(0, PerformanceIterations, i =>
            {
                var t = test[i % acount];
                var aa = a[i % acount];
                t[0] = aa[0] + b[0];
                t[1] = aa[1] + b[1];
                t[2] = aa[2] + b[2];
            });
            Stop();
            Console.WriteLine(test.Sum(v => v[0] + v[1] + v[2]));
        }

        [TestMethod]
        public void FloatFlatTest()
        {
            var test = new float[acount * 3];
            var a = Enumerable.Repeat(new[] { 0.1f, 0.2f, 0.3f }, acount).SelectMany(v => v).ToArray();
            var b = new[] { 0.7f, 0.8f, 0.9f };
            Start();
            Parallel.For(0, PerformanceIterations, i =>
            {
                var aa = (i % acount) * 3;
                test[aa + 0] = a[aa + 0] + b[0];
                test[aa + 1] = a[aa + 1] + b[1];
                test[aa + 2] = a[aa + 2] + b[2];
            });
            Stop();
            Console.WriteLine(test.Sum());
        }

        [TestMethod]
        public void RgbRefTest()
        {
            var test = new Rgb[acount];
            var a = Enumerable.Repeat(new Rgb(0.1f, 0.2f, 0.3f), acount).ToArray();
            var b = new Rgb(0.7f, 0.8f, 0.9f);
            Start();
            Parallel.For(0, PerformanceIterations, i =>
            {
                Rgb.Add(ref a[i % acount], ref b, ref test[i % acount]);
            });
            Stop();
            Console.WriteLine(test.Sum(v => v.r + v.g + v.b));
        }
        [TestMethod]
        public void RgbCopyTest()
        {
            var test = new Rgb[acount];
            var a = Enumerable.Repeat(new Rgb(0.1f, 0.2f, 0.3f), acount).ToArray();
            var b = new Rgb(0.7f, 0.8f, 0.9f);
            Start();
            Parallel.For(0, PerformanceIterations, i =>
            {
                test[i % acount] = Rgb.Add(a[i % acount], b);
            });
            Stop();
            Console.WriteLine(test.Sum(v => v.r + v.g + v.b));
        }
        [TestMethod]
        public void RgbClassTest()
        {
            var test = Enumerable.Repeat(new RgbClass(0, 0, 0), acount).ToArray();
            var a = Enumerable.Repeat(new RgbClass(0.1f, 0.2f, 0.3f), acount).ToArray();
            var b = new RgbClass(0.7f, 0.8f, 0.9f);
            Start();
            Parallel.For(0, PerformanceIterations, i =>
            {
                RgbClass.Add(a[i % acount], b, test[i % acount]);
            });
            Stop();
            Console.WriteLine(test.Sum(v => v.r + v.g + v.b));
        }
        [TestMethod]
        public void RgbClassCopyTest()
        {
            var test = new RgbClass[acount];
            var a = Enumerable.Repeat(new RgbClass(0.1f, 0.2f, 0.3f), acount).ToArray();
            var b = new RgbClass(0.7f, 0.8f, 0.9f);
            Start();
            Parallel.For(0, PerformanceIterations, i =>
            {
                test[i % acount] = RgbClass.Add(a[i % acount], b);
            });
            Stop();
            Console.WriteLine(test.Sum(v => v.r + v.g + v.b));
        }

    }
}