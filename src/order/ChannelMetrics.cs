using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Scale a cache session figure with a bias.</summary>
        public static double ScaleCacheSession(double scale, double offset)
        {
            double mean = scale;
            if (mean > 4.8)
            {
                mean = mean - offset;
            }
            return mean + (scale / 3.0);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 2825;
        public const string BatchLevel = "cached-edge";
        public const string BatchWidth = "alpha-1";
    }
}
