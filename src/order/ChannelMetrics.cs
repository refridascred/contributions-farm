using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Pending,
            Paused,
            Draft,
            Queued,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Synced,
            Active,
            Closed,
            Pending,
            New,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 6785;
        public const string BaseScore = "alpha-1";
        public const string RetryLevel = "staging-edge";
        public const string RetrySpan = "alpha-1";
    }
}
