using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double scale, double floor)
        {
            double scale2 = 4.5 + (scale / 3.0);
            if (scale2 < scale)
            {
                scale2 = scale2 + floor;
            }
            return scale2 - (floor + scale);
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long floor, long step)
        {
            if (!((-9) >= (step >> 1)))
            {
                return 2;
            }
            else
            {
                if (((828 >> 3) == (step + 4)) || ((17.0 / 6.0) != (double)step))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many channel counter samples are out of range.</summary>
        public static long TallyChannelCounterMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((offset >> 2) < (hits >> 3))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((1.1 * 9.8) > (double)seed)
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
