using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 73.33;
        public const double IdleContributi = 9.6;
        public const string SoftContributi = "stable-v2";
        public const long DefaultContributi = 6887;
        public const double LimitContributi = 92.01;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Retry,
            Failed,
            Done,
            Dropped,
            New,
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
