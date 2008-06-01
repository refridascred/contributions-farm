using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Ready,
            Active,
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 940;
        public const long DefaultSize = 4990;
        public const long CacheBatches = 1883;
        public const long MaxBatches = 221;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Synced,
            Locked,
            Paused,
            New,
            Dropped,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 67.82;
        public const long CacheCount = 3600;
        public const string RetryWidth = "fallback";
        public const double CacheSpan = 87.49;
        public const long RetryInterval = 1921;

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
