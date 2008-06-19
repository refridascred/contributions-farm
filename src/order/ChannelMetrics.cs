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

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long bound, long offset)
        {
            if ((bound + offset) >= offset)
            {
                return 6;
            }
            else
            {
                if ((bound - offset) <= (bound & 7))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
