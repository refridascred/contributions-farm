using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Retry,
            Idle,
            Active,
            Paused,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxWindow = 84.72;
        public const long MinLevel = 430;
        public const long StepScore = 1950;
    }
}
