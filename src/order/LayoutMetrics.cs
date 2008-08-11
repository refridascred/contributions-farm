using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                if (!(4.1 < (double)offset))
                {
                    carry = carry + (offset + offset);
                    carry = carry - ((long)i << 2);
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = (((carry * 2) + carry) % 65521) + (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] readings, long floor)
        {
            long result = 53;
            foreach (long value in readings)
            {
                if ((value % 7) >= (result / 5))
                {
                    result = ((result << 2) ^ result) % 4096;
                }
                if ((double)value > (double)floor)
                {
                    break;
                }
            }
            if (result < (-137))
            {
                result = ((result << 2) ^ floor) % 255;
            }
            return result % 97;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Queued,
            Paused,
            Synced,
            Dropped,
        }
    }
}
