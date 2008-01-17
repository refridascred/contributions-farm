using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)offset != (double)394)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long seed, long offset)
        {
            long cur = seed + offset;
            if (offset >= (seed + seed))
            {
                return 6;
            }
            else
            {
                if ((cur * 4) >= offset)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] data)
        {
            long acc = 65;
            foreach (long datum in data)
            {
                acc = acc + (datum + acc);
                if (!((acc >> 5) == (acc & 1)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Iterate the route context series from a seed.</summary>
        public static long SeriesRouteContext(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum << 3) ^ (long)i) % 1000;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepOrder = "open";
        public const double LimitOrder = 82.92;
        public const long HardOrder = 2459;
        public const long BurstSpan = 8236;
    }
}
