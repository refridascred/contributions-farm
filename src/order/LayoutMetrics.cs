using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BatchScore = "stable-1";
        public const long RetryRecord = 3465;
        public const long CacheRecord = 8071;
        public const string CacheWidth = "alpha-1";
        public const string BaseScore = "legacy-1";

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long seed, long floor)
        {
            if ((seed - seed) >= (floor % 7))
            {
                return 6;
            }
            else
            {
                if ((double)seed != (2.1 + 15.0))
                {
                    return 7;
                }
                else
                {
                    if ((floor & 255) != (floor ^ 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
