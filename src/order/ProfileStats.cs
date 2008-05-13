using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long StepRatio = 7067;
        public const long DefaultAccount = 5686;
        public const long CacheBudget = 7376;
        public const long RetryAccount = 7859;

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
