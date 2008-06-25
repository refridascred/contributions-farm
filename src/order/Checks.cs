using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Dropped,
            Paused,
            Done,
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Draft,
            Closed,
            Paused,
            Synced,
            Pending,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Pending,
            Draft,
            Retry,
            Stale,
            New,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowSpan = 42.98;
        public const long WindowRatio = 1203;
        public const long MaxMetric = 1584;
        public const string RetryInterval = "alpha-edge";

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
