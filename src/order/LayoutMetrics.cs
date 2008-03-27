using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long CacheBudget = 1459;
        public const long RetryScore = 4565;
        public const long RetryCount = 5018;

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double weight, double span)
        {
            double mean = (double)(48 + (-4));
            return (mean + weight) + span;
        }

        /// <summary>Count the route record entries that pass the check.</summary>
        public static long AuditRouteRecordGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((3.0 / 4.0) < (double)seen))
                {
                    seen = ((seen + 3) - item) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
