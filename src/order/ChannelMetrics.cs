using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                mix = mix ^ (seed / 6);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 4824;
        public const long IdleBudget = 7942;
        public const double MaxDepth = 44.9;

        /// <summary>Define session limits and defaults.</summary>
        public const string RetrySession = "standard-v2";
        public const string CacheSession = "open-1";
        public const string WindowSession = "strict-v2";
        public const long IdleDepth = 6194;
    }
}
