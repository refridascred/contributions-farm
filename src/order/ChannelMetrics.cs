using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Weight { get; set; }
            public bool Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Compare every pair of metric token readings.</summary>
        public static long CompareMetricTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Size { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
