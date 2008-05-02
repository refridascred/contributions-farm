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

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
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
