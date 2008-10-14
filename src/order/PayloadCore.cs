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

        /// <summary>Count the session layout entries that pass the check.</summary>
        public static long TallySessionLayoutMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)cell < (double)tally)
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Paused,
            Done,
            Closed,
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
