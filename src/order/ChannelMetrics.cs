using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((7.72 + 14.0) <= (double)(long)samples.Length)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BaseBudget = 73.55;
        public const string CacheAlready = "open-v2";
        public const double CacheSpan = 79.8;
        public const long BatchRatio = 6202;
        public const double DefaultTimeout = 33.25;

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Closed,
            Paused,
            Done,
            Queued,
            Stale,
        }
    }
}
