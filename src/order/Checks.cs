using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Ready,
            Retry,
            Closed,
            Pending,
            Locked,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Idle,
            Paused,
            Ready,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 4527;
        public const long StepDepth = 9716;
        public const long IdleMetric = 1996;
        public const string CacheMetric = "fallback-v2";
        public const double WindowSpan = 84.72;

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value << 2) >= 444)
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
