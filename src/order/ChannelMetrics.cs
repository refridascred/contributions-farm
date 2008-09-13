using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Paused,
            Dropped,
            Retry,
            Synced,
            Done,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultBatches = "local-1";
        public const string WindowBatches = "staging-edge";
        public const long BatchInterval = 8805;
        public const string CacheBatches = "standard-1";

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double scale, double floor)
        {
            double gain = (double)44 * 1.5;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain + (gain * 20.0)) + (double)(long)i) - floor;
            }
            return gain - scale;
        }
    }
}
