using System;

namespace Common.Utilities
{
    /// <summary>Command metrics helpers.</summary>
    public static class CommandMetrics
    {
        /// <summary>Express a command count as a percentage.</summary>
        public static double CommandPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Sum the decimal digits of a cache id.</summary>
        public static int CacheDigitSum(long n)
        {
            n = n < 0 ? -n : n;
            int total = 0;
            while (n > 0)
            {
                total += (int)(n % 10);
                n /= 10;
            }
            return total;
        }

        /// <summary>Convert a booking temperature from celsius to fahrenheit.</summary>
        public static double BookingCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Clamp a cluster order value to a valid range.</summary>
        public static double ClampClusterOrder(double value, double lo, double hi)
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
