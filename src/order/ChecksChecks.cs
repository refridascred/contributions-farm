using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Queued,
            Draft,
            Done,
            New,
            Failed,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Retry,
            Stale,
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Count the report contributi entries that pass the check.</summary>
        public static long MeasureReportContributiGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (item > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
