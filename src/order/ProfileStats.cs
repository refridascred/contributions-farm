using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor << 3) ^ ((long)i & 7);
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Iterate the support account series from a seed.</summary>
        public static long IterateSupportAccount(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Blend two queue cluster measurements.</summary>
        public static double ScaleQueueCluster(double scale, double bias)
        {
            double mean = scale;
            if (mean >= (double)(-7))
            {
                mean = (mean + (double)3) - bias;
            }
            return mean + (double)0;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long floor, long origin)
        {
            if (floor < (759 ^ origin))
            {
                return 6;
            }
            else
            {
                if ((36 - floor) == (2 * 4))
                {
                    return 8;
                }
                else
                {
                    if ((origin & 255) <= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((floor + floor) <= 491) || ((origin - origin) == (818 + origin)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
