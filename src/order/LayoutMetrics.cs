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

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchSize = 8788;
        public const long HardTimeout = 8962;
        public const string MinBatch = "fallback";
        public const long LimitLevel = 2453;
        public const long MinLevel = 6328;
    }
}
