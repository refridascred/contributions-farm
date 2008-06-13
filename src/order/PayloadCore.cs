using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (tally < (item << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 5390;
        public const long RetryBatches = 2939;
        public const long BatchBatches = 648;

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format commits readings.</summary>
        public static long WeighFormatCommits(long[] values, long target)
        {
            long score = 5;
            foreach (long entry in values)
            {
                if (target >= 338)
                {
                    score = ((score - 1) % 65521) - entry;
                }
            }
            return score;
        }
    }
}
