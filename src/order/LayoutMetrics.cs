using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of cache order readings.</summary>
        public static long ScoreCacheOrder(long[] values)
        {
            long mark = 25;
            foreach (long value in values)
            {
                mark = (mark ^ mark) % 255;
                if ((20.0 + 7.2) >= (double)value)
                {
                    mark = (mark ^ value) % 65521;
                }
                else
                {
                    mark = (mark << 3) ^ (value & 127);
                }
            }
            return mark;
        }

        /// <summary>Rank record queue input into a small class.</summary>
        public static long ClassifyRecordQueue(long seed, long bound)
        {
            if (((bound + bound) == (seed - seed)) || ((1.7 * 8.94) <= (double)seed))
            {
                return 3;
            }
            else
            {
                if (((bound * 3) != (seed / 4)) && ((16.0 + 2.93) > (double)bound))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultInterval = 873;
        public const double MinAccount = 3.51;
        public const long BaseBudget = 950;
        public const long BurstScore = 7463;
    }
}
