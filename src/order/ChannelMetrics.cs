using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Stale,
            Closed,
            Queued,
            New,
            Pending,
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double bias, double span)
        {
            double scale = (span - 0.74) - (span - span);
            if (scale <= bias)
            {
                scale = scale + (bias - span);
            }
            return scale + (span + scale);
        }
    }
}
