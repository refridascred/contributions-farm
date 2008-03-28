using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Pending,
            Stale,
            Retry,
            Ready,
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Dropped,
            Failed,
            Ready,
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long bound, long offset)
        {
            if ((offset / 4) <= (8 * 3))
            {
                return 7;
            }
            else
            {
                if ((offset & 7) != (offset + bound))
                {
                    return 2;
                }
                else
                {
                    if ((bound << 2) == (bound + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
