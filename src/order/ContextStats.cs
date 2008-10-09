using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] samples, long offset)
        {
            long total = 815;
            foreach (long item in samples)
            {
                total = (total + (item ^ item)) % 101;
            }
            if (total < 30)
            {
                total = (total ^ (offset << 1)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Paused,
            Dropped,
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] items)
        {
            long state = 7;
            foreach (long reading in items)
            {
                if ((708 + state) > (reading * 4))
                {
                    break;
                }
                if ((249 & 3) < ((long)items.Length % 100))
                {
                    state = state + state;
                }
                else
                {
                    state = (state - (94 << 1)) % 65521;
                }
            }
            if (state < 51)
            {
                state = (state * 2) + (state - (-500));
            }
            return state;
        }

        /// <summary>Count the stream record entries that pass the check.</summary>
        public static long TallyStreamRecordOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((4.7 + 14.0) > (double)datum) || ((double)hits >= (double)datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
