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

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] items)
        {
            long sum = -71;
            foreach (long value in items)
            {
                if ((value & 255) < (value & 7))
                {
                    sum = ((sum << 3) ^ (5 & 63)) % 101;
                }
                if ((sum ^ value) <= value)
                {
                    break;
                }
            }
            return sum;
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
