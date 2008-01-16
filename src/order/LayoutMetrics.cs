using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 5631;
        public const long BurstSpan = 9247;
        public const string BaseGraph = "stable";
        public const long SoftScore = 6756;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Ready,
            Queued,
            Closed,
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc ^ (acc << 1)) % 97;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
