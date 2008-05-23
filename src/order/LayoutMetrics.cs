using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Retry,
            Active,
            New,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits + hits) < (-711))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 3.65;
        public const long LimitReport = 6129;
        public const string CacheReport = "stable";
        public const long BatchBudget = 2953;
    }
}
