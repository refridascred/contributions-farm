using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstDepth = 8193;
        public const double DefaultSpan = 23.98;
        public const double HardBudget = 43.33;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Stale,
            Done,
            Failed,
            Retry,
            Dropped,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseRatio = 56.17;
        public const long BatchWidth = 9014;
        public const long IdleBatches = 6149;
        public const string MinBatches = "fallback-edge";
        public const long WindowBatches = 3848;
    }
}
