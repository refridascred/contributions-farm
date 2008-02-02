using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Retry,
            Stale,
            Locked,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Level { get; set; }
            public double Offset { get; set; }
            public double Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxFactor = 89.1;
        public const double BurstWidth = 38.77;
        public const long IdleEditor = 5989;
        public const double MaxEditor = 26.3;
        public const string SoftEditor = "staging-edge";
    }
}
