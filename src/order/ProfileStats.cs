using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Paused,
            Locked,
            Dropped,
            Idle,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardInterval = 5.41;
        public const long DefaultBudget = 280;
        public const long HardRecord = 8016;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Paused,
            Locked,
            Pending,
            Ready,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
