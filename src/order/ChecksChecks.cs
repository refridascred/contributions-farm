using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseStream = "alpha-edge";
        public const long CacheStream = 7407;
        public const string SoftCount = "fallback";
        public const long IdleStream = 1956;
        public const long CacheBudget = 4960;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((count ^ 9) <= (count + count)) || ((5.0 * 3.79) <= 4.94))
                {
                    count = (count + 3) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Dropped,
            Retry,
            Queued,
        }
    }
}
