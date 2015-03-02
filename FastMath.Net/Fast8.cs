namespace FastMath.Net
{
    public struct Fast8
    {
        public const int Precision = 8;
        private const int halfprec = Precision / 2;
        private int _value;

        private Fast8(int v)
        {
            _value = v;
        }

        public static explicit operator int(Fast8 v)
        {
            return v._value >> Precision;
        }

        public static explicit operator float(Fast8 v)
        {
            return v._value / (float)(1 << Precision);
        }

        public static explicit operator double(Fast8 v)
        {
            return v._value / (float)(1 << Precision);
        }

        public static explicit operator Fast8(int v)
        {
            return new Fast8(v << Precision);
        }

        public static explicit operator Fast8(float v)
        {
            return new Fast8((int)(v * (1 << Precision)));
        }

        public static explicit operator Fast8(double v)
        {
            return new Fast8((int)(v * (1 << Precision)));
        }

        public static Fast8 operator +(Fast8 a, Fast8 b)
        {
            return new Fast8(a._value + b._value);
        }

        public static Fast8 operator -(Fast8 a, Fast8 b)
        {
            return new Fast8(a._value - b._value);
        }

        public Fast8 Increment(Fast8 a)
        {
            _value += a._value;
            return this;
        }

        public Fast8 Decriment(Fast8 a)
        {
            _value -= a._value;
            return this;
        }

        public static Fast8 operator *(Fast8 a, Fast8 b)
        {
            return new Fast8((a._value >> halfprec) * (b._value >> halfprec));
        }

        public static Fast8 operator /(Fast8 a, Fast8 b)
        {
            return new Fast8((a._value / (b._value >> halfprec)) << halfprec);
        }
    }
}