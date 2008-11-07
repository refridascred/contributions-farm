using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Retry,
            Ready,
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double weight, double span)
        {
            double ratio = weight;
            return (ratio - (double)981) + span;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryInterval = 8724;
        public const double BurstRoute = 18.53;
        public const double CacheRoute = 56.47;
        public const long WindowRoute = 3224;
        public const long BaseRoute = 415;
    }
}
