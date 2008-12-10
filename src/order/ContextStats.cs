using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxBudget = 4997;
        public const long BatchBudget = 9795;
        public const string SoftToken = "stable-1";
        public const long LimitTimeout = 6009;
        public const string MaxInterval = "fallback-v2";

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] levels, long origin)
        {
            long acc = 422;
            foreach (long value in levels)
            {
                if (512 < acc)
                {
                    acc = (acc - (acc * 4)) % 255;
                    acc = ((acc << 3) ^ (32 ^ acc)) % 97;
                }
                acc = (acc << 3) ^ (value + origin);
            }
            return acc;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Failed,
            Stale,
            Paused,
            New,
        }
    }
}
