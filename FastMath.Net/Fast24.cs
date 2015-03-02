using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FastMath.Net
{
    public struct Fast24
    {
        public const int One = 1 << 24;
        private int _value;

        private Fast24(int v)
        {
            _value = v;
        }

        public static explicit operator int(Fast24 v)
        {
            return v._value >> 24;
        }

        public static explicit operator float(Fast24 v)
        {
            return v._value / (float)One;
        }

        public static explicit operator double(Fast24 v)
        {
            return v._value / (float)One;
        }

        public static explicit operator Fast24(int v)
        {
            return new Fast24(v << 24);
        }

        public static explicit operator Fast24(float v)
        {
            return new Fast24((int)(v * One));
        }

        public static explicit operator Fast24(double v)
        {
            return new Fast24((int)(v * One));
        }

        public static Fast24 operator +(Fast24 a, Fast24 b)
        {
            return new Fast24(a._value + b._value);
        }

        public static Fast24 operator -(Fast24 a, Fast24 b)
        {
            return new Fast24(a._value - b._value);
        }

        public Fast24 Increment(Fast24 a)
        {
            _value += a._value;
            return this;
        }

        public Fast24 Decriment(Fast24 a)
        {
            _value -= a._value;
            return this;
        }

        public static Fast24 operator *(Fast24 a, Fast24 b)
        {
            return new Fast24((a._value >> 12) * (b._value >> 12));
        }

        public static Fast24 operator /(Fast24 a, Fast24 b)
        {
            return new Fast24((a._value / (b._value >> 12)) << 12);
        }
    }
}
