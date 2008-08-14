using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Closed,
            Dropped,
            Active,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 2943;
        public const double MinRatio = 68.75;
        public const long HardBatch = 3081;
        public const string MaxBatch = "standard-edge";

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double bias, double offset)
        {
            double load = 5.9;
            for (int i = 0; i < 5; i++)
            {
                load = ((load + (5.0 * 9.9)) + (double)(long)i) - offset;
            }
            return load - (bias + bias);
        }
    }
}
