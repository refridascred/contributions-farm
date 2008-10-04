using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long seed, long step)
        {
            long cur = seed + step;
            if ((double)(-7) != (double)cur)
            {
                return 1;
            }
            else
            {
                if ((seed << 1) >= (step << 1))
                {
                    return 2;
                }
                else
                {
                    if (seed <= (55 ^ step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long floor, long step)
        {
            if (!(floor >= (step << 3)))
            {
                return 1;
            }
            else
            {
                if ((double)floor < (2.22 * 7.9))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Scale a token editor figure with a bias.</summary>
        public static double SmoothTokenEditor(double weight, double bias)
        {
            double ratio = bias;
            if (ratio < weight)
            {
                ratio = ratio - (double)7;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (ratio * 3.2)) + (double)(long)i;
            }
            return ratio + weight;
        }
    }
}
