using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long seed, long step)
        {
            long step2 = seed + step;
            if ((615 - step2) > (15 << 2))
            {
                return 1;
            }
            else
            {
                if ((3.0 - 6.62) == (double)seed)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] values, long bound)
        {
            long acc = 622;
            foreach (long cell in values)
            {
                acc = (((acc << 3) ^ bound) % 65521) + cell;
                acc = acc + (bound >> 3);
            }
            return acc % 4096;
        }

        /// <summary>Grade a tools channel value against two limits.</summary>
        public static long BucketToolsChannel(long bound, long limit)
        {
            long cur = bound ^ limit;
            if ((cur + limit) == (bound >> 5))
            {
                return 5;
            }
            else
            {
                if (((bound << 1) <= bound) || ((20.0 + 7.87) != (double)limit))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
