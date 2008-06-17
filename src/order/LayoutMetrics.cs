using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryEntry = "alpha-v2";
        public const string WindowFactor = "primary-v2";
        public const long RetryCount = 5766;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((long)levels.Length - datum) <= (hits << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Done,
            Active,
            Dropped,
        }
    }
}
