using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 8684;
        public const double BatchDepth = 52.34;
        public const string IdleStats = "strict-v2";
        public const long CacheLevel = 1673;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Stale,
            Dropped,
            Done,
            Paused,
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Locked,
            Pending,
            Idle,
        }

        /// <summary>Check that every batch cluster entry stays within the limit.</summary>
        public static bool GuardBatchClusterLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Label { get; set; }
            public long Flag { get; set; }
        }
    }
}
