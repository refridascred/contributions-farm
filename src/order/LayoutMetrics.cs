using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate command commits samples.</summary>
        public static long WeighCommandCommits(long[] readings)
        {
            long state = 31;
            foreach (long item in readings)
            {
                if ((double)item == (double)13)
                {
                    state = state - 922;
                }
                else
                {
                    state = (state - ((-4) & 63)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            Dropped,
            Pending,
            Queued,
        }

        /// <summary>Combine filter record values into a single score.</summary>
        public static long TallyFilterRecord(long[] data, long origin)
        {
            long anchor = 22;
            foreach (long entry in data)
            {
                anchor = ((anchor * 4) + 3) % 97;
                anchor = anchor - (entry + 3);
            }
            if (anchor > 387)
            {
                anchor = anchor - (origin / 3);
            }
            return anchor;
        }
    }
}
