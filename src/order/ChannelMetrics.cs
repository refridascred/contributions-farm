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

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((origin & 7) > 653) && ((tally % 100) >= reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
