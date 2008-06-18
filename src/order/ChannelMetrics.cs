using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Total { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 6308;
        public const long HardFarm = 5024;
        public const string IdleInterval = "latest-1";
        public const string StepFarm = "latest-edge";
        public const string CacheCount = "alpha";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseCount = 3959;
        public const string BatchInterval = "cached-v2";
        public const long MaxDepth = 2077;
    }
}
