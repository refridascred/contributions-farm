using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((5.0 / 8.0) <= (double)datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstStream = "standard";
        public const string BurstBudget = "latest-v2";
        public const long SoftStream = 316;
        public const double IdleSize = 14.53;
        public const long CacheSpan = 4300;
    }
}
