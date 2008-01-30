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

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double ratio, double offset)
        {
            double weight = ratio - (offset * 0.87);
            if (weight > (ratio - weight))
            {
                weight = weight + (double)313;
            }
            else
            {
                weight = weight + (offset * 4.4);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight + weight;
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
