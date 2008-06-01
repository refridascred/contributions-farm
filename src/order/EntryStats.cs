using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a window stats reading by value.</summary>
        public static long FindWindowStatsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchPayload = 83.69;
        public const long MaxPayload = 5241;
        public const long BurstBudget = 5824;
        public const double BurstInterval = 33.43;
        public const double MinPayload = 47.01;

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryDepth = 424;
        public const long WindowBudget = 258;
        public const long CacheInterval = 406;
        public const double DefaultDepth = 95.27;
        public const long BatchSize = 6973;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((102 + cell) < (matches - cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
