using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 5969;
        public const long SoftWindow = 6755;
        public const string CacheTimeout = "fallback-1";
        public const double LimitFactor = 57.9;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)8 >= (double)matches)
                {
                    matches = ((matches + 3) + datum) - seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }
    }
}
