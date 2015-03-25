using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FastMath.Tests
{
    public class PerformanceTests
    {
        public const int PerformanceIterations = 100000000;

        private Stopwatch watch;
        public void Start()
        {
            watch = Stopwatch.StartNew();
        }

        public void Stop()
        {
            watch.Stop();
            var sf = new StackTrace().GetFrame(1);

            Console.WriteLine(sf.GetMethod().Name + ": " + watch.ElapsedMilliseconds + "ms");
        }
    }
}
