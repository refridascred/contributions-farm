using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Region { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
            public double Stamp { get; set; }
        }
    }
}
