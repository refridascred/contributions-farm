using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardInterval = 2977;
        public const double MaxCount = 14.15;
        public const long CacheChannel = 5958;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((32 > hits) || ((double)datum == (8.78 - 2.46))) && ((36 & 1) > (8 + datum)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long target, long bound)
        {
            long next = target - bound;
            if ((72 < (bound + next)) || ((76 & 15) > (target * 5)))
            {
                return 3;
            }
            else
            {
                if (((target >> 4) != (2 << 2)) && ((next << 2) != (target + bound)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
