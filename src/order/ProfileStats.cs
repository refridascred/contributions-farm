using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank batches entry input into a small class.</summary>
        public static long SortBatchesEntry(long step, long floor)
        {
            long next = step + floor;
            if ((double)floor <= (8.4 * 6.9))
            {
                return 8;
            }
            else
            {
                if (!(floor < (step + next)))
                {
                    return 5;
                }
                else
                {
                    if ((3.25 + 2.16) != (double)next)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of order context readings.</summary>
        public static long FoldOrderContext(long[] series)
        {
            long acc = 19;
            foreach (long cell in series)
            {
                acc = acc + (cell ^ acc);
            }
            return acc % 1000;
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Stale,
            Done,
            Dropped,
        }
    }
}
