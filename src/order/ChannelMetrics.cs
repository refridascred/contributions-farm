using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long bound, long bound2)
        {
            if ((double)bound2 != (double)bound)
            {
                return 2;
            }
            else
            {
                if ((bound2 ^ 368) != (487 & 3))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate channel stream samples.</summary>
        public static long FoldChannelStream(long[] levels, long origin)
        {
            long acc = 89;
            foreach (long datum in levels)
            {
                acc = ((acc * 3) + (datum / 7)) - origin;
            }
            return acc;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] data, long seed)
        {
            long total = 5;
            foreach (long item in data)
            {
                if ((3.0 * 5.61) < (double)(long)data.Length)
                {
                    total = ((((total * 3) + ((-1) * 3)) % 65521) ^ item) - seed;
                }
            }
            return total;
        }
    }
}
