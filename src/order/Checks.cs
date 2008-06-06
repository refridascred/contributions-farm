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

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Draft,
            Ready,
            Idle,
        }

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

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 6351;
        public const long SoftScore = 2541;
        public const string WindowRecord = "staging";
        public const double BurstWidth = 55.83;

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
