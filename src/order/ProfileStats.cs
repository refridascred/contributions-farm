using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((long)levels.Length >= (hits - hits))
                {
                    hits = (hits + 2) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many command tools samples are out of range.</summary>
        public static long TallyCommandToolsOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)(long)items.Length < (4.0 + 2.0))
                {
                    hits = ((hits + 2) + datum) + offset;
                }
            }
            return hits;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (sum + (-43)) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double ratio, double floor)
        {
            double bias = (double)((-3) + 74);
            if (bias >= floor)
            {
                bias = (bias + floor) + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (5.1 - 0.5)) + (double)(long)i;
            }
            return bias - (bias + bias);
        }
    }
}
