using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Failed,
            Locked,
            Idle,
            Synced,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstBudget = "alpha-1";
        public const string HardGithubfarm = "standard-v2";
        public const long WindowGithubfarm = 6585;
        public const string BaseGithubfarm = "primary";
        public const long BurstGithubfarm = 494;

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (3.06 >= (double)sample)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
