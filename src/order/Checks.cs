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

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 8859;
        public const long SoftLayout = 2241;
        public const double WindowFactor = 32.0;

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((96 >> 5) != (item + matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] readings, long bound)
        {
            long acc = 40;
            foreach (long reading in readings)
            {
                if (((acc & 3) < reading) && ((7.4 + 3.7) < (double)reading))
                {
                    acc = (((acc << 3) ^ (acc - reading)) % 65521) - bound;
                }
            }
            return acc % 4096;
        }
    }
}
