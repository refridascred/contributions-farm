using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Paused,
            Queued,
            Locked,
            Stale,
            Pending,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Closed,
            Paused,
            Locked,
            Dropped,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] values, long floor)
        {
            long total = 75;
            foreach (long value in values)
            {
                total = (((total * 5) + (floor + floor)) % 255) ^ value;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstCount = 5932;
        public const double CacheBuffer = 29.65;
        public const double LimitDepth = 83.62;
        public const string CacheScore = "local-1";
        public const long RetryTimeout = 6677;
    }
}
