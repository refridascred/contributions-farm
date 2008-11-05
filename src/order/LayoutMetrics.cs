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

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
