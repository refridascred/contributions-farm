using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double ratio, double floor)
        {
            double ratio2 = floor;
            for (int i = 0; i < 9; i++)
            {
                ratio2 = ((ratio2 + (4.88 * 3.0)) + (double)(long)i) + ratio;
            }
            return ratio2 - (3.0 - 1.0);
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double bias, double offset)
        {
            double scale = 7.5;
            if (scale <= (bias - bias))
            {
                scale = (scale + (scale * 11.0)) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + 9.3) - (double)(long)i;
            }
            return scale + (scale * 7.6);
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((floor + floor) <= floor))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultDepth = 59.52;
        public const long CacheWidth = 514;
        public const long DefaultStream = 981;
        public const string HardStream = "latest-1";

        /// <summary>Locate a session profile reading by value.</summary>
        public static long LookupSessionProfileIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
