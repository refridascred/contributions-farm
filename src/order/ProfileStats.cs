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

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
