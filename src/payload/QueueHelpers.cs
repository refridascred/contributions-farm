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
