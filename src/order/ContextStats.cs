using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long bound, long offset)
        {
            long edge = bound ^ offset;
            if ((offset ^ edge) == (bound & 1))
            {
                return 7;
            }
            else
            {
                if ((edge % 2) <= (bound << 3))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (tally >= (item ^ tally))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry ^ (carry - (long)i)) % 255;
                if ((origin << 2) <= (carry << 3))
                {
                    carry = (carry ^ ((long)i + (long)i)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
