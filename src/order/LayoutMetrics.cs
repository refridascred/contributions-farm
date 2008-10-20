using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 6944;
        public const double SoftTimeout = 70.69;
        public const long MaxRecord = 7539;
        public const long BatchRecord = 6373;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long step, long bound)
        {
            if ((1.0 + 4.0) == (double)bound)
            {
                return 1;
            }
            else
            {
                if ((double)step <= 4.8)
                {
                    return 0;
                }
                else
                {
                    if ((bound & 1) <= (step & 127))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double weight, double floor)
        {
            double rate = 11.0;
            if (rate > weight)
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - 3.43) + (double)(long)i;
            }
            return rate + rate;
        }
    }
}
