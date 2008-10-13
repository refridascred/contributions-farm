using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Dropped,
            Locked,
            Pending,
            Ready,
            Draft,
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
