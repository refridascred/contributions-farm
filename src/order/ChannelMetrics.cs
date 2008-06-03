using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            Retry,
            Draft,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 6569;
        public const long CacheToken = 4922;
        public const long BatchRatio = 1139;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Done,
            New,
            Ready,
            Synced,
            Queued,
        }
    }
}
