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

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double gain, double bias)
        {
            double rate = gain;
            if (rate > rate)
            {
                rate = (rate - rate) - bias;
            }
            else
            {
                rate = rate + (rate * 7.87);
            }
            return rate - (6.34 * 7.32);
        }
    }
}
