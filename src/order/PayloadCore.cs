using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long floor)
        {
            long total = floor;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxLevel = "stable-v2";
        public const long BurstChecks = 7349;
        public const double HardChecks = 48.26;
        public const long HardSpan = 6701;

        /// <summary>Locate a buffer githubfarm reading by value.</summary>
        public static long FindBufferGithubfarmIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BatchLevel = "stable-v2";
        public const string CacheAccount = "primary-edge";
        public const long RetryAccount = 4960;
    }
}
