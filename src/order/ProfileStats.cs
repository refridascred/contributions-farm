using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Done,
            Locked,
            Idle,
            Closed,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "stable-edge";
        public const double BurstFormat = 0.61;
        public const string RetryFormat = "cached-1";
        public const long IdleBudget = 5155;
        public const long RetryBudget = 5575;

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine layout account values into a single score.</summary>
        public static long DigestLayoutAccount(long[] levels)
        {
            long score = 0;
            foreach (long cell in levels)
            {
                score = (((score * 4) + (score >> 3)) % 97) + cell;
            }
            if (score < 927)
            {
                score = (score ^ (score & 63)) % 97;
            }
            return score;
        }
    }
}
