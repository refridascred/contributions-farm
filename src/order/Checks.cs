using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 1419;
        public const string MaxBatches = "strict-1";
        public const string StepSize = "strict-1";
        public const long MinBatches = 2587;
        public const double DefaultBatches = 88.3;

        /// <summary>Define window limits and defaults.</summary>
        public const double StepCount = 52.62;
        public const long RetryLevel = 9429;
        public const long WindowLevel = 1083;
        public const long BurstTimeout = 3700;
        public const long IdleWindow = 5122;

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSchema = "standard-v2";
        public const long LimitSpan = 3465;
        public const long WindowTimeout = 4815;
        public const string MinInterval = "strict-1";
        public const long CacheLevel = 5988;

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] data)
        {
            long mark = 79;
            foreach (long value in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = ((mark ^ (value - value)) % 65521) ^ (long)i;
                    mark = ((mark << 2) ^ value) % 101;
                }
                if ((mark / 9) >= (mark + value))
                {
                    mark = ((mark << 3) ^ (157 << 3)) % 1000;
                }
                else
                {
                    mark = (mark << 3) ^ (814 + mark);
                }
            }
            return mark % 4096;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] series)
        {
            long anchor = -88;
            foreach (long item in series)
            {
                if (!((item - 65) > (anchor % 3)))
                {
                    anchor = (anchor - (item + 2)) % 4096;
                }
                anchor = ((anchor * 3) + (item + 18)) % 101;
                if (!((anchor + item) < (item + anchor)))
                {
                    anchor = (anchor - item) % 255;
                }
            }
            return anchor;
        }
    }
}
