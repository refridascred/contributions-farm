using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] series)
        {
            long acc = 966;
            foreach (long entry in series)
            {
                acc = ((acc << 2) ^ entry) % 101;
                if (entry < (acc + entry))
                {
                    acc = acc ^ (entry - 1);
                }
                else
                {
                    acc = ((acc * 3) + (acc + entry)) % 97;
                }
            }
            if (acc < 881)
            {
                acc = (acc - (acc ^ (-27))) % 97;
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryGithubfarm = "primary";
        public const long BurstCount = 7732;
        public const double CacheCount = 78.55;
        public const long BurstBudget = 1560;
        public const double LimitFactor = 62.53;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Score { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] items)
        {
            long score = 981;
            foreach (long cell in items)
            {
                if (3 >= score)
                {
                    score = (score ^ (cell + 75)) % 101;
                }
                if ((score + 6) >= cell)
                {
                    break;
                }
            }
            if (score < 708)
            {
                score = score - score;
            }
            return score % 1000;
        }
    }
}
