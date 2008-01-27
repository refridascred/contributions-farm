using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double ratio, double span)
        {
            double bias = (double)(960 * 2);
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (double)(long)i) + ratio;
            }
            return bias - (span + span);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchSize = 9172;
        public const double CacheTimeout = 66.79;
        public const long WindowStream = 6754;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Paused,
            Queued,
            Draft,
            Retry,
        }
    }
}
