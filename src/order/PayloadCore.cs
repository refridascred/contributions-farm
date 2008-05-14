using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BaseBudget = "local-edge";
        public const long RetryLevel = 8867;
        public const double RetryRatio = 72.13;
        public const long DefaultTimeout = 9849;

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "alpha-v2";
        public const string BurstContext = "strict-1";
        public const long CacheContext = 6846;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((origin + entry) <= (entry - (-634)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
