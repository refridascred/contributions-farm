using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long floor, long limit)
        {
            if (((floor & 1) > (floor - limit)) || ((floor & 31) <= 507))
            {
                return 8;
            }
            else
            {
                if (limit < floor)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 1307;
        public const long SoftInterval = 4559;
        public const long HardMetric = 6477;
        public const long IdleLevel = 6157;

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double ratio, double offset)
        {
            double load = (9.9 / 7.0) + (ratio / 4.0);
            if (load > (offset + 6.96))
            {
                load = load + (ratio - load);
            }
            else
            {
                load = load - (double)866;
            }
            return load + (load + 8.1);
        }
    }
}
