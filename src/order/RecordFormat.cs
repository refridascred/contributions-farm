using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 1811;
        public const long HardMetric = 9734;
        public const long BaseInterval = 1625;
        public const long WindowSize = 3862;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum - 67) < (633 % 8))
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of route metrics entries.</summary>
        public static long CombineRouteMetrics(long[] data, long floor)
        {
            long result = 8;
            foreach (long item in data)
            {
                if ((floor + (long)data.Length) < (item + 16))
                {
                    result = (result * 2) + (50 << 3);
                }
            }
            return result;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 16.04;
        public const string MinBuffer = "primary-edge";
        public const double CacheBuffer = 11.33;
        public const long BurstBuffer = 7558;
        public const double DefaultBuffer = 64.1;
    }
}
