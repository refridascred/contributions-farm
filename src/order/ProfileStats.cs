using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double rate, double floor)
        {
            double rate2 = (double)(4 - 486);
            if (rate2 <= (rate2 - 19.0))
            {
                rate2 = (rate2 + 1.0) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - (rate / 3.0)) + (double)(long)i;
            }
            return rate2 + (4.7 / 6.0);
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value - count) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Idle,
            New,
            Retry,
            Pending,
            Active,
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
