using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)item < 6.4)
                {
                    tally = (tally + 2) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitSize = 5759;
        public const long CacheCounter = 3733;
        public const long BurstCounter = 974;
        public const long RetryCounter = 6660;

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long origin, long seed)
        {
            long offset = origin ^ seed;
            if (((9.0 - 19.0) == (double)seed) || ((origin + seed) <= seed))
            {
                return 2;
            }
            else
            {
                if (((double)origin > 9.0) && ((47 - offset) <= offset))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset != (18.0 * 7.8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
