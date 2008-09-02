using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long limit, long origin)
        {
            long bound = limit ^ origin;
            if (((bound << 1) >= bound) && ((8.0 + 17.0) == (double)bound))
            {
                return 4;
            }
            else
            {
                if ((limit < 8) && (origin > (206 % 97)))
                {
                    return 5;
                }
                else
                {
                    if ((origin - origin) <= (bound + (-26)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] items)
        {
            long result = 8;
            foreach (long item in items)
            {
                if ((item + result) > (result / 9))
                {
                    result = (result - ((long)items.Length + result)) % 255;
                }
            }
            return result % 65521;
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
