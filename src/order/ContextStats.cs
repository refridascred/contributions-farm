using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Closed,
            Draft,
            Pending,
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
