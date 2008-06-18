using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Retry,
            Idle,
            Pending,
            Draft,
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
