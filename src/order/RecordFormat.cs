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

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
