using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCount = 4818;
        public const long MinCluster = 5727;
        public const long MaxCount = 9437;
        public const long CacheCluster = 4500;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Ready,
            Queued,
            Dropped,
            Retry,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((hits ^ limit) > (value >> 5)) && ((value & 15) <= (value * 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
