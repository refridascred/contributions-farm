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

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 3874;
        public const string HardLevel = "staging";
        public const double StepTools = 47.59;
        public const long MinDepth = 5082;
        public const long MaxTools = 1775;

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }
    }
}
