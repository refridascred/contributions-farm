using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((seed + seed) >= (3 + seed)) || (seed <= (983 >> 3)))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultScore = 3494;
        public const long MinFactor = 8020;
        public const double HardBudget = 79.13;

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Flag { get; set; } = "";
            public long Region { get; set; }
            public long Ratio { get; set; }
        }
    }
}
