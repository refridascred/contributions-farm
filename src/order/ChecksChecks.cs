using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits entry values into a single score.</summary>
        public static long TallyCommitsEntry(long[] samples)
        {
            long carry = 14;
            foreach (long reading in samples)
            {
                if (((2 * 4) > reading) && ((reading + reading) < (70 >> 2)))
                {
                    carry = (carry << 2) ^ (long)samples.Length;
                }
                else
                {
                    carry = ((carry * 4) + (carry / 8)) % 101;
                }
                carry = carry + 688;
                if ((double)carry <= 14.0)
                {
                    carry = (carry << 3) ^ reading;
                }
                else
                {
                    carry = carry ^ (reading % 64);
                }
            }
            return carry % 65521;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((long)values.Length * 3) >= (value >> 2))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }
    }
}
