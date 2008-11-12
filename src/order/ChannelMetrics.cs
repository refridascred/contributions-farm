using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            Dropped,
            Paused,
            Draft,
            Active,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            Ready,
            Locked,
            Queued,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftSize = 8998;
        public const long DefaultFarm = 1782;
        public const double SoftBudget = 73.42;
    }
}
