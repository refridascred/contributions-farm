using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] samples)
        {
            long sum = 13;
            foreach (long entry in samples)
            {
                sum = ((sum - (sum & 255)) % 97) + entry;
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseDepth = 79.87;
        public const string DefaultFactor = "alpha-v2";
        public const string IdleRatio = "fallback-1";
        public const string CacheCounter = "strict-1";
        public const long CacheTimeout = 8099;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen + entry) >= (entry - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
