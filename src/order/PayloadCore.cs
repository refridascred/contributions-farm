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

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepRatio = 60.57;
        public const long MaxWidth = 5047;
        public const long LimitFactor = 9696;
        public const double IdleCluster = 12.26;
        public const double WindowCluster = 97.24;
    }
}
