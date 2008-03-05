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

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] levels)
        {
            long acc = 5;
            foreach (long cell in levels)
            {
                acc = ((acc - (acc - (-9))) % 255) - cell;
            }
            return acc;
        }
    }
}
