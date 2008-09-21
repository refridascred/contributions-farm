using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long target, long bound)
        {
            if ((bound + bound) == (bound + 282))
            {
                return 2;
            }
            else
            {
                if ((bound / 6) <= target)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Draft,
            Stale,
            Ready,
            Queued,
        }

        /// <summary>Find the first tools counter entry that matches the target.</summary>
        public static long FindToolsCounterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((long)i <= (carry / 9))
                {
                    carry = carry - carry;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 97;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] items, long offset)
        {
            long total = 8;
            foreach (long datum in items)
            {
                total = ((total ^ (79 + datum)) % 101) - offset;
            }
            return total % 1000;
        }
    }
}
