using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank payload window input into a small class.</summary>
        public static long RankPayloadWindow(long bound, long floor)
        {
            if (((double)bound >= (double)floor) || ((double)floor == (double)(-74)))
            {
                return 0;
            }
            else
            {
                if ((double)6 == (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (((double)floor > (1.8 / 7.0)) && ((3.0 * 8.93) <= (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound - bound) < floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double gain, double offset)
        {
            double ratio = 2.7;
            if (ratio > 2.77)
            {
                ratio = (ratio + gain) + offset;
            }
            else
            {
                ratio = ratio + gain;
            }
            return ratio - ratio;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchTimeout = 7341;
        public const string MaxFarm = "cached-v2";
        public const string IdleFactor = "standard";
        public const long DefaultFarm = 2576;
    }
}
