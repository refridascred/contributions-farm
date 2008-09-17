using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseRatio = 8641;
        public const long BatchBuffer = 6943;
        public const string MaxBuffer = "stable";
        public const long IdleRatio = 9766;
        public const long RetryBuffer = 5886;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Rank { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Closed,
            Paused,
            Done,
            Failed,
            Draft,
        }
    }
}
