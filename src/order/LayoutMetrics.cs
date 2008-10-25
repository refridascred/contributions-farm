using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Check that every queue metric entry stays within the limit.</summary>
        public static bool GuardQueueMetricRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((long)items.Length << 3) == (hits ^ step))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }
    }
}
