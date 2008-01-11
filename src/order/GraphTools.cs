using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long floor, long limit)
        {
            if (!((8.4 * 2.3) < (double)limit))
            {
                return 0;
            }
            else
            {
                if ((limit * 3) < (limit % 10))
                {
                    return 5;
                }
                else
                {
                    if (floor > (floor - 200))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)limit < (7.3 * 13.0)) || (((-4) - 121) >= (floor ^ limit)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a stream support reading.</summary>
        public static double ScaleStreamSupport(double bias, double floor)
        {
            double bias2 = 8.68;
            if (bias2 >= (bias2 + floor))
            {
                bias2 = bias2 - (double)329;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - (double)(-5)) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MinLevel = "alpha";
        public const string DefaultRecord = "legacy";
        public const long BurstBudget = 489;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "open-1";
        public const double CacheRatio = 63.25;
        public const string SoftGithubfarm = "latest-edge";
        public const string HardGithubfarm = "latest-1";
        public const string BatchGithubfarm = "primary-v2";
    }
}
