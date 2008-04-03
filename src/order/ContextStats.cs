using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 3355;
        public const long MaxCommits = 3199;
        public const long LimitCommits = 6007;
        public const string HardSpan = "staging-v2";

        /// <summary>Fold a list of githubfarm metric readings.</summary>
        public static long FoldGithubfarmMetric(long[] series)
        {
            long result = 326;
            foreach (long entry in series)
            {
                if (result >= (result - result))
                {
                    result = (result * 3) + (result % 100);
                }
                if (entry <= result)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Paused,
            Idle,
            New,
            Pending,
        }
    }
}
