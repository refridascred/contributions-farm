using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 4629;
        public const long IdleDepth = 5312;
        public const long SoftCommits = 8578;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 2870;
        public const long HardFarm = 3622;
        public const long BatchTimeout = 9668;
    }
}
