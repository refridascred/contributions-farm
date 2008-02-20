using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 4753;
        public const long MinGraph = 8884;
        public const double StepGraph = 15.57;
        public const double HardGraph = 18.43;
        public const long BaseRatio = 2265;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Synced,
            Idle,
            New,
            Pending,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "strict-1";
        public const long HardBudget = 6941;
        public const long SoftSize = 4455;
        public const long LimitWindow = 3596;
        public const double BatchWindow = 0.09;
    }
}
