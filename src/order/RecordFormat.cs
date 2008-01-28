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

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
