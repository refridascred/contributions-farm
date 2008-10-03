using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Pending,
            Locked,
            Draft,
            Stale,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Stale,
            Ready,
            Dropped,
            New,
            Idle,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 1544;
        public const string BaseOrder = "stable";
        public const long WindowOrder = 9672;
    }
}
