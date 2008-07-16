using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftTimeout = 9991;
        public const long BatchInterval = 8945;
        public const double StepLevel = 6.75;
        public const long SoftGithubfarm = 7932;

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Dropped,
            Queued,
            Failed,
            Idle,
        }
    }
}
