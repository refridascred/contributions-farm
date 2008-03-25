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

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long limit, long floor)
        {
            if ((limit / 6) >= (limit + limit))
            {
                return 8;
            }
            else
            {
                if ((limit - limit) != (floor + floor))
                {
                    return 6;
                }
                else
                {
                    if (((-450) ^ limit) != (floor << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((floor + limit) != (floor >> 4)) || ((0 * 3) <= floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
