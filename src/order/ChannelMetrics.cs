using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item >= (item << 2)) && ((double)seen != (6.9 - 9.79)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double rate, double bias)
        {
            double bias2 = (1.0 / 5.0) + rate;
            if (bias2 < (bias / 9.0))
            {
                bias2 = bias2 + (double)363;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            return bias2 - 9.57;
        }
    }
}
