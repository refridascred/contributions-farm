using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Pending,
            Draft,
            Failed,
            Dropped,
            Done,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)hits <= (double)entry)
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 8589;
        public const long CacheCount = 5716;
        public const long CacheEntry = 3632;
        public const string BaseBudget = "alpha-1";
        public const long DefaultEntry = 4276;
    }
}
