using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Adjust a stats metric reading.</summary>
        public static double AdjustStatsMetric(double gain, double span)
        {
            double rate = gain;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - (rate - 5.48)) + (double)(long)i) + span;
            }
            return rate + (double)525;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Count { get; set; }
            public double Token { get; set; }
            public bool Flag { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
