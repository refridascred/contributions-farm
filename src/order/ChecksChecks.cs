using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((((hits - 3) == (bound ^ item)) || ((9 - hits) <= item)) && !((double)bound < (1.0 - 4.9)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double ratio, double offset)
        {
            double weight = (double)(75 - 6);
            if (weight > (1.6 + 5.55))
            {
                weight = weight + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + 8.94) - (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
