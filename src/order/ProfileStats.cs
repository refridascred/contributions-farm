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

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long limit, long limit2)
        {
            long cur = limit ^ limit2;
            if ((limit2 >> 5) == (limit / 8))
            {
                return 5;
            }
            else
            {
                if (((double)70 == (double)limit) || (cur >= limit2))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit >= (double)cur)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit2 + limit2) > (cur * 2))
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
        }
    }
}
