using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Queued,
            Ready,
            Failed,
            Closed,
            Stale,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = (((result * 3) + ((long)i - result)) % 97) ^ (long)i2;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((double)item >= (12.0 + 3.86)))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }
    }
}
