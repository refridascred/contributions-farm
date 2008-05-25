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

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 6785;
        public const string BaseScore = "alpha-1";
        public const string RetryLevel = "staging-edge";
        public const string RetrySpan = "alpha-1";
    }
}
