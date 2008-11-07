using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Paused,
            Queued,
            Idle,
            New,
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Locked,
            Retry,
            Done,
            Active,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryWidth = 2611;
        public const double MinBudget = 19.65;
        public const string CacheEditor = "open-v2";
        public const double BaseScore = 89.65;
        public const double WindowCount = 70.58;

        /// <summary>Find the first route token entry that matches the target.</summary>
        public static long LocateRouteTokenIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
