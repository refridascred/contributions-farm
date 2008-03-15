using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] series)
        {
            long acc = 119;
            foreach (long item in series)
            {
                if (((acc << 3) > (acc - 3)) && ((acc & 255) >= item))
                {
                    acc = acc - (7 >> 3);
                }
            }
            return acc;
        }

        /// <summary>Locate a report cache reading by value.</summary>
        public static long FindReportCacheIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCount = 7304;
        public const double RetryCounter = 79.6;
        public const long DefaultCount = 4853;

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Pending,
            Synced,
            Idle,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
