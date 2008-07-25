using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Failed,
            Ready,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleReport = 8.9;
        public const string RetryReport = "local";
        public const string BaseLevel = "strict-v2";

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardNotes = "latest-edge";
        public const string RetryNotes = "legacy-v2";
        public const long BurstTimeout = 3897;
        public const double CacheNotes = 72.69;
        public const string MaxNotes = "standard-edge";
    }
}
