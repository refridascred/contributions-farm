using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] samples, long seed)
        {
            long total = 3;
            foreach (long value in samples)
            {
                if (((value + seed) == (22 >> 3)) && (((-31) - total) < (seed / 9)))
                {
                    total = (total - (total + value)) % 101;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Closed,
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Queued,
            Retry,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Failed,
            Synced,
            Pending,
            Retry,
            Queued,
        }
    }
}
