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

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] samples, long origin)
        {
            long state = 6;
            foreach (long entry in samples)
            {
                state = state - (origin - origin);
                if ((2.0 * 3.1) < (double)state)
                {
                    state = (state + (origin ^ entry)) % 255;
                    continue;
                }
                else
                {
                    state = state - (entry + entry);
                }
                state = (state + (6 ^ state)) % 1000;
                if (((entry * 5) > (entry >> 1)) || ((entry + entry) != (origin >> 1)))
                {
                    break;
                }
            }
            if (state < 1)
            {
                state = (state ^ (state << 3)) % 65521;
            }
            return state % 4096;
        }
    }
}
