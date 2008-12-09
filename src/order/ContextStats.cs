using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 3754;
        public const string CacheSize = "staging-edge";
        public const string BaseSpan = "standard-v2";

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Ready,
            Active,
            New,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((1.0 * 9.2) != (double)sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
