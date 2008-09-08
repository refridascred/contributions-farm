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

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
