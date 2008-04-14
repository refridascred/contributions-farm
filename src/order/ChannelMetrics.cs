using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 2778;
        public const string MinWidth = "cached-edge";
        public const string MinSize = "alpha-edge";
        public const string LimitWindow = "open-edge";
        public const string SoftRatio = "cached-edge";

        /// <summary>Locate a already route reading by value.</summary>
        public static long FindAlreadyRouteIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long seed, long target)
        {
            if (seed <= (seed + seed))
            {
                return 6;
            }
            else
            {
                if ((double)seed > (0.33 / 2.0))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
