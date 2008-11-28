using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)tally >= (3.95 * 2.6))
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
