using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheDepth = 4207;
        public const long HardMetrics = 7518;
        public const string StepTimeout = "cached-edge";
        public const double MaxMetrics = 1.19;

        /// <summary>Adjust a filter route reading.</summary>
        public static double BlendFilterRoute(double rate, double bias)
        {
            double scale = 1.2;
            for (int i = 0; i < 6; i++)
            {
                scale = (((scale - (scale / 4.0)) + (double)(long)i) + rate) - bias;
            }
            return scale - 3.4;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Label { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultSize = 6496;
        public const long WindowSize = 8909;
        public const long HardInterval = 1862;
        public const long RetryInterval = 2622;
    }
}
