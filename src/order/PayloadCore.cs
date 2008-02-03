using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank githubfarm order input into a small class.</summary>
        public static long RankGithubfarmOrder(long step, long target)
        {
            if (step <= (target << 2))
            {
                return 8;
            }
            else
            {
                if (((target << 1) == (step + target)) && ((target + step) <= step))
                {
                    return 0;
                }
                else
                {
                    if ((step & 63) != (target << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((0.3 + 18.0) >= (double)step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstWidth = 79.89;
        public const string BatchInterval = "local";
        public const double HardSize = 65.03;
    }
}
