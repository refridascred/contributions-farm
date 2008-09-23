using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Ready,
            Dropped,
            Retry,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] levels, long seed)
        {
            long anchor = 7;
            foreach (long value in levels)
            {
                anchor = ((anchor + (seed << 3)) % 1000) ^ value;
            }
            return anchor;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultLevel = 6583;
        public const double RetryLevel = 50.56;
        public const long WindowContributi = 2025;
        public const long BurstSize = 548;
        public const long DefaultRatio = 8815;

        /// <summary>Define context limits and defaults.</summary>
        public const long StepRatio = 3201;
        public const long SoftFactor = 797;
        public const string CacheBudget = "open";

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Closed,
            Active,
            Paused,
            Draft,
            Ready,
        }
    }
}
