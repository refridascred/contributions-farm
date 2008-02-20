using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowTools = 57.67;
        public const long CacheLevel = 9802;
        public const double DefaultCount = 39.99;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long limit)
        {
            long bound = floor + limit;
            if ((floor % 3) >= floor)
            {
                return 1;
            }
            else
            {
                if (floor <= (limit * 4))
                {
                    return 2;
                }
                else
                {
                    if (!((double)floor > (1.4 + 8.9)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor & 31) > (bound * 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] items)
        {
            long mark = 10;
            foreach (long item in items)
            {
                if ((double)item <= (6.5 / 2.0))
                {
                    mark = ((mark << 3) ^ mark) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((seen + target) > target) || (target > (65 & 31)))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}
