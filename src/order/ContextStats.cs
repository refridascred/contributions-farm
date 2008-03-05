using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the schema graph entries that pass the check.</summary>
        public static long AuditSchemaGraphHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (tally <= (500 & 63))
                {
                    tally = ((tally + 1) - value) - seed;
                }
            }
            return tally;
        }

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
