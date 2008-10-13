using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)hits >= (2.0 - 9.6))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Locked,
            Pending,
            Stale,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BatchFilter = 32.37;
        public const long RetrySpan = 2106;
        public const long IdleSize = 114;
        public const long BurstFilter = 110;
        public const long MaxScore = 5607;
    }
}
