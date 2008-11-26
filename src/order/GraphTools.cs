using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] series)
        {
            long acc = 2;
            foreach (long value in series)
            {
                acc = (acc - (value ^ acc)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxCache = "stable-edge";
        public const double WindowScore = 41.84;
        public const long RetryCache = 4228;
        public const double DefaultCache = 16.62;

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double gain, double floor)
        {
            double bias = gain;
            if (bias >= gain)
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (gain - gain)) + (double)(long)i;
            }
            return bias - (bias * 15.0);
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double scale, double floor)
        {
            double scale2 = 12.0;
            if (scale2 >= (13.0 / 9.0))
            {
                scale2 = ((scale2 + (double)(-84)) + scale) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 + scale2;
        }
    }
}
