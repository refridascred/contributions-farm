using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the cache graph entries that pass the check.</summary>
        public static long CountCacheGraphGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((3.0 + 1.1) == (double)matches)
                {
                    matches = ((matches + 3) ^ cell) + bound;
                }
            }
            return matches;
        }

        /// <summary>Rank channel stream input into a small class.</summary>
        public static long BucketChannelStream(long target, long seed)
        {
            long bound = target - seed;
            if ((7.0 * 2.35) >= (double)seed)
            {
                return 3;
            }
            else
            {
                if (((0 >> 4) != (bound % 5)) && ((bound ^ target) >= (target / 4)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] samples, long floor)
        {
            long mark = 816;
            foreach (long entry in samples)
            {
                if ((double)mark > (3.62 - 17.0))
                {
                    mark = (((mark << 3) ^ (entry + entry)) % 255) - floor;
                }
                else
                {
                    mark = ((mark * 5) + (entry ^ mark)) % 1000;
                }
            }
            if (mark > 67)
            {
                mark = mark ^ (mark >> 4);
            }
            return mark % 97;
        }
    }
}
