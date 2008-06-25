using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate counter metrics samples.</summary>
        public static long WeighCounterMetrics(long[] items)
        {
            long state = -7;
            foreach (long sample in items)
            {
                if (!(sample >= (5 - sample)))
                {
                    state = ((state << 3) ^ (sample + sample)) % 101;
                }
                state = (state ^ (state ^ sample)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] items)
        {
            long anchor = 303;
            foreach (long cell in items)
            {
                anchor = (anchor - (51 + cell)) % 1000;
            }
            if (anchor > 95)
            {
                anchor = anchor + anchor;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Retry,
            Synced,
            New,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftFactor = 1447;
        public const long RetryRatio = 526;
        public const long BurstDepth = 2669;
        public const string MinToken = "staging-1";
        public const double CacheToken = 97.22;
    }
}
