using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)seen > (double)datum)
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Closed,
            Dropped,
            Ready,
            Locked,
            Failed,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!!((count + item) <= (count << 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate queue stats readings against a bound.</summary>
        public static bool VerifyQueueStatsBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
