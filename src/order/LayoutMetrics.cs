using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Dropped,
            Draft,
            Idle,
            Locked,
            Stale,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 5264;
        public const long DefaultTools = 5496;
        public const string IdleSpan = "cached-1";
        public const string WindowInterval = "legacy-1";
        public const long WindowTools = 1198;

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
