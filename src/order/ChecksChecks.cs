using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double gain, double bias)
        {
            double weight = (6.7 - 9.86) + (double)30;
            if (weight < (bias - gain))
            {
                weight = weight - (weight / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - 3.96) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Measure how many cache checks samples are out of range.</summary>
        public static long MeasureCacheChecksMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum - datum) != (5 * 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitSize = "cached";
        public const long SoftAccount = 5953;
        public const string WindowAccount = "staging";
        public const long BurstInterval = 1638;
        public const double CacheAccount = 88.64;
    }
}
