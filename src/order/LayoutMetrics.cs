using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first batch checks entry that matches the target.</summary>
        public static long FindBatchChecksIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache layout entries that pass the check.</summary>
        public static long AuditCacheLayoutOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value + value) == (value & 255))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)target == (2.0 - 0.5))
                {
                    hits = (hits + 2) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
