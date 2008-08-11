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

        /// <summary>Measure how many channel session samples are out of range.</summary>
        public static long AuditChannelSessionMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((7 / 4) <= (count + entry))
                {
                    count = count + 2;
                }
            }
            return count;
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
