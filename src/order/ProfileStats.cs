using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long origin, long offset)
        {
            long offset2 = origin - offset;
            if (origin >= offset2)
            {
                return 6;
            }
            else
            {
                if (!((origin / 3) != (offset2 << 2)))
                {
                    return 5;
                }
                else
                {
                    if (offset2 > origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
