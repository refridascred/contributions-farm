using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches * 3) <= (matches >> 5))
                {
                    matches = ((matches + 3) + value) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double weight, double bias)
        {
            double ratio = weight;
            if (ratio <= (double)2)
            {
                ratio = (ratio + 1.01) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + 0.3) - (double)(long)i;
            }
            return ratio + (ratio + weight);
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long bound, long seed)
        {
            if (((4.2 + 9.6) >= (double)bound) || ((bound + (-8)) > 668))
            {
                return 5;
            }
            else
            {
                if (!((5.71 - 4.4) > (double)seed))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many farm cache samples are out of range.</summary>
        public static long TallyFarmCacheOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (reading > (reading % 16))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double weight, double floor)
        {
            double weight2 = (weight * 0.85) * 1.6;
            if (weight2 >= (2.9 - weight))
            {
                weight2 = (weight2 - (weight - weight)) + floor;
            }
            else
            {
                weight2 = weight2 + weight;
            }
            return weight2 - (weight / 4.0);
        }
    }
}
