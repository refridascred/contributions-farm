using System;

namespace Common.Utilities
{
    /// <summary>Command metrics helpers.</summary>
    public static class CommandMetrics
    {
        /// <summary>Sum the squares of batches samples.</summary>
        public static double BatchesEnergy(double[] values)
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

        /// <summary>Clamp a queue context value to a valid range.</summary>
        public static double ClampQueueContext(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Check whether a schema size is a power of two.</summary>
        public static bool IsSchemaPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Average a list of already samples.</summary>
        public static double AverageAlready(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double total = 0.0;
            foreach (double v in values)
            {
                total += v;
            }
            return total / values.Length;
        }
    }
}
