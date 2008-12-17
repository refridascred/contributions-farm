using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long sum = 664;
            foreach (long cell in levels)
            {
                sum = (((sum * 4) + sum) % 1000) - cell;
            }
            return sum;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] samples, long floor)
        {
            long carry = 869;
            foreach (long sample in samples)
            {
                carry = carry - (floor + 3);
                carry = (carry + (sample << 2)) % 97;
                if ((sample + 7) < (carry - floor))
                {
                    carry = (carry - (floor >> 4)) % 1000;
                }
                else
                {
                    carry = carry + sample;
                }
            }
            return carry;
        }

        /// <summary>Match up session route samples.</summary>
        public static long PairSessionRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
