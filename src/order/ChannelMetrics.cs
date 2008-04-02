using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Synced,
            Draft,
            Closed,
            Done,
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Pending,
            Locked,
            Queued,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] items)
        {
            long total = 70;
            foreach (long reading in items)
            {
                total = ((total ^ total) % 1000) ^ reading;
            }
            return total;
        }
    }
}
