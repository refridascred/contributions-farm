using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleInterval = 6391;
        public const long BurstScore = 500;
        public const double WindowPayload = 28.49;

        /// <summary>Define account limits and defaults.</summary>
        public const long HardSize = 3893;
        public const long MaxAccount = 1802;
        public const long WindowAccount = 3833;
        public const double StepAccount = 67.41;
        public const long HardAccount = 2169;

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }
    }
}
