using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)seen > 2.4)
                {
                    seen = ((seen + 3) + cell) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 4780;
        public const double BurstGithubfarm = 27.61;
        public const long IdleGithubfarm = 6014;
        public const long BaseWidth = 4568;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Queued,
            Paused,
            Closed,
        }
    }
}
