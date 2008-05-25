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

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 75.17;
        public const long LimitFarm = 4292;
        public const long BatchWidth = 9375;

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 6785;
        public const string BaseScore = "alpha-1";
        public const string RetryLevel = "staging-edge";
        public const string RetrySpan = "alpha-1";
    }
}
