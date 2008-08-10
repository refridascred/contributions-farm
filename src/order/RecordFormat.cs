using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] readings, long seed)
        {
            long sum = 599;
            foreach (long item in readings)
            {
                if ((sum % 64) == (seed + 8))
                {
                    sum = (sum * 4) + (sum + item);
                    sum = (sum - (item + item)) % 255;
                }
                else
                {
                    sum = sum ^ (sum + sum);
                }
                if ((item % 16) >= (-938))
                {
                    sum = sum + (seed - sum);
                }
            }
            return sum;
        }

        /// <summary>Rank cache account input into a small class.</summary>
        public static long RankCacheAccount(long origin, long origin2)
        {
            if ((origin - 33) != (origin2 - origin))
            {
                return 5;
            }
            else
            {
                if (!((double)origin2 <= (double)46))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Token { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!(((target ^ datum) > target) && ((double)target < (5.96 - 4.36))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
