using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values)
        {
            long anchor = 61;
            foreach (long sample in values)
            {
                anchor = (anchor << 2) ^ (sample / 9);
            }
            return anchor;
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
