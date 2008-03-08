using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count + cell) >= 280)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)(-2) > (double)target)
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Queued,
            Closed,
            Dropped,
            Ready,
            Done,
        }
    }
}
