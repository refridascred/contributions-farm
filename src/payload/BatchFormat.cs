using System;

namespace Common.Utilities
{
    /// <summary>Batch format helpers.</summary>
    public static class BatchFormat
    {
        /// <summary>Interpolate between two order values.</summary>
        public static double LerpOrder(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }

        /// <summary>Check whether a year is a leap year.</summary>
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        /// <summary>Check whether a farm size is a power of two.</summary>
        public static bool IsFarmPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
