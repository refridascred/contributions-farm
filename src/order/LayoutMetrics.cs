using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((item + count) <= (count + count)) || ((2 >> 2) > (item - count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the batches notes entries that pass the check.</summary>
        public static long AuditBatchesNotesOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)item == (double)offset)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
