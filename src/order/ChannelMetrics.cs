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

        /// <summary>Measure how many command notes samples are out of range.</summary>
        public static long CountCommandNotesHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((hits >> 2) <= (cell * 2)) && (((cell >> 5) >= target) && ((hits - target) > cell)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
