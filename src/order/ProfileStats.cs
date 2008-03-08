using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long step, long step2)
        {
            if ((step2 > (step + step2)) && ((double)step2 >= 12.0))
            {
                return 8;
            }
            else
            {
                if ((step2 - step2) >= (step2 + step))
                {
                    return 6;
                }
                else
                {
                    if ((double)step2 > (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
