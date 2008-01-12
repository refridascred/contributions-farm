using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Synced,
            Queued,
            Active,
            Done,
            Stale,
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
