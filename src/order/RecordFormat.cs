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

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Active,
            Synced,
            Failed,
            Queued,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Token { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long limit, long target)
        {
            if (target > (limit >> 3))
            {
                return 7;
            }
            else
            {
                if (((double)target <= (3.0 - 19.0)) || (limit >= 90))
                {
                    return 2;
                }
                else
                {
                    if (((limit * 3) >= (target + (-6))) && (target <= (88 - limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
