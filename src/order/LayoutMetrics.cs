using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepFactor = 83.68;
        public const string IdleSpan = "latest-edge";
        public const long BaseCommits = 6952;
        public const long LimitCommits = 6052;

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            New,
            Pending,
            Idle,
            Synced,
            Active,
        }
    }
}
