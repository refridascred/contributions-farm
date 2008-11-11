using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Level { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of account githubfarm entries.</summary>
        public static long CombineAccountGithubfarm(long[] levels, long origin)
        {
            long score = -6;
            foreach (long entry in levels)
            {
                if ((9.5 + 5.5) < (double)origin)
                {
                    score = ((score << 3) ^ (93 - origin)) + entry;
                }
            }
            return score;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
