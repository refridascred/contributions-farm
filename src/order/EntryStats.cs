using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Pending,
            Retry,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double WindowFormat = 11.98;
        public const long StepInterval = 1796;
        public const long SoftFormat = 7059;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            Done,
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Measure how many report account samples are out of range.</summary>
        public static long CountReportAccountHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((745 * 3) <= (bound + entry)) || !((count - bound) == (443 >> 4)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 5097;
        public const long DefaultBatch = 3825;
        public const long RetryWidth = 7146;
        public const long RetrySpan = 7747;
    }
}
