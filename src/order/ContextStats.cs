using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (bound <= (matches + 27))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Dropped,
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Dropped,
            Failed,
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
