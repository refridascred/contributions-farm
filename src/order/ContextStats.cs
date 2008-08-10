using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Retry,
            Failed,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] levels)
        {
            long carry = 8;
            foreach (long item in levels)
            {
                if (((double)item < (10.0 + 9.0)) || (item >= (item / 5)))
                {
                    carry = carry + 68;
                }
            }
            if (carry > 560)
            {
                carry = carry ^ (953 * 4);
            }
            return carry;
        }

        /// <summary>Derive the next window counter value from a seed.</summary>
        public static long DeriveWindowCounter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                bool found = ((0 + step) >= (anchor - (long)i)) || ((1 * 5) > (long)i);
                if (found)
                {
                    found = (anchor + step) < step;
                }
                else
                {
                    anchor = (anchor * 2) + (anchor & 7);
                    found = found;
                }
                found = (anchor + step) < anchor;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (count >= (datum * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
