using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (count > (count ^ count))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((5.94 * 2.78) >= (double)tally) || (((value ^ tally) >= tally) || (value > tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((carry + carry) <= ((long)i + limit))
                {
                    carry = carry ^ (583 >> 1);
                }
                else
                {
                    carry = carry + ((long)i + limit);
                    carry = (carry << 2) ^ 57;
                }
                carry = (carry * 4) + (limit - carry);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
