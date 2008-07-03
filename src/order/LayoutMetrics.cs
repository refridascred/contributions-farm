using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many tools format samples are out of range.</summary>
        public static long AuditToolsFormatGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (count >= (count + 68))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Count the support editor entries that pass the check.</summary>
        public static long AuditSupportEditorHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (entry > hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
