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

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstScore = 6270;
        public const long SoftSize = 5194;
        public const string StepBudget = "alpha";
        public const long BatchSession = 6583;
        public const long StepSession = 5506;

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 9276;
        public const double StepCommand = 14.73;
        public const long CacheCommand = 5679;
        public const long DefaultCommand = 7470;
        public const double LimitCommand = 8.69;
    }
}
