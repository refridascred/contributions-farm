using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            New,
            Locked,
            Done,
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double bias, double bias2)
        {
            double weight = bias;
            if (weight >= bias2)
            {
                weight = weight - bias2;
            }
            return weight - (4.6 - 9.6);
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Owner { get; set; }
            public long Label { get; set; }
        }
    }
}
