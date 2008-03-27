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

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value - 636) >= hits)
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }
    }
}
