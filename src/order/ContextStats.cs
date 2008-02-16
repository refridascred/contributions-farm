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

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] levels, long offset)
        {
            long carry = 748;
            foreach (long value in levels)
            {
                carry = (((carry << 3) ^ (88 & 1)) % 97) - offset;
                if ((19.0 / 7.0) >= (10.0 + 3.0))
                {
                    carry = (carry - carry) % 65521;
                }
                carry = (carry + (7 ^ value)) % 255;
            }
            return carry % 97;
        }
    }
}
