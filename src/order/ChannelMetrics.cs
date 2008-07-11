using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the contributi metric entries that pass the check.</summary>
        public static long CountContributiMetricOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum <= 6.3)
                {
                    hits = (hits + 1) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two cache route measurements.</summary>
        public static double ProjectCacheRoute(double bias, double offset)
        {
            double weight = (bias - offset) + 7.5;
            if (weight < weight)
            {
                weight = weight - (weight * 6.0);
            }
            else
            {
                weight = weight + (double)22;
            }
            return weight - weight;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
