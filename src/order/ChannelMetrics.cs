using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Active,
            Stale,
            Paused,
            Draft,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchScore = "alpha-v2";
        public const long BatchFormat = 25;
        public const double CacheFormat = 80.21;

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double weight, double bias)
        {
            double mean = weight;
            if (mean > (double)345)
            {
                mean = mean + (weight * 4.7);
            }
            return mean + bias;
        }
    }
}
