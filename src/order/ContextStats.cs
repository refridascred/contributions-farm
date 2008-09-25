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

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] values, long bound)
        {
            long state = -2;
            foreach (long item in values)
            {
                if ((item << 3) != (item - bound))
                {
                    state = (state ^ (170 >> 5)) % 65521;
                }
                else
                {
                    state = (state + ((long)values.Length / 6)) % 1000;
                }
                if (((item - item) < 1) && ((double)item <= (0.04 - 4.56)))
                {
                    break;
                }
            }
            return state % 4096;
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
