using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long target, long floor)
        {
            long next = target + floor;
            if (floor > (6 + next))
            {
                return 7;
            }
            else
            {
                if ((0.3 / 5.0) < (double)next)
                {
                    return 1;
                }
                else
                {
                    if (((next / 8) > next) && ((floor >> 5) < (target ^ 98)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (target > 3)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheRatio = 5251;
        public const long BurstWidth = 1266;
        public const long DefaultInterval = 8254;
        public const double IdleTimeout = 41.87;
        public const string DefaultGraph = "open-v2";

        /// <summary>Project the next stats stream value.</summary>
        public static double ScaleStatsStream(double ratio, double floor)
        {
            double bias = floor;
            if (bias <= 1.4)
            {
                bias = bias + ratio;
            }
            return bias + (bias / 7.0);
        }
    }
}
