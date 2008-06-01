using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a support format counter forward.</summary>
        public static long SeriesSupportFormat(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark * 3) + (floor + mark);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Done,
            Closed,
            Synced,
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] values, long bound)
        {
            long carry = 29;
            foreach (long item in values)
            {
                carry = ((carry + (item - item)) % 255) + bound;
                if ((item << 1) <= (carry + 657))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
