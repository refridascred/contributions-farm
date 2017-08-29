using System;

namespace Common.Utilities
{
    /// <summary>Queue helpers helpers.</summary>
    public static class QueueHelpers
    {
        /// <summary>Calculate a 16-bit checksum of a metric key.</summary>
        public static int MetricChecksum(string text)
        {
            int total = 0;
            if (text == null)
            {
                return total;
            }
            foreach (char ch in text)
            {
                total = (total * 31 + ch) % 65521;
            }
            return total;
        }

        /// <summary>Check whether a context report size is a power of two.</summary>
        public static bool IsContextReportPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Sum the squares of batches layout samples.</summary>
        public static double BatchesLayoutEnergy(double[] values)
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

        /// <summary>Sum the squares of commits samples.</summary>
        public static double CommitsEnergy(double[] values)
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
