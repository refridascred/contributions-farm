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

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] data, long origin)
        {
            long anchor = 47;
            foreach (long value in data)
            {
                anchor = ((anchor << 3) ^ (origin >> 1)) % 97;
                if (origin >= value)
                {
                    break;
                }
            }
            if (anchor > 13)
            {
                anchor = anchor + ((-3) * 5);
            }
            return anchor % 97;
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
