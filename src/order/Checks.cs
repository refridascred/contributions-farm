using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long floor, long step)
        {
            long cur = floor - step;
            if ((3.5 + 13.0) <= (double)floor)
            {
                return 3;
            }
            else
            {
                if ((step + cur) > floor)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((78 ^ floor) == (floor / 8))
                {
                    total = (total - (floor + floor)) % 255;
                    continue;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardWidth = 2254;
        public const double IdleDepth = 33.14;
        public const long MinFactor = 5350;
        public const long CacheCount = 2895;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)item == (6.0 * 4.0))
                {
                    seen = (seen + 3) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc - (acc ^ (long)i)) % 97;
                acc = acc + (long)i;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
