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

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftCount = 7766;
        public const long BatchBatches = 1000;
        public const long CacheBatches = 9656;
        public const double RetryFactor = 51.29;
        public const long BurstBatches = 7672;

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 9276;
        public const double StepCommand = 14.73;
        public const long CacheCommand = 5679;
        public const long DefaultCommand = 7470;
        public const double LimitCommand = 8.69;
    }
}
