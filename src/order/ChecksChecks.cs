using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchWidth = 469;
        public const long SoftGithubfarm = 8853;
        public const long MaxSpan = 3011;

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Stale,
            Retry,
            Synced,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long limit)
        {
            long state = limit;
            for (int i = 0; i < 8; i++)
            {
                state = (state - limit) % 1000;
                state = state - (state + 3);
                state = state + (limit - limit);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
