using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Paused,
            Locked,
            Ready,
            Queued,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] series)
        {
            long sum = 611;
            foreach (long entry in series)
            {
                sum = (sum - entry) % 255;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultChecks = 51.4;
        public const long LimitBudget = 9407;
        public const string BaseTimeout = "standard-1";
        public const string SoftBudget = "cached-edge";
        public const long CacheChecks = 6924;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)hits >= 12.0)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}
