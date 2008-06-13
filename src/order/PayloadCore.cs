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

        /// <summary>Rank cluster already input into a small class.</summary>
        public static long GradeClusterAlready(long target, long origin)
        {
            long bound = target ^ origin;
            if (((5.8 + 1.8) > (double)target) && ((double)204 != (double)bound))
            {
                return 0;
            }
            else
            {
                if ((origin + target) >= (target % 7))
                {
                    return 1;
                }
                else
                {
                    if ((origin + 397) != (bound & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((3 > (origin ^ bound)) && ((19.0 + 7.0) >= (double)target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
