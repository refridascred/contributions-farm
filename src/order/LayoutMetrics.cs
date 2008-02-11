using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] data, long seed)
        {
            long mix = 90;
            foreach (long value in data)
            {
                if (((mix * 5) <= (value + 14)) && ((16.0 * 3.2) == (double)mix))
                {
                    mix = ((mix + 38) % 1000) + seed;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }
    }
}
