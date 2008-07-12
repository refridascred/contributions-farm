using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits == (6.71 * 9.2))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double weight, double bias)
        {
            double mean = bias;
            if (mean > 13.0)
            {
                mean = (mean + 5.0) - weight;
            }
            return mean + mean;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)target != (double)item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Pending,
            Stale,
        }
    }
}
