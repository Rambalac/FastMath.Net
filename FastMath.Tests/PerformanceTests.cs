using System;
using System.Diagnostics;
using System.Threading;

namespace FastMath.Tests
{
    public class PerformanceTests
    {
        public const int PerformanceIterations = 100000000;

        private static readonly ManualResetEvent h = new ManualResetEvent(true);
        private Stopwatch watch;
        public void Start()
        {
            h.WaitOne();
            watch = Stopwatch.StartNew();
        }

        public void Stop()
        {
            watch.Stop();
            var sf = new StackTrace().GetFrame(1);
            Console.WriteLine(sf.GetMethod().ReflectedType.Name + "." + sf.GetMethod().Name + ": " + watch.ElapsedMilliseconds + "ms");
            h.Set();
        }
    }
}
