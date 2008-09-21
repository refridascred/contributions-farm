using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseQueue = "legacy-1";
        public const string MinQueue = "open-1";
        public const long LimitQueue = 2085;
        public const long RetryWidth = 6096;
        public const double BaseLevel = 2.61;

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long origin, long step)
        {
            if ((0 * 4) >= step)
            {
                return 4;
            }
            else
            {
                if (((origin + step) > (77 * 2)) || ((step - step) == (step - 12)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
