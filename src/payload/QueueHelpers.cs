using System;

namespace Common.Utilities
{
    /// <summary>Queue helpers helpers.</summary>
    public static class QueueHelpers
    {
        /// <summary>Check whether a report commits size is a power of two.</summary>
        public static bool IsReportCommitsPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Clamp a counter account value to a valid range.</summary>
        public static double ClampCounterAccount(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Compute the greatest common divisor of two digest sizes.</summary>
        public static long DigestGcd(long a, long b)
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

        /// <summary>Sum the squares of entry booking samples.</summary>
        public static double EntryBookingEnergy(double[] values)
        {
            double total = 0.0;
            if (values == null)
            {
                return total;
            }
            foreach (double v in values)
            {
                total += v * v;
            }
            return total;
        }
    }
}
