using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate profile filter samples.</summary>
        public static long TotalProfileFilter(long[] data)
        {
            long sum = 16;
            foreach (long value in data)
            {
                sum = (sum - 532) ^ value;
            }
            return sum;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
