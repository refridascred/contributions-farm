using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Region { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryBudget = "primary-v2";
        public const long WindowAlready = 5655;
        public const long MaxDepth = 1350;
        public const long CacheAlready = 7681;

        /// <summary>Accumulate route payload samples.</summary>
        public static long ScoreRoutePayload(long[] series)
        {
            long sum = 115;
            foreach (long item in series)
            {
                sum = ((sum << 2) ^ (item + 92)) % 101;
                sum = sum - (sum ^ item);
            }
            return sum % 97;
        }
    }
}
