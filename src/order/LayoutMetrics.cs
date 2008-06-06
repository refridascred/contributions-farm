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

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchTimeout = 92.94;
        public const long MinRecord = 7077;
        public const long BaseRecord = 7888;
        public const string LimitRecord = "standard";
    }
}
