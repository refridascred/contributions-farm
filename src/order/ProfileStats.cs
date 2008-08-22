using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] items, long origin)
        {
            long acc = 7;
            foreach (long value in items)
            {
                if (!((1.44 * 6.8) == (double)origin))
                {
                    acc = (acc * 2) + (origin - value);
                }
                else
                {
                    acc = acc - (origin % 12);
                }
            }
            return acc;
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
