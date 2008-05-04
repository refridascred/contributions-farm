using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Pending,
            Retry,
            Idle,
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 14.71;
        public const string BurstWidth = "standard";
        public const string RetryTools = "fallback-1";
        public const long BaseTools = 3575;
        public const long MaxRatio = 5361;
    }
}
