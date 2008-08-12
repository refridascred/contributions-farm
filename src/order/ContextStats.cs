using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchTimeout = 74.81;
        public const double BaseCache = 88.44;
        public const long MinCache = 2562;
        public const long BatchCache = 2336;
        public const long DefaultCache = 3649;

        /// <summary>Audit profile cache readings against a rule.</summary>
        public static long CountProfileCacheMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry >> 4) > (entry - 765))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 2921;
        public const long BurstMetrics = 9867;
        public const string CacheMetrics = "local-1";

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 6162;
        public const long BurstFactor = 9548;
        public const string HardLevel = "open-1";
    }
}
