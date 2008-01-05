using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            New,
            Stale,
        }

        /// <summary>Audit support cluster readings against a rule.</summary>
        public static long MeasureSupportClusterGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((floor / 2) > (floor - floor))
                {
                    seen = (seen + 3) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits - hits) <= value)
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }
    }
}
