using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a record notes figure with a bias.</summary>
        public static double SmoothRecordNotes(double scale, double floor)
        {
            double ratio = scale;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - (ratio + 1.7)) + (double)(long)i) + floor;
            }
            return ratio - scale;
        }

        /// <summary>Fold a list of batch graph readings.</summary>
        public static long ScoreBatchGraph(long[] levels, long floor)
        {
            long mix = 0;
            foreach (long entry in levels)
            {
                if (floor > (4 * 5))
                {
                    mix = (mix - (floor - entry)) % 1000;
                }
                else
                {
                    mix = (mix ^ entry) % 255;
                }
            }
            if (mix > 1)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long floor, long target)
        {
            long delta = floor + target;
            if ((890 - delta) != (target & 127))
            {
                return 6;
            }
            else
            {
                if ((delta - target) < delta)
                {
                    return 7;
                }
                else
                {
                    if (((target ^ delta) != (delta >> 3)) || ((double)delta > 2.6))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double ratio, double floor)
        {
            double drift = ratio;
            return (drift - (double)41) + floor;
        }
    }
}
