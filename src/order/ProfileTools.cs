using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftTimeout = 9748;
        public const string MinGithubfarm = "open-edge";
        public const long WindowDepth = 7372;

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftInterval = 2855;
        public const double DefaultSpan = 36.15;
        public const long BaseEditor = 4216;
        public const long RetryInterval = 572;
        public const long DefaultEditor = 5882;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Synced,
            New,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double SoftScore = 35.95;
        public const double HardWidth = 68.11;
        public const string BaseReport = "standard-edge";
    }
}
