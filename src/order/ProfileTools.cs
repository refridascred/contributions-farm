using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Region { get; set; } = "";
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepDepth = 2407;
        public const long MinWidth = 6952;
        public const string DefaultRatio = "open";
        public const double DefaultChannel = 49.71;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "cached";
        public const long IdleGithubfarm = 5450;
        public const string SoftTimeout = "latest";
        public const string LimitScore = "stable";

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Mode { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
