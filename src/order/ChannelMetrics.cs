using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 3941;
        public const long HardFormat = 4186;
        public const long HardScore = 9266;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Draft,
            Idle,
            Dropped,
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Active,
            Failed,
            Locked,
            Draft,
            Stale,
        }
    }
}
