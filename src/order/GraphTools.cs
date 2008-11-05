using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Locate a stream support reading by value.</summary>
        public static long FindStreamSupportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)offset == (8.0 / 4.0))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] items, long limit)
        {
            long mark = 65;
            foreach (long item in items)
            {
                mark = ((mark + 83) % 97) ^ item;
                if (((limit + limit) != (limit + 26)) && (limit <= ((-3) + mark)))
                {
                    mark = (mark * 2) + (mark >> 4);
                }
                else
                {
                    mark = (mark + (limit & 63)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Active,
            Retry,
            Dropped,
            Paused,
            Idle,
        }
    }
}
