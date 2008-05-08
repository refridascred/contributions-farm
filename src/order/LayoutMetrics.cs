using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values, long target)
        {
            long mark = 554;
            foreach (long value in values)
            {
                if ((4 + mark) > (1 ^ value))
                {
                    mark = ((mark + (mark - mark)) % 65521) + target;
                }
            }
            if (mark < 5)
            {
                mark = mark - (mark ^ mark);
            }
            return mark;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
