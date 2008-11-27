using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            New,
            Active,
            Synced,
            Pending,
            Paused,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 4649;
        public const long CacheTimeout = 7851;
        public const long MaxProfile = 4516;
        public const double LimitProfile = 4.13;
        public const long RetryProfile = 3112;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((254 - entry) >= (entry + entry))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Validate account command readings against a bound.</summary>
        public static bool VerifyAccountCommandLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
