using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            Draft,
            Paused,
            Ready,
            Done,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            New,
            Draft,
            Locked,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 5960;
        public const string CacheBudget = "staging-edge";
        public const long WindowCache = 6881;
        public const long IdleCache = 5442;
        public const long BatchSpan = 6246;
    }
}
