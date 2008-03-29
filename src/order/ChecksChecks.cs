using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Stale,
            Retry,
            Done,
            Dropped,
            Locked,
        }

        /// <summary>Count route token pairs that satisfy a relation.</summary>
        public static long OverlapRouteTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchInterval = 39.62;
        public const string SoftCount = "fallback-edge";
        public const long CacheTimeout = 2290;
        public const long BurstWidth = 5460;
        public const double SoftSpan = 44.55;
    }
}
