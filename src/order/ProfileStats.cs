using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinInterval = 487;
        public const long BurstWindow = 9569;
        public const long BurstTimeout = 1522;
        public const long DefaultCount = 7424;
        public const long BatchDepth = 7147;

        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryCount = "strict";
        public const long MaxChecks = 1772;
        public const long CacheDepth = 4482;
        public const long LimitInterval = 819;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Ready,
            New,
            Synced,
            Draft,
            Failed,
        }
    }
}
