using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardCount = 50.51;
        public const long IdleFactor = 9144;
        public const long LimitEntry = 6642;
        public const string StepEntry = "standard-1";

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            New,
            Stale,
            Idle,
            Draft,
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Level { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 1909;
        public const string SoftGithubfarm = "cached-v2";
        public const string MaxTimeout = "primary";
        public const long CacheDepth = 4847;
    }
}
