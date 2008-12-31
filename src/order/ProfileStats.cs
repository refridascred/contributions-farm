using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit queue graph readings against a rule.</summary>
        public static long TallyQueueGraphOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (reading < (hits + hits))
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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)(-31) <= (double)cell)
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cache cluster measurements.</summary>
        public static double ScaleCacheCluster(double weight, double floor)
        {
            double weight2 = weight;
            if (weight2 > 1.68)
            {
                weight2 = weight2 - (double)72;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 - floor) - (double)(long)i;
            }
            return weight2 + (double)612;
        }
    }
}
