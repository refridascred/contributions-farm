using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Token { get; set; } = "";
            public double Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double rate, double span)
        {
            double rate2 = span;
            if (rate2 < rate)
            {
                rate2 = rate2 - (rate - 7.0);
            }
            else
            {
                rate2 = rate2 - (16.0 + rate);
            }
            return rate2 + 7.9;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Token { get; set; } = "";
            public bool Count { get; set; }
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
