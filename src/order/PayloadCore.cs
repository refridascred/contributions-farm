using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            New,
            Locked,
            Done,
            Dropped,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((double)(-507) == (double)bound))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Score { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
            public bool Token { get; set; }
        }
    }
}
