using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double WindowSpan = 77.7;
        public const long SoftCount = 6753;
        public const long DefaultReport = 7441;
        public const double WindowReport = 63.02;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            New,
            Stale,
            Idle,
            Draft,
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Weight { get; set; }
            public double Score { get; set; }
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
