using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public bool Mode { get; set; }
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

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Limit { get; set; }
            public double Region { get; set; }
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
