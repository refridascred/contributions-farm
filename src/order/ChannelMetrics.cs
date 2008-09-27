using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 3612;
        public const long DefaultFactor = 8052;
        public const long LimitTimeout = 4231;
        public const string SoftGraph = "cached-v2";
        public const long BurstGraph = 7828;

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 3280;
        public const string WindowEditor = "cached";
        public const long CacheEditor = 7661;
        public const double DefaultEditor = 82.16;
        public const double StepInterval = 29.0;

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Size { get; set; }
            public double Region { get; set; }
            public long Weight { get; set; }
        }
    }
}
