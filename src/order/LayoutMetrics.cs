using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)seen > 5.0)
                {
                    seen = ((seen + 3) - datum) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)item <= (double)hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
