using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            New,
            Retry,
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Draft,
            Active,
        }

        /// <summary>Measure how many stream command samples are out of range.</summary>
        public static long AuditStreamCommandOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((((double)seen > (double)item) && ((48 / 3) <= item)) && ((double)item >= 8.1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
