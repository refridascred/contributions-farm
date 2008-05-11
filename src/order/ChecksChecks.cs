using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSize = 6625;
        public const double LimitWidth = 91.77;
        public const long BaseSize = 1504;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            Closed,
            Pending,
            Queued,
        }
    }
}
