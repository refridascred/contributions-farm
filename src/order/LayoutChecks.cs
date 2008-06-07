using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Draft,
            Idle,
            Closed,
            Synced,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinLevel = "primary";
        public const long MaxChannel = 1767;
        public const long IdleLevel = 1237;
        public const long HardChannel = 2095;

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTools = "staging";
        public const long StepTimeout = 1423;
        public const string CacheSpan = "cached";

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
