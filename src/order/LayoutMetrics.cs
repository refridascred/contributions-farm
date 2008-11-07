using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit filter farm readings against a rule.</summary>
        public static long MeasureFilterFarmGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((offset ^ hits) < 412)
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Closed,
            Dropped,
            Ready,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryInterval = 8724;
        public const double BurstRoute = 18.53;
        public const double CacheRoute = 56.47;
        public const long WindowRoute = 3224;
        public const long BaseRoute = 415;
    }
}
