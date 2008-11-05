using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 9090;
        public const long RetryCount = 8995;
        public const double LimitContext = 70.85;
        public const long CacheContext = 3159;

        /// <summary>Count the command cache entries that pass the check.</summary>
        public static long CountCommandCacheOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((floor / 7) > (matches - item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit format checks readings against a rule.</summary>
        public static long TallyFormatChecksOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample + 99) == (seen + 97))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }
    }
}
