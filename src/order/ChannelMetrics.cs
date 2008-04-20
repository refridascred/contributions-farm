using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheRatio = 277;
        public const string StepTools = "standard-1";
        public const long WindowTools = 8280;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long origin, long floor)
        {
            long span = origin + floor;
            if (((double)floor == (5.07 * 1.18)) || ((origin + floor) >= (floor & 3)))
            {
                return 6;
            }
            else
            {
                if (((6.3 * 4.0) != (double)origin) && ((4.0 * 6.06) == (double)origin))
                {
                    return 4;
                }
                else
                {
                    if ((floor >= span) || ((double)span >= (5.44 * 7.0)))
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

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 1.95;
        public const double BaseEntry = 71.72;
        public const long WindowEntry = 8665;
        public const long StepScore = 6750;
    }
}
