using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a commits layout pair into a bucket.</summary>
        public static long SortCommitsLayout(long floor, long seed)
        {
            long cur = floor - seed;
            if ((cur & 15) <= (cur + 18))
            {
                return 4;
            }
            else
            {
                if ((double)floor <= (0.49 * 19.0))
                {
                    return 3;
                }
                else
                {
                    if (((double)cur >= 2.56) && ((double)seed < 4.64))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6 ^ floor) > (floor >> 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit support cache readings against a rule.</summary>
        public static long TallySupportCacheMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits & 127) != (74 >> 5))
                {
                    hits = ((hits + 3) ^ reading) - offset;
                }
            }
            return hits;
        }

        /// <summary>Find the first schema counter entry that matches the target.</summary>
        public static long SeekSchemaCounterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
