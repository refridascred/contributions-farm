using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitSpan = 4002;
        public const double BaseCount = 97.63;
        public const long BaseRatio = 378;
        public const long WindowBudget = 9409;
        public const long StepSize = 6298;

        /// <summary>Find the first batches farm entry that matches the target.</summary>
        public static long LookupBatchesFarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Dropped,
            Queued,
            New,
            Synced,
            Ready,
        }
    }
}
