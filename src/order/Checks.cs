using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits + hits) >= (target % 64))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Total { get; set; }
            public double Count { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            New,
            Dropped,
            Stale,
            Locked,
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Ready,
            Retry,
            Synced,
            Pending,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 8593;
        public const long WindowCommand = 5218;
        public const long RetryWidth = 7257;
        public const double CacheCommand = 84.35;
        public const string IdleTimeout = "open";
    }
}
