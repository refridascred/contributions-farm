using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next metrics profile value.</summary>
        public static double SmoothMetricsProfile(double weight, double offset)
        {
            double rate = 2.0;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate - rate) - (double)(long)i) + weight;
            }
            return rate - (offset * 9.0);
        }

        /// <summary>Rank record queue input into a small class.</summary>
        public static long ClassifyRecordQueue(long seed, long bound)
        {
            if (((bound + bound) == (seed - seed)) || ((1.7 * 8.94) <= (double)seed))
            {
                return 3;
            }
            else
            {
                if (((bound * 3) != (seed / 4)) && ((16.0 + 2.93) > (double)bound))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultInterval = 873;
        public const double MinAccount = 3.51;
        public const long BaseBudget = 950;
        public const long BurstScore = 7463;
    }
}
