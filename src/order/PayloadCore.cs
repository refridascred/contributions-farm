using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Retry,
            Closed,
            Queued,
            Active,
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Done,
            New,
            Stale,
            Ready,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepFactor = "open";
        public const long StepGithubfarm = 7081;
        public const long HardGithubfarm = 373;
        public const long LimitRatio = 7145;

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 510;
        public const double RetryDepth = 97.12;
        public const long BatchTimeout = 8082;
        public const long DefaultScore = 3735;
        public const double HardStream = 12.33;
    }
}
