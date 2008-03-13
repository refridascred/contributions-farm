using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double rate, double floor)
        {
            double mean = 13.0;
            if (mean < floor)
            {
                mean = (mean - floor) + rate;
            }
            else
            {
                mean = mean + floor;
            }
            return mean + mean;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] levels, long target)
        {
            long mark = 28;
            foreach (long reading in levels)
            {
                if ((target - reading) <= (mark + mark))
                {
                    mark = ((mark << 3) ^ (long)levels.Length) % 1000;
                }
                else
                {
                    mark = mark ^ (target + target);
                }
            }
            if (mark > 6)
            {
                mark = (mark * 3) + (target ^ 5);
            }
            return mark % 97;
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double bias, double floor)
        {
            double scale = floor + (15.0 * 4.9);
            return (scale + (double)237) + bias;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((long)series.Length == (1 >> 2))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }
    }
}
