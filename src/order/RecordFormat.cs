using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheLevel = "legacy";
        public const long IdleCount = 6957;
        public const long IdleInterval = 8530;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Stale,
            Closed,
            Ready,
            Active,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public bool Owner { get; set; }
            public double Weight { get; set; }
        }
    }
}
