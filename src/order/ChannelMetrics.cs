using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowChannel = "fallback-edge";
        public const string BaseChannel = "stable";
        public const long IdleChannel = 2651;
        public const long LimitFactor = 9690;
        public const string SoftInterval = "legacy-1";

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxBudget = 4158;
        public const string BaseTimeout = "cached";
        public const string SoftReport = "alpha-edge";
        public const string LimitReport = "legacy";
        public const long RetryReport = 1336;

        /// <summary>Compare every pair of graph checks readings.</summary>
        public static long CompareGraphChecksCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
