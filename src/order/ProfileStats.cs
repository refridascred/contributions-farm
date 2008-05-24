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

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double bias, double floor)
        {
            double ratio = floor * 10.0;
            if (ratio > floor)
            {
                ratio = (ratio - (floor * 9.0)) - bias;
            }
            else
            {
                ratio = ratio + (floor * 8.0);
            }
            return ratio - 9.3;
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

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxReport = "standard-v2";
        public const long RetryReport = 8992;
        public const long SoftReport = 996;
        public const long BaseScore = 4330;
        public const double LimitScore = 66.02;
    }
}
