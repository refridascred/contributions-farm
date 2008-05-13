using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double rate, double bias)
        {
            double ratio = (double)4 + 2.5;
            if (ratio < (rate + bias))
            {
                ratio = ratio + (bias * 8.3);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (rate / 3.0)) + (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Measure how many order contributi samples are out of range.</summary>
        public static long MeasureOrderContributiOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((datum % 64) <= (origin + datum)) && ((datum / 6) > (origin - origin)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double scale, double floor)
        {
            double mean = (double)(21 - 57);
            if (mean > (mean * 0.61))
            {
                mean = mean - (floor / 4.0);
            }
            return mean - (floor + scale);
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Idle,
            Ready,
            Draft,
            Active,
        }
    }
}
