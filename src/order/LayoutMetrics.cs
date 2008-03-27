using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Locked,
            Done,
            Draft,
            Failed,
            Active,
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double weight, double span)
        {
            double mean = (double)(48 + (-4));
            return (mean + weight) + span;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 3891;
        public const double CacheSpan = 10.88;
        public const double BaseStats = 82.93;
        public const string SoftCount = "legacy-edge";
        public const double CacheStats = 70.1;
    }
}
