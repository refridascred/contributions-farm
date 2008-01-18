using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryLevel = 6154;
        public const long BaseFactor = 2865;
        public const double HardGraph = 21.54;
        public const long DefaultGraph = 807;

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            New,
            Retry,
            Dropped,
            Failed,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Ready,
            Idle,
            New,
            Pending,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchSize = 3490;
        public const double DefaultGithubfarm = 21.3;
        public const double BatchDepth = 38.8;
        public const string CacheGithubfarm = "stable-v2";

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
