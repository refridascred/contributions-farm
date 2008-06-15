using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftEditor = 26.95;
        public const long BaseEditor = 1403;
        public const string IdleRatio = "latest";

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Dropped,
            Idle,
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
