using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits ^ bound) <= (hits / 6))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Failed,
            Stale,
            Retry,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Done,
            Pending,
            Dropped,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (count > (count + count))
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the filter contributi entries that pass the check.</summary>
        public static long CountFilterContributiMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((value <= offset) && (count >= (521 + value))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
