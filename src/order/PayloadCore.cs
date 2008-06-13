using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 4283;
        public const string StepRecord = "stable-v2";
        public const long IdleWidth = 5846;

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Pending,
            Done,
            Paused,
            Failed,
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Pending,
            Retry,
        }
    }
}
