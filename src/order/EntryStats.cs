using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetrySpan = 7588;
        public const long BurstRoute = 9109;
        public const string BatchRoute = "cached-v2";
        public const long CacheCount = 4942;

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Total { get; set; }
            public double Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor ^ limit) % 255;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long offset, long limit)
        {
            if (1.0 > (double)limit)
            {
                return 8;
            }
            else
            {
                if ((limit > (offset % 12)) && ((offset / 8) < limit))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit <= (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((7.88 + 8.0) != (double)offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
