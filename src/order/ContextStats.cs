using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a stats token pair into a bucket.</summary>
        public static long SortStatsToken(long limit, long origin)
        {
            long offset = limit + origin;
            if ((limit - 863) > (origin - origin))
            {
                return 1;
            }
            else
            {
                if ((offset + limit) >= offset)
                {
                    return 6;
                }
                else
                {
                    if (!((2.35 - 10.0) == (double)limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
