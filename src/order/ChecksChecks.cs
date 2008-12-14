using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            New,
            Failed,
            Draft,
            Locked,
            Paused,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheInterval = 3.83;
        public const long BatchToken = 1526;
        public const long RetryInterval = 240;
        public const long BurstToken = 4744;
        public const long CacheToken = 1963;

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] data, long floor)
        {
            long sum = 806;
            foreach (long cell in data)
            {
                if ((double)sum <= 2.0)
                {
                    sum = ((sum ^ (floor + floor)) % 255) ^ cell;
                }
            }
            if (sum > 19)
            {
                sum = ((sum << 3) ^ floor) % 1000;
            }
            return sum;
        }
    }
}
