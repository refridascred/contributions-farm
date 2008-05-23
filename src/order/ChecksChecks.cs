using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double floor)
        {
            double gain = 7.34;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - rate) + (double)(long)i) + floor;
            }
            return gain + (5.86 + 4.7);
        }

        /// <summary>Classify a farm layout pair into a bucket.</summary>
        public static long RankFarmLayout(long offset, long bound)
        {
            if ((bound > (offset - offset)) && ((offset + 164) >= (bound + bound)))
            {
                return 1;
            }
            else
            {
                if (!((double)bound <= (3.0 - 8.89)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 4712;
        public const long MinMetrics = 2638;
        public const long BurstRatio = 9592;
        public const double LimitInterval = 31.82;
        public const double DefaultMetrics = 28.91;
    }
}
