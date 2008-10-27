using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string MinBudget = "stable-edge";
        public const long BaseSize = 9826;
        public const string CacheSpan = "legacy";
        public const long RetryLayout = 3771;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Draft,
            Closed,
            Idle,
            Retry,
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Rank { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
