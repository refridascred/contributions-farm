using System;

namespace Common.Utilities
{
    /// <summary>Filter core helpers.</summary>
    public static class FilterCore
    {
        /// <summary>Convert a entry already temperature from celsius to fahrenheit.</summary>
        public static double EntryAlreadyCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Compute the greatest common divisor of two batches sizes.</summary>
        public static long BatchesGcd(long a, long b)
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

        /// <summary>Clamp a catalog value to a valid range.</summary>
        public static double ClampCatalog(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }
    }
}
