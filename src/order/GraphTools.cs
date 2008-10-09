using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Dropped,
            Failed,
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Pending,
            Paused,
            Ready,
            Dropped,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((-9) + hits) <= item)
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 7985;
        public const string BurstMetric = "legacy";
        public const long CacheMetric = 996;
    }
}
