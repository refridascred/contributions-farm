using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Ready,
            Done,
            Draft,
            Pending,
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Queued,
            Draft,
            Retry,
            Dropped,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryToken = 33.34;
        public const long WindowInterval = 2527;
        public const long SoftToken = 5559;
        public const long SoftTimeout = 5650;

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleWidth = 6202;
        public const long RetryTimeout = 694;
        public const long SoftRatio = 8964;
        public const long DefaultCommand = 7454;

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
