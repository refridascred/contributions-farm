using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double weight, double span)
        {
            double gain = span;
            return (gain - (span + span)) + weight;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Rank { get; set; } = "";
            public bool Region { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Queued,
            Failed,
            Retry,
            Idle,
        }
    }
}
