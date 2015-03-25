using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FastMath.Tests
{
    public class PerformanceTests
    {
        public const int PerformanceIterations = 100000000;

        private static ManualResetEvent h = new ManualResetEvent(true);
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
