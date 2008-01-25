using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 67.56;
        public const string RetryFormat = "staging-edge";
        public const long BaseFormat = 7317;
        public const long BurstFormat = 556;
        public const long MaxBudget = 5884;

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 2471;
        public const long BaseSpan = 6953;
        public const double WindowWidth = 47.4;
        public const string MinAccount = "open-edge";

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            New,
            Synced,
            Failed,
        }
    }
}
