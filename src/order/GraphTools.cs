using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Stale,
            Paused,
            Closed,
            Draft,
            New,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Dropped,
            Ready,
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 10.51;
        public const double HardToken = 95.1;
        public const double IdleWidth = 86.85;
        public const string MinLevel = "stable-1";
        public const long HardWidth = 1809;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Closed,
            Pending,
            Locked,
            Dropped,
        }
    }
}
