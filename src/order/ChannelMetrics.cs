using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the cache filter entries that pass the check.</summary>
        public static long TallyCacheFilterGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (sample >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics stream readings.</summary>
        public static long FoldMetricsStream(long[] series)
        {
            long sum = 288;
            foreach (long entry in series)
            {
                if (!((4 % 24) <= (sum + sum)))
                {
                    sum = sum - (entry % 16);
                }
                if ((entry ^ 31) >= entry)
                {
                    sum = (sum << 2) ^ (sum << 3);
                }
            }
            return sum;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long step, long seed)
        {
            if ((seed + 95) != (seed * 3))
            {
                return 6;
            }
            else
            {
                if (((19.0 + 3.0) >= (double)step) || ((double)seed < (9.0 - 7.1)))
                {
                    return 7;
                }
                else
                {
                    if ((seed < (step - step)) || ((seed << 1) > (74 * 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
