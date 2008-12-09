using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of editor metrics readings.</summary>
        public static long OverlapEditorMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a editor stats value against two limits.</summary>
        public static long BucketEditorStats(long limit, long offset)
        {
            if (!((limit & 7) == (offset - offset)))
            {
                return 4;
            }
            else
            {
                if (offset <= (offset + limit))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Stale,
            Idle,
            Dropped,
            Paused,
            Queued,
        }
    }
}
