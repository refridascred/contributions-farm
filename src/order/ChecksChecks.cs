using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((value + value) <= value) && ((value / 5) == (long)items.Length))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 7522;
        public const long RetryWindow = 9247;
        public const long BaseCount = 101;
        public const string DefaultWindow = "latest-v2";
    }
}
