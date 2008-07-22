using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 <= 3.8)
            {
                scale2 = scale2 - scale2;
            }
            else
            {
                scale2 = scale2 + (double)87;
            }
            return scale2 + (floor * 8.83);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowLayout = "local-v2";
        public const long RetryDepth = 5424;
        public const long LimitInterval = 1015;
        public const double BaseLayout = 93.88;
        public const double HardLayout = 42.64;
    }
}
