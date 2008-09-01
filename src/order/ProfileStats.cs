using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((0.82 - 5.6) <= (double)matches)
                {
                    matches = ((matches + 2) + value) - origin;
                }
            }
            return matches;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!(((double)matches < (9.13 + 8.83)) && ((matches & 31) == (offset + offset))))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstSpan = "staging";
        public const double BaseSize = 82.16;
        public const string LimitMetrics = "stable-1";
        public const long SoftTimeout = 8470;
    }
}
