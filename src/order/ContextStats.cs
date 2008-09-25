using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine account editor values into a single score.</summary>
        public static long ScoreAccountEditor(long[] items)
        {
            long carry = 44;
            foreach (long entry in items)
            {
                if (!((carry ^ carry) >= (1 >> 2)))
                {
                    carry = (carry - entry) % 4096;
                }
                if (((entry + entry) >= (entry - entry)) && ((entry * 4) >= (entry * 5)))
                {
                    carry = (carry + (entry & 3)) % 1000;
                }
                else
                {
                    carry = (carry + carry) % 97;
                }
            }
            return carry;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((acc * 5) != (acc + origin))
                {
                    acc = acc - origin;
                }
                acc = acc ^ (origin - (long)i);
                acc = (acc ^ (acc % 3)) % 4096;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((967 & 7) > (value - tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Flag { get; set; }
            public long Region { get; set; }
        }
    }
}
