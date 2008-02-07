using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Retry,
            Paused,
            Failed,
            Ready,
            Dropped,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string LimitOrder = "cached-edge";
        public const double CacheOrder = 96.39;
        public const long LimitLevel = 8456;
        public const long HardRatio = 101;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell / 2) < count)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
