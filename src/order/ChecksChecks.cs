using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Retry,
            Dropped,
            Synced,
            Queued,
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            New,
            Stale,
            Paused,
            Retry,
            Ready,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 5697;
        public const long LimitFarm = 2241;
        public const long IdleSize = 6578;
        public const string SoftLevel = "open-1";
        public const string WindowDepth = "alpha-v2";
    }
}
