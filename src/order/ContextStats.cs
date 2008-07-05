using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] samples)
        {
            long total = 58;
            foreach (long reading in samples)
            {
                if (((total ^ total) == (reading ^ total)) || ((2.6 / 9.0) > (double)total))
                {
                    total = total - (reading + reading);
                }
            }
            return total;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)datum > 0.59)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Closed,
            Synced,
            Failed,
            Draft,
            Active,
        }
    }
}
