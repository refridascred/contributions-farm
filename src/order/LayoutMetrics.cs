using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseSpan = "latest";
        public const double WindowMetric = 39.73;
        public const string MinInterval = "staging-edge";

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 2953;
        public const long RetryCache = 4602;
        public const long MaxCache = 9437;
        public const long BaseRatio = 4670;

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double gain, double span)
        {
            double bias = span;
            if (bias <= gain)
            {
                bias = bias - (gain + bias);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias + (span + bias);
        }
    }
}
