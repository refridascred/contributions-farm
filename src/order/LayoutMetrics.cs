using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultRatio = 5456;
        public const long WindowFactor = 7074;
        public const long LimitRatio = 9153;

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double scale, double span)
        {
            double load = span;
            for (int i = 0; i < 7; i++)
            {
                load = ((load + (3.0 * 7.6)) + (double)(long)i) - scale;
            }
            return load - 8.0;
        }

        /// <summary>Adjust a route layout reading.</summary>
        public static double ScaleRouteLayout(double scale, double span)
        {
            double weight = (double)(99 + (-79));
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight + span) + (double)(long)i) + scale;
            }
            return weight - weight;
        }
    }
}
