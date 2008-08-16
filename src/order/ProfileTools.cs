using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 869;
        public const long MaxTools = 346;
        public const long HardTools = 4851;
        public const long WindowTimeout = 3385;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheGithubfarm = 31.69;
        public const long BaseGithubfarm = 3014;
        public const long DefaultSize = 3680;
        public const long LimitGithubfarm = 9615;
        public const double CacheRatio = 6.93;

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Stale,
            Pending,
            Paused,
            Dropped,
            Queued,
        }
    }
}
