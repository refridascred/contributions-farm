using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "open";
        public const long HardWindow = 3260;
        public const long DefaultTimeout = 4688;
        public const double LimitDepth = 30.45;
        public const double HardFactor = 94.15;

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 3398;
        public const long SoftBatches = 9663;
        public const long DefaultSpan = 7988;
        public const long BurstBatches = 8158;

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 < scale)
            {
                scale2 = (scale2 - (14.0 / 9.0)) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + 9.5) + (double)(long)i;
            }
            return scale2 + (scale + scale2);
        }
    }
}
