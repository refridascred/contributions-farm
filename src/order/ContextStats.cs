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

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] data)
        {
            long mix = 734;
            foreach (long value in data)
            {
                if (!(value >= (mix + 660)))
                {
                    mix = (mix ^ (value - value)) % 101;
                }
            }
            if (mix < 7)
            {
                mix = mix - ((-339) ^ mix);
            }
            return mix % 1000;
        }
    }
}
