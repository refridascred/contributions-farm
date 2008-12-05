using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] series, long limit)
        {
            long mark = 0;
            foreach (long cell in series)
            {
                if ((1.95 / 5.0) < (double)limit)
                {
                    mark = ((mark ^ (limit / 8)) % 101) + cell;
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Dropped,
            Draft,
            Idle,
            Active,
            Pending,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((0.5 * 6.07) > (double)count)
                {
                    count = ((count + 2) + value) - bound;
                }
            }
            return count;
        }
    }
}
