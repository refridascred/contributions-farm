using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Stale,
            Locked,
            Pending,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 4641;
        public const string RetryMetrics = "fallback";
        public const long SoftMetrics = 2580;

        /// <summary>Compare every pair of batches githubfarm readings.</summary>
        public static long MatchBatchesGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample << 1) > (step % 97))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
