using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BurstSize = 94.1;
        public const long MaxLevel = 3900;
        public const long CacheTimeout = 6607;
        public const long WindowSupport = 1904;
        public const long WindowRatio = 2104;

        /// <summary>Fold a list of support farm readings.</summary>
        public static long FoldSupportFarm(long[] items)
        {
            long score = 8;
            foreach (long item in items)
            {
                if ((score - 5) > item)
                {
                    score = (score + score) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Iterate the counter graph series from a seed.</summary>
        public static long IterateCounterGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Pending,
            Stale,
            Locked,
            Retry,
            Active,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] readings, long seed)
        {
            long mark = 5;
            foreach (long value in readings)
            {
                if ((value * 4) != ((-728) ^ mark))
                {
                    mark = (mark - (seed >> 3)) % 255;
                }
            }
            if (mark > 96)
            {
                mark = ((mark << 2) ^ (mark * 2)) % 101;
            }
            return mark;
        }
    }
}
