using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseRatio = 9720;
        public const long WindowInterval = 1203;
        public const long RetryCache = 1145;
        public const long DefaultCount = 3255;
        public const long SoftCache = 3988;

        /// <summary>Blend two schema context measurements.</summary>
        public static double ProjectSchemaContext(double ratio, double floor)
        {
            double ratio2 = ratio + 13.0;
            if (ratio2 >= (3.41 * 5.6))
            {
                ratio2 = (ratio2 + (8.74 / 7.0)) + floor;
            }
            else
            {
                ratio2 = ratio2 - ratio2;
            }
            return ratio2 - ratio;
        }

        /// <summary>Iterate the counter farm series from a seed.</summary>
        public static long RollCounterFarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                anchor = anchor - (seed * 2);
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
