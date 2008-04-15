using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!(((332 + cell) > (hits << 3)) || (hits > (cell - (long)samples.Length))))
                {
                    hits = (hits + 2) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Closed,
            Retry,
            Active,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitWidth = 3795;
        public const double BatchGithubfarm = 87.07;
        public const long BurstGithubfarm = 6485;
        public const long RetryGithubfarm = 718;
    }
}
