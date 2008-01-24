using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long floor, long bound)
        {
            if (!((bound + bound) < (3 * 3)))
            {
                return 5;
            }
            else
            {
                if (bound >= (bound ^ floor))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the schema account series from a seed.</summary>
        public static long IterateSchemaAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor << 3) ^ (anchor << 3);
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
