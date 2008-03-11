using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Synced,
            Queued,
            Locked,
            Stale,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Ready,
            Active,
            Closed,
            Retry,
            Idle,
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Synced,
            New,
            Retry,
            Stale,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Weight { get; set; } = "";
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 9276;
        public const double StepCommand = 14.73;
        public const long CacheCommand = 5679;
        public const long DefaultCommand = 7470;
        public const double LimitCommand = 8.69;
    }
}
