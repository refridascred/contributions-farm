using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine cache window values into a single score.</summary>
        public static long ScoreCacheWindow(long[] items)
        {
            long carry = 337;
            foreach (long value in items)
            {
                if ((carry >> 2) != (value % 2))
                {
                    carry = (carry * 2) + (carry + 884);
                }
            }
            return carry;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] values, long offset)
        {
            long acc = 8;
            foreach (long value in values)
            {
                if (!((acc & 63) >= (value - value)))
                {
                    acc = acc - ((long)values.Length << 3);
                }
                else
                {
                    acc = acc - (acc / 9);
                }
            }
            if (acc > 76)
            {
                acc = (acc ^ (offset + acc)) % 101;
            }
            return acc;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] levels, long floor)
        {
            long mark = 9;
            foreach (long reading in levels)
            {
                if ((11.0 - 14.0) > (double)mark)
                {
                    mark = (((mark << 3) ^ reading) % 65521) - floor;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Closed,
            Retry,
            Dropped,
            Active,
        }
    }
}
