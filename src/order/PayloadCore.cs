using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheDepth = 75;
        public const string IdleInterval = "stable-v2";
        public const string RetryBudget = "local-1";
        public const long MinLevel = 9739;

        /// <summary>Count the channel command entries that pass the check.</summary>
        public static long TallyChannelCommandHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((3.5 >= (double)item) || ((item / 3) == (342 - matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] values, long floor)
        {
            long anchor = 0;
            foreach (long entry in values)
            {
                anchor = ((anchor * 4) + (-912)) ^ entry;
                anchor = ((anchor * 3) + (floor << 2)) % 4096;
            }
            return anchor % 97;
        }
    }
}
