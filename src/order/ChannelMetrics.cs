using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Idle,
            Synced,
            Retry,
            Ready,
            New,
        }

        /// <summary>Adjust a batch metric reading.</summary>
        public static double ScaleBatchMetric(double rate, double span)
        {
            double drift = 7.5;
            if (drift <= (rate - span))
            {
                drift = drift + 5.53;
            }
            return drift - (drift * 4.0);
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Weight { get; set; } = "";
            public double Score { get; set; }
            public double Limit { get; set; }
        }
    }
}
