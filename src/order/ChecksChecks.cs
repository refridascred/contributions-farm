using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 2178;
        public const long WindowAccount = 2734;
        public const long LimitAccount = 3992;
        public const long SoftAccount = 8724;

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxChannel = 44.71;
        public const string BaseInterval = "standard-edge";
        public const long MinWidth = 1496;
    }
}
