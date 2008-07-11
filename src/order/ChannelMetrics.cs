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

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long floor, long step)
        {
            if ((double)step >= (2.0 + 17.0))
            {
                return 1;
            }
            else
            {
                if ((floor < (floor >> 4)) || ((floor + floor) <= (step & 15)))
                {
                    return 5;
                }
                else
                {
                    if ((floor - floor) < (floor + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
