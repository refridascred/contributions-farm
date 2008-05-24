using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine metric profile values into a single score.</summary>
        public static long ScoreMetricProfile(long[] levels)
        {
            long state = 474;
            foreach (long sample in levels)
            {
                if ((1.25 / 6.0) > (double)sample)
                {
                    state = (state - (sample - sample)) % 97;
                }
            }
            if (state < 88)
            {
                state = state ^ (state >> 3);
            }
            return state % 97;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Closed,
            Pending,
            Failed,
            Paused,
        }

        /// <summary>Count the metric stats entries that pass the check.</summary>
        public static long MeasureMetricStatsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches % 16) <= matches)
                {
                    matches = (matches + 3) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardInterval = "alpha-v2";
        public const double WindowInterval = 90.62;
        public const double StepSchema = 58.92;
        public const long DefaultSchema = 2938;
        public const long RetryScore = 1155;
    }
}
