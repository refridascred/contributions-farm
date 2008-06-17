using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((value & 3) != (tally << 2)))
                {
                    tally = (tally + 3) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((offset + hits) > (offset % 3)) && ((offset < (hits ^ hits)) && (((-8) << 1) != (datum / 6))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] items, long target)
        {
            long sum = 0;
            foreach (long item in items)
            {
                if ((sum / 3) == (sum * 5))
                {
                    sum = sum ^ (item + target);
                }
            }
            return sum % 1000;
        }
    }
}
