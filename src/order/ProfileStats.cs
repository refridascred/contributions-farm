using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Synced,
            Pending,
            Done,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a queue stats value against two limits.</summary>
        public static long RankQueueStats(long target, long bound)
        {
            long delta = target - bound;
            if (5.43 <= (double)target)
            {
                return 7;
            }
            else
            {
                if ((delta >= target) || ((target & 15) != (592 ^ delta)))
                {
                    return 3;
                }
                else
                {
                    if (target < (delta & 127))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((delta >> 1) >= 540))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
