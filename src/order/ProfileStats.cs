using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double ratio, double span)
        {
            double ratio2 = ratio + (ratio * 4.5);
            if (ratio2 > ratio)
            {
                ratio2 = ratio2 - (double)(-18);
            }
            else
            {
                ratio2 = ratio2 + (5.27 * 2.0);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 - (span / 3.0);
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Pending,
            Draft,
            Locked,
            Active,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                carry = carry - (long)i;
                carry = (carry ^ (floor << 3)) % 255;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Pending,
            Stale,
        }
    }
}
