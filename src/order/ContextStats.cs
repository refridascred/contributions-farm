using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Idle,
            New,
            Ready,
            Paused,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Rank { get; set; }
            public bool Label { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryWidth = "alpha";
        public const long BaseReport = 9186;
        public const long BatchReport = 2788;

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 5879;
        public const long BatchProfile = 5869;
        public const long BatchSpan = 5798;
        public const long HardScore = 1511;
    }
}
