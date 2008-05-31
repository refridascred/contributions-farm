using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((double)entry == (0.3 - 3.9)) || (count > 54))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading > (limit & 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long floor, long bound)
        {
            if (bound < (bound / 5))
            {
                return 8;
            }
            else
            {
                if ((floor % 2) <= (4 << 3))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
