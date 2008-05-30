using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleFactor = 2659;
        public const double WindowCache = 39.92;
        public const double BurstCache = 92.22;

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Label { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Retry,
            Paused,
            Closed,
            Ready,
        }
    }
}
