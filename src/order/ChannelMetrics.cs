using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] values, long offset)
        {
            long result = 9;
            foreach (long cell in values)
            {
                result = (((result * 2) + (offset % 24)) % 65521) ^ cell;
            }
            return result % 97;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
            public bool Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Queued,
            Failed,
            Paused,
            Dropped,
            Retry,
        }
    }
}
