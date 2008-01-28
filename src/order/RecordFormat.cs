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

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally / 9) > tally)
                {
                    tally = (tally + 3) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
