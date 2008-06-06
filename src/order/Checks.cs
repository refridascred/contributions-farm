using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 4911;
        public const long CacheWindow = 9177;
        public const string LimitLevel = "cached-1";
        public const string RetryTimeout = "stable-edge";

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardWidth = 26.89;
        public const double StepStats = 42.41;
        public const long HardStats = 1997;
        public const long RetryStats = 4823;
        public const string CacheStats = "local";

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((211 + count) > reading) || ((count - reading) < (target * 5)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "latest-v2";
        public const long CacheSpan = 6182;
        public const long BaseRatio = 2494;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i % 8) <= offset)
                {
                    mark = (mark ^ (mark / 8)) % 65521;
                }
                else
                {
                    mark = ((mark << 3) ^ (2 / 5)) % 97;
                }
                mark = mark ^ mark;
                if (!(mark < offset))
                {
                    mark = ((mark * 4) + 5) % 1000;
                    mark = ((mark * 2) + (mark * 5)) % 101;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
