using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Locked,
            Done,
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 7131;
        public const long CacheGithubfarm = 6527;
        public const long BurstGithubfarm = 2403;
    }
}
