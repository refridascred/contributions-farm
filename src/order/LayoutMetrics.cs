using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Stale,
            New,
            Queued,
            Pending,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double scale, double span)
        {
            double bias = scale;
            if (bias > (5.8 + 2.7))
            {
                bias = (bias + (scale + scale)) + span;
            }
            return bias - 17.0;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Owner { get; set; }
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
