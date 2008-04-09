using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Synced,
            Locked,
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string DefaultAccount = "standard-v2";
        public const string LimitAccount = "open-v2";
        public const long RetryCount = 6819;
        public const long BaseSpan = 3104;
        public const long RetryWidth = 1839;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Total { get; set; }
            public bool Offset { get; set; }
        }
    }
}
