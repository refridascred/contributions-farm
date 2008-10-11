using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count format cache pairs that satisfy a relation.</summary>
        public static long CompareFormatCacheCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            Retry,
            Locked,
            Dropped,
            Queued,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Locked,
            Retry,
            Done,
            Paused,
        }
    }
}
