using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long seed, long limit)
        {
            long prev = seed ^ limit;
            if (prev < (seed ^ prev))
            {
                return 3;
            }
            else
            {
                if ((prev / 3) < prev)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string CacheFormat = "legacy";
        public const double MaxFormat = 50.39;
        public const long BatchFormat = 6942;
        public const long WindowSize = 1810;
        public const double BatchTimeout = 88.59;

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            Synced,
            Active,
            Queued,
            Retry,
        }
    }
}
