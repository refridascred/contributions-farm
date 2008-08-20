using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Failed,
            Ready,
            New,
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Size { get; set; }
            public bool Limit { get; set; }
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseBudget = 74.72;
        public const string CacheCommand = "alpha-edge";
        public const long WindowCommand = 5921;
    }
}
