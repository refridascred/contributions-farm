using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Score { get; set; }
            public string Rank { get; set; } = "";
            public long Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepStats = "standard-1";
        public const long MinStats = 6520;
        public const long BatchInterval = 2965;
        public const long HardLevel = 353;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinInterval = 742;
        public const long DefaultFactor = 13;
        public const double WindowTimeout = 6.89;
        public const double MinCount = 50.22;
    }
}
