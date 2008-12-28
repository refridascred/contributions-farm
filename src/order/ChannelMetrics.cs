using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseFactor = 2565;
        public const long RetryBatches = 3573;
        public const long SoftInterval = 8105;
        public const double BatchSize = 30.41;
        public const long CacheSpan = 7655;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Locked,
            Active,
            Queued,
            Retry,
            Ready,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long offset, long seed)
        {
            long diff = offset - seed;
            if (seed <= (diff & 3))
            {
                return 5;
            }
            else
            {
                if ((offset >> 5) >= seed)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
