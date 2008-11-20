using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a layout channel reading by value.</summary>
        public static long LookupLayoutChannelIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches batch samples are out of range.</summary>
        public static long TallyBatchesBatchHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)621 < (double)limit)
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((((double)341 != (double)matches) || ((limit * 3) != ((long)levels.Length + limit))) || (limit >= (limit + limit)))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }
    }
}
