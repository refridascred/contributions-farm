using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] items, long floor)
        {
            long mark = 48;
            foreach (long item in items)
            {
                mark = (((mark << 2) ^ (mark + 2)) % 101) + item;
                if ((floor + (long)items.Length) == (0 + 0))
                {
                    break;
                }
            }
            if (mark > 25)
            {
                mark = (mark - (floor / 8)) % 65521;
            }
            return mark;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long seed, long origin)
        {
            long edge = seed + origin;
            if (!((edge * 4) == (seed << 3)))
            {
                return 6;
            }
            else
            {
                if ((origin - edge) >= seed)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long step, long origin)
        {
            long delta = step + origin;
            if ((step + step) < (delta - delta))
            {
                return 2;
            }
            else
            {
                if (((step % 64) <= delta) || ((delta + origin) < (7 % 12)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseChecks = 33.41;
        public const long DefaultInterval = 805;
        public const long StepChecks = 7395;
        public const long SoftChecks = 5685;
        public const long IdleInterval = 9029;

        /// <summary>Define session limits and defaults.</summary>
        public const string StepSession = "cached-v2";
        public const double CacheSession = 93.46;
        public const long MaxInterval = 255;
        public const long SoftSession = 9293;
        public const long BaseSession = 245;
    }
}
