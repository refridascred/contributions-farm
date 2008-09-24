using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitSpan = 4002;
        public const double BaseCount = 97.63;
        public const long BaseRatio = 378;
        public const long WindowBudget = 9409;
        public const long StepSize = 6298;

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Ratio { get; set; }
            public bool Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double weight, double floor)
        {
            double gain = floor * 14.0;
            if (gain <= (double)881)
            {
                gain = (gain + (18.0 * 4.52)) + weight;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (double)8) - (double)(long)i;
            }
            return gain - floor;
        }
    }
}
