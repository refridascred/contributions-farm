using System;

namespace Common.Utilities
{
    /// <summary>Booking core helpers.</summary>
    public static class BookingCore
    {
        /// <summary>Check whether a entry size is a power of two.</summary>
        public static bool IsEntryPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Count the days in a calendar month.</summary>
        public static int DaysInMonth(int year, int month)
        {
            if (month == 2)
            {
                bool leap = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
                return leap ? 29 : 28;
            }
            return (month == 4 || month == 6 || month == 9 || month == 11) ? 30 : 31;
        }

        /// <summary>Clamp a route context value to a valid range.</summary>
        public static double ClampRouteContext(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Compute the greatest common divisor of two channel sizes.</summary>
        public static long ChannelGcd(long a, long b)
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
    }
}
