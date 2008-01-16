using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)item >= (double)9)
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
