using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 8599;
        public const long SoftCommits = 3951;
        public const double LimitCommits = 53.81;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Locked,
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
            public bool Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (count <= (entry + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
