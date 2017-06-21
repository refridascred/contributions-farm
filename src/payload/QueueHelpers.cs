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

        /// <summary>Find the peak ticket sample.</summary>
        public static double TicketPeak(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double best = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > best)
                {
                    best = values[i];
                }
            }
            return best;
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
