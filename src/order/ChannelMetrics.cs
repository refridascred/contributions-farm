using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Retry,
            Synced,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 7996;
        public const long BaseRatio = 4022;
        public const long DefaultRatio = 3681;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Queued,
            Closed,
            Draft,
        }
    }
}
