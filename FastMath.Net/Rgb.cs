using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastMath.Net
{
    public struct Rgb
    {
        public float r;
        public float g;
        public float b;

        public Rgb(float r, float g, float b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public static Rgb Add(Rgb v1, Rgb v2)
        {
            return new Rgb(v1.r + v2.r, v1.g + v2.g, v1.b + v2.b);
        }

        public static void Add(ref Rgb v1, ref Rgb v2, ref Rgb res)
        {
            res.r = v1.r + v2.r;
            res.g = v1.g + v2.g;
            res.b = v1.b + v2.b;
        }
    }
    public struct RgbClass
    {
        public float r;
        public float g;
        public float b;

        public RgbClass(float r, float g, float b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public static RgbClass Add(RgbClass v1, RgbClass v2)
        {
            return new RgbClass(v1.r + v2.r, v1.g + v2.g, v1.b + v2.b);
        }

        public static void Add(RgbClass v1, RgbClass v2, RgbClass res)
        {
            res.r = v1.r + v2.r;
            res.g = v1.g + v2.g;
            res.b = v1.b + v2.b;
        }
    }
}
