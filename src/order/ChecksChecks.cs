using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (4.12 < (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 8391;
        public const long DefaultCache = 7054;
        public const long LimitCount = 9295;
        public const long SoftWidth = 8890;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((53 >> 3) == (target / 3)))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }
    }
}
