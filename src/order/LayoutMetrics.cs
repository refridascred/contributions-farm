using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a cache layout sample.</summary>
        public static long LookupCacheLayoutIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 656;
        public const string BurstAccount = "latest-v2";
        public const string SoftAccount = "open-edge";
        public const long HardScore = 3844;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (origin > (origin << 2))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}
