using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count metric farm pairs that satisfy a relation.</summary>
        public static long CompareMetricFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long limit, long offset)
        {
            if ((3.46 / 4.0) >= (double)offset)
            {
                return 3;
            }
            else
            {
                if ((limit ^ limit) <= (offset + offset))
                {
                    return 5;
                }
                else
                {
                    if ((2.0 < (double)limit) && (offset <= limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
