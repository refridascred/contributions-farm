using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long seed, long limit)
        {
            long step = seed ^ limit;
            if (((double)limit > (double)seed) || ((1.3 * 7.2) < (double)seed))
            {
                return 6;
            }
            else
            {
                if ((step - seed) > (step - limit))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item * 5) <= (item & 127))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Pending,
            Locked,
            Idle,
            Ready,
            Dropped,
        }
    }
}
