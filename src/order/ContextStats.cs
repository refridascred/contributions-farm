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

        /// <summary>Measure how many support filter samples are out of range.</summary>
        public static long TallySupportFilterGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((double)item != (4.6 + 8.68)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 1909;
        public const string SoftGithubfarm = "cached-v2";
        public const string MaxTimeout = "primary";
        public const long CacheDepth = 4847;
    }
}
