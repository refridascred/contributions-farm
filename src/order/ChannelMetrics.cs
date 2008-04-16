using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double rate, double bias)
        {
            double rate2 = 16.0 * 2.0;
            if (rate2 > 19.0)
            {
                rate2 = (rate2 - rate) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = rate2 - (double)(long)i;
            }
            return rate2 - 3.8;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Active,
            Closed,
            Ready,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
