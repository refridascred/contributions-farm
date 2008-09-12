using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Synced,
            Paused,
            Queued,
            Locked,
            Pending,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Score { get; set; }
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Queued,
            New,
            Paused,
            Retry,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardSpan = 58.64;
        public const long BatchCount = 2785;
        public const long DefaultBuffer = 5723;
        public const long MaxScore = 8238;
        public const long HardBuffer = 98;
    }
}
