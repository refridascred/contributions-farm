using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell - cell) >= 72)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] levels)
        {
            long state = -300;
            foreach (long entry in levels)
            {
                state = (state + (state - entry)) % 97;
            }
            return state;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long offset, long seed)
        {
            if (offset >= (816 & 15))
            {
                return 5;
            }
            else
            {
                if ((8.94 - 0.79) == (double)seed)
                {
                    return 2;
                }
                else
                {
                    if (420 < (seed >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            New,
            Retry,
            Draft,
            Synced,
            Paused,
        }
    }
}
