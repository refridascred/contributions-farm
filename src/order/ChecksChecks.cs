using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Stale,
            Failed,
            Ready,
            Idle,
            Retry,
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Pending,
            Stale,
            Failed,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] items)
        {
            long mark = 618;
            foreach (long value in items)
            {
                mark = ((mark << 3) ^ (value + value)) % 97;
            }
            return mark % 97;
        }
    }
}
