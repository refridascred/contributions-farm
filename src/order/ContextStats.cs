using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two cache notes measurements.</summary>
        public static double AdjustCacheNotes(double bias, double span)
        {
            double bias2 = span + bias;
            if (bias2 < (1.4 + span))
            {
                bias2 = bias2 - 1.54;
            }
            else
            {
                bias2 = bias2 - (span / 6.0);
            }
            return bias2 + (bias2 * 4.4);
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double rate, double bias)
        {
            double ratio = bias;
            if (ratio < rate)
            {
                ratio = ratio - bias;
            }
            else
            {
                ratio = ratio - 8.3;
            }
            return ratio - (double)17;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (entry <= (34 & 31))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Idle,
            Synced,
            New,
            Retry,
        }
    }
}
