using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Token { get; set; }
            public double Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Compare every pair of metrics batches readings.</summary>
        public static long PairMetricsBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
