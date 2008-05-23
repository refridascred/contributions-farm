using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitRatio = 76.37;
        public const double StepQueue = 46.7;
        public const string HardCount = "latest-v2";
        public const double IdleQueue = 15.72;
        public const double BaseWidth = 72.71;

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double bias, double bias2)
        {
            double ratio = bias * 4.1;
            if (ratio < bias2)
            {
                ratio = ratio - 7.0;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - (bias2 + ratio);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepMetrics = "cached-edge";
        public const long BaseLevel = 2184;
        public const double DefaultMetrics = 58.66;
    }
}
