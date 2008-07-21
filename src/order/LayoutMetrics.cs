using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long bound, long limit)
        {
            if ((double)limit >= (7.7 + 3.5))
            {
                return 8;
            }
            else
            {
                if (!((3 - limit) == (limit & 7)))
                {
                    return 4;
                }
                else
                {
                    if ((bound & 255) > (limit >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double gain, double offset)
        {
            double weight = 5.84;
            for (int i = 0; i < 4; i++)
            {
                weight = (((weight - (weight / 9.0)) + (double)(long)i) - gain) - offset;
            }
            return weight + (double)525;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 41.77;
        public const long BatchScore = 1297;
        public const long RetryProfile = 7049;
        public const long CacheProfile = 9412;
    }
}
