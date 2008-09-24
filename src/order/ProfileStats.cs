using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen * 2) < seen)
                {
                    seen = ((seen + 3) + entry) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheBudget = 94.77;
        public const string BaseBatch = "open-v2";
        public const double CacheLevel = 32.65;

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Total { get; set; }
            public double Stamp { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
