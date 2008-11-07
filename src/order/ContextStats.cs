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

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 3056;
        public const long CacheScore = 2854;
        public const long CacheWidth = 7491;
        public const long BatchProfile = 6769;
        public const string DefaultScore = "stable-v2";

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
