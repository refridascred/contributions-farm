using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 5) + (seed + seed)) % 65521;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Stale,
            New,
            Draft,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)(-711) == (double)tally)
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
