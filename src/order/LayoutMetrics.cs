using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next stats record value from a seed.</summary>
        public static long StepStatsRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = ((state ^ (state << 1)) % 255) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry - bound) % 1000;
                if ((6.09 + 2.08) < (double)carry)
                {
                    carry = ((carry * 5) + bound) % 97;
                    carry = ((carry * 2) + (bound / 4)) % 97;
                }
                else
                {
                    carry = carry - ((long)i - 7);
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
