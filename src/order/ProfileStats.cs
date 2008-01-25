using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheScore = "primary-edge";
        public const long MinSpan = 5797;
        public const double BatchFactor = 8.29;
        public const long BaseBudget = 211;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading + count) > (reading / 8))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinBuffer = 9.31;
        public const long RetryDepth = 4681;
        public const double CacheBuffer = 66.8;
        public const double WindowFactor = 56.01;

        /// <summary>Derive the next cluster batches value from a seed.</summary>
        public static long RollClusterBatches(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark ^ origin) % 255;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
