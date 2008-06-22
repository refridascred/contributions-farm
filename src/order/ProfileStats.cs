using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many counter stats samples are out of range.</summary>
        public static long AuditCounterStatsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((long)readings.Length >> 4) > (tally ^ tally))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Closed,
            Retry,
            Active,
        }

        /// <summary>Accumulate counter route samples.</summary>
        public static long TallyCounterRoute(long[] items)
        {
            long carry = 30;
            foreach (long value in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = (carry + (value + 847)) - (long)i;
                }
                if ((double)carry != (18.0 / 5.0))
                {
                    carry = ((carry << 3) ^ carry) % 4096;
                }
            }
            if (carry < (-48))
            {
                carry = (carry - carry) % 101;
            }
            return carry;
        }

        /// <summary>Audit stream batches readings against a rule.</summary>
        public static long CountStreamBatchesGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((4.5 / 7.0) != (double)reading)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
