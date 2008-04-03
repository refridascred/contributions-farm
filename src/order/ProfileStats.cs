using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long floor, long limit)
        {
            long span = floor + limit;
            if (619 > (span >> 3))
            {
                return 5;
            }
            else
            {
                if ((double)span == (2.8 * 4.0))
                {
                    return 6;
                }
                else
                {
                    if ((limit ^ floor) <= (span - 843))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 3238;
        public const double BurstFactor = 9.55;
        public const long HardSize = 6844;
        public const long SoftCounter = 7063;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long target, long step)
        {
            if ((step * 2) == (target % 60))
            {
                return 3;
            }
            else
            {
                if (!((9 + step) <= (target / 6)))
                {
                    return 0;
                }
                else
                {
                    if ((target & 15) < step)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step & 31) < (step * 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine context window values into a single score.</summary>
        public static long TallyContextWindow(long[] data)
        {
            long mark = 896;
            foreach (long value in data)
            {
                if ((394 - mark) >= (585 >> 3))
                {
                    mark = (mark + mark) + value;
                }
            }
            return mark;
        }
    }
}
