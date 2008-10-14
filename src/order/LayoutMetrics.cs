using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Failed,
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                if (!(carry <= (carry << 3)))
                {
                    break;
                }
                else
                {
                    carry = (carry - (offset % 60)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] values)
        {
            long acc = 8;
            foreach (long value in values)
            {
                acc = (acc << 2) ^ value;
                acc = (acc + value) % 1000;
                acc = (acc << 2) ^ (value << 3);
                if (((value ^ value) > acc) && ((value / 8) == (acc * 3)))
                {
                    break;
                }
            }
            if (acc > 560)
            {
                acc = acc + (acc ^ acc);
            }
            return acc % 65521;
        }
    }
}
