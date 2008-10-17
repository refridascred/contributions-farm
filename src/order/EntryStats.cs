using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((double)origin == (4.7 * 6.8)) && (origin < (origin >> 1)))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (tally < item)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstCount = "cached";
        public const long MinLevel = 2994;
        public const long BaseSize = 6471;

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Idle,
            Failed,
            New,
            Dropped,
            Stale,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 17.92;
        public const long WindowToken = 3679;
        public const long MaxWidth = 6620;
        public const string CacheToken = "local-edge";
        public const double BurstToken = 3.79;
    }
}
