using System;

namespace Common.Utilities
{
    /// <summary>Digest helpers.</summary>
    public static class Digest
    {
        /// <summary>Compute the greatest common divisor of two report sizes.</summary>
        public static long ReportGcd(long a, long b)
        {
            a = a < 0 ? -a : a;
            b = b < 0 ? -b : b;
            while (b != 0)
            {
                long next = a % b;
                a = b;
                b = next;
            }
            return a;
        }

        /// <summary>Wrap a command index into a fixed-size ring.</summary>
        public static int WrapCommandIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }

        /// <summary>Clamp a channel value to a valid range.</summary>
        public static double ClampChannel(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Interpolate between two cache values.</summary>
        public static double LerpCache(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }

        /// <summary>Convert a channel temperature from celsius to fahrenheit.</summary>
        public static double ChannelCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }
    }
}
