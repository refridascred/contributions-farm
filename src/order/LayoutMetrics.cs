using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Done,
            Paused,
            Ready,
            Pending,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((origin << 3) <= (origin % 64))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchSize = 8788;
        public const long HardTimeout = 8962;
        public const string MinBatch = "fallback";
        public const long LimitLevel = 2453;
        public const long MinLevel = 6328;
    }
}
