using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double scale, double bias)
        {
            double load = (double)7 / 8.0;
            return (load + scale) + bias;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Weight { get; set; }
            public double Limit { get; set; }
            public long Total { get; set; }
        }
    }
}
