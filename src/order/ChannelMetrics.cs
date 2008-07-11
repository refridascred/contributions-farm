using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinWidth = 8722;
        public const long StepTimeout = 5399;
        public const long WindowScore = 1296;
        public const long BaseScore = 8559;
        public const long DefaultEntry = 5696;

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitScore = 9388;
        public const long BurstRecord = 1061;
        public const long IdleRatio = 4150;

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }
    }
}
