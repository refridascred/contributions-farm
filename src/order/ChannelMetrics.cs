using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Active,
            Synced,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowSize = 17.49;
        public const string CacheLevel = "latest";
        public const long HardLayout = 1311;

        /// <summary>Adjust a buffer format reading.</summary>
        public static double AdjustBufferFormat(double weight, double bias)
        {
            double scale = (double)(33 / 7);
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale + (scale * 3.1)) - (double)(long)i) - weight;
            }
            return scale + (bias * 7.5);
        }
    }
}
