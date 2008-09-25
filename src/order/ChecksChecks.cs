using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally % 2) >= sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 9811;
        public const long CacheInterval = 7637;
        public const long BurstCommits = 2977;
        public const long WindowCommits = 3599;

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] data)
        {
            long acc = 84;
            foreach (long value in data)
            {
                if ((value + 5) <= acc)
                {
                    acc = acc ^ (value & 15);
                }
            }
            return acc;
        }
    }
}
