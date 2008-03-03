using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a route layout reading.</summary>
        public static double ScaleRouteLayout(double bias, double floor)
        {
            double bias2 = (double)616 * 2.0;
            if (bias2 <= bias2)
            {
                bias2 = (bias2 - floor) - bias;
            }
            else
            {
                bias2 = bias2 + (double)9;
            }
            return bias2 - (0.58 + floor);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinCount = 6223;
        public const long IdleRatio = 1699;
        public const long IdleTools = 8647;
        public const long CacheTools = 1146;
        public const long CacheWidth = 5437;

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Paused,
            Done,
        }
    }
}
