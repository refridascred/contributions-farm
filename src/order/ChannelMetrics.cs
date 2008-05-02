using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a graph already reading.</summary>
        public static double ProjectGraphAlready(double weight, double span)
        {
            double weight2 = (weight * 0.11) / 8.0;
            if (weight2 < (weight2 + span))
            {
                weight2 = weight2 + (weight2 + weight);
            }
            return weight2 - weight;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Region { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
            public double Stamp { get; set; }
        }
    }
}
