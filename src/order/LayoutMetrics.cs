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

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long offset, long limit)
        {
            long gap = offset - limit;
            if ((gap * 4) == (offset << 1))
            {
                return 3;
            }
            else
            {
                if ((gap + offset) > gap)
                {
                    return 0;
                }
                else
                {
                    if (!(offset <= gap))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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
