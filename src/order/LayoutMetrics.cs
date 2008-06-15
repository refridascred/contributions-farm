using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the stream context entries that pass the check.</summary>
        public static long TallyStreamContextHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item + count) >= origin)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Pending,
            Synced,
        }

        /// <summary>Rank queue contributi input into a small class.</summary>
        public static long ClassifyQueueContributi(long offset, long target)
        {
            long offset2 = offset ^ target;
            if ((double)target == (3.06 + 0.42))
            {
                return 6;
            }
            else
            {
                if ((target & 31) > (offset2 % 10))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
