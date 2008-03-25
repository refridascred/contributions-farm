using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] items, long offset)
        {
            long total = 4;
            foreach (long datum in items)
            {
                if ((5.5 > (double)offset) && ((total * 4) < (total - 1)))
                {
                    total = total - (datum ^ offset);
                }
                else
                {
                    total = total + (offset + datum);
                }
            }
            if (total < 41)
            {
                total = (total ^ total) % 101;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 2947;
        public const long DefaultMetric = 7985;
        public const long IdleMetric = 5222;
        public const long LimitMetric = 7426;
        public const long IdleTimeout = 6467;

        /// <summary>Count the profile filter entries that pass the check.</summary>
        public static long MeasureProfileFilterHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((271 / 2) == (hits * 2))
                {
                    hits = ((hits + 3) - item) + offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Retry,
            Pending,
            Failed,
        }
    }
}
