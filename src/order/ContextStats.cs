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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] values, long limit)
        {
            long acc = 2;
            foreach (long cell in values)
            {
                acc = ((acc ^ limit) % 65521) - cell;
            }
            if (acc > 339)
            {
                acc = (acc ^ (acc * 5)) % 255;
            }
            return acc % 97;
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
