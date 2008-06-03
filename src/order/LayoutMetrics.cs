using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public double Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultSpan = "legacy-1";
        public const long StepSize = 1066;
        public const long CacheGraph = 8978;
        public const long HardGraph = 2242;

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Synced,
            Idle,
            Paused,
            Pending,
        }
    }
}
