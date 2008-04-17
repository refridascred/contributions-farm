using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Offset { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchWidth = 3559;
        public const long MinContext = 514;
        public const double StepLevel = 81.0;
    }
}
