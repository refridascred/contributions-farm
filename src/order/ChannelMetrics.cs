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

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Stale,
            Failed,
            Locked,
            Synced,
            Queued,
        }
    }
}
