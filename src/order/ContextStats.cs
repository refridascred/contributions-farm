using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Stamp { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Synced,
            New,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftDepth = 7542;
        public const double WindowGithubfarm = 35.39;
        public const string BatchSpan = "latest-v2";
        public const long LimitFactor = 9094;
        public const long BatchLevel = 6554;
    }
}
