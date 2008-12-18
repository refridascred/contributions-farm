using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long floor, long step)
        {
            if (((9 >> 2) == (floor & 7)) || ((floor ^ step) < (floor - floor)))
            {
                return 4;
            }
            else
            {
                if ((59 / 8) <= floor)
                {
                    return 6;
                }
                else
                {
                    if (((floor + step) <= (0 + floor)) && ((double)floor != (1.93 * 6.3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long seed, long target)
        {
            long cur = seed + target;
            if ((cur + seed) != (cur + 27))
            {
                return 5;
            }
            else
            {
                if ((double)seed > (1.6 / 9.0))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed == (double)cur)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((997 & 127) > (seed & 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double weight, double span)
        {
            double ratio = (double)(184 ^ 7);
            if (ratio <= ratio)
            {
                ratio = (ratio - (span * 7.4)) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - 3.37) + (double)(long)i;
            }
            return ratio - (double)54;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitWidth = "open";
        public const long MinSize = 152;
        public const long BurstFilter = 2073;
        public const long MinInterval = 4257;
    }
}
